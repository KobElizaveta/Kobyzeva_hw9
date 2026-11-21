using hw9_Latypova.Interface;

namespace hw9_Latypova.Class
{
    public class Play: IPrintInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rules { get; set; }
        public Play(string name, string description, string rules)
        {
            Name = name;
            Description = description;
            Rules = rules;
        }

        public void PrintOnConsole()
        {
            Console.WriteLine($"Название: {Name}; Описание: {Description}");
            Console.WriteLine($"Правила: {Rules}");
        }

        public Comand? ConductingGame(List<Comand> comands)
        {
            if(comands.Count != 6)
            {
                Console.WriteLine("В игре должно участвовать ровно 6 команд. Сейчас количество иное. Игра не пройдет");
                return null;
            }
               
            Console.WriteLine($"Начинается игра - {Name}");
            Console.WriteLine($"Ознакомимся с правилами: {Rules}");

            Random rnd = new Random();
            var victory = comands[rnd.Next(comands.Count)];
            Console.WriteLine($"Победителем стала команда - {victory}");
            return victory;
        }
    }
}
