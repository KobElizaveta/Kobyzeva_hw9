using hw9_Latypova.Interface;

namespace hw9_Latypova.Class
{
    public abstract class Game: IGame, IPrintInfo
    {
        private static Random rnd = new Random();
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Rules { get; }

        public virtual Comand? Play(List<Comand> commands)
        {
            if (commands.Count != 4)
            {
                Console.WriteLine("В игре должно участвовать ровно 4 команды. Сейчас количество иное. Игра не пройдет");
                return null;
            }

            Console.WriteLine($"Начинается игра - {Name}");
            Console.WriteLine($"Ознакомимся с правилами: {Rules}");

            var victory = commands[rnd.Next(commands.Count)];
            Console.WriteLine($"Победителем стала команда - {victory.Name}");
            return victory;
        }

        public void PrintOnConsole()
        {
            Console.WriteLine($"Название: {Name}; Описание: {Description}");
            Console.WriteLine($"Правила: {Rules}");
        }
    }
}
