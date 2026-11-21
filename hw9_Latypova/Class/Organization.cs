using hw9_Latypova.Interface;

namespace hw9_Latypova.Class
{
    public class Organization: IFixPlay, IPrintInfo
    {
        public string Name { get; set; } 
        public List<Play> Plays { get; set; }
        public List<Comand> Comands { get; set; }
        public Organization(string name)
        {
            Name = name;
            Plays = new List<Play>();
            Comands = new List<Comand>();
        }

        public bool AddCommand()
        {
            Console.Write("Создание команды. Введите название: ");
            string nameCommand = Console.ReadLine();

            if (nameCommand is not null)
            {
                foreach(Comand comand in Comands)
                {
                    if(comand.Name == nameCommand)
                    {
                        Console.WriteLine("Создание команды с таким именем невозможно. Уже существует команда с данным названием");
                        return false;
                    }
                }

                Comand newCommand = new Comand(nameCommand);
                Console.WriteLine("Команда создана");
            }

            Console.WriteLine("Ошибка: ввод пустого названия. Команда НЕ создана");
            return false;
        }
        public bool AddPlay()
        {
            Console.WriteLine($"");
            Console.Write("Название:  ");
            string name = Console.ReadLine();
            Console.Write("Краткое описание:  ");
            string description = Console.ReadLine();
            Console.Write("Правила игры:  ");
            string rules = Console.ReadLine();
            if (name is not null && description is not null && rules is not null)
            {
                Play newPlay = new Play(name, description, rules);
                Console.WriteLine($"Игра {name} успешно добавлена");
                return true;
            }
            Console.WriteLine("Недопустимо пустое значение. Игра НЕ добавлена");
            return false;
        }

        public bool RemovePlay()
        {
            Console.WriteLine("Удаление игры");

            if (Comands.Count == 0)
            {
                Console.WriteLine("Игр на данный момент нет. Удаление невозможно");
                return false;
            }

            Console.Write("Имя: ");
            string name = Console.ReadLine();

            foreach (Play play in Plays)
            {
                if (name == play.Name)
                {
                    Plays.Remove(play);
                    Console.WriteLine($"Игра {name} удалена");
                    return true;
                }
            }
            Console.WriteLine("Игра не найдена. Удаление НЕ выполнено");
            return false;
        }

        public void PrintPlays()
        {
            foreach(Play play in Plays)
            {
                Console.WriteLine($"Название: {play.Name}; описание: {play.Description}");
            }
        }

        public void PrintOnConsole()
        {
            Console.WriteLine("Наши команды!");
            foreach(Comand comand in Comands)
            {
                Console.WriteLine($"Название: {comand.Name}; количесвто участников: {comand.Players.Count}");
            }

            Console.WriteLine("Наши игры!");
            foreach(Play play in Plays)
            {
                Console.WriteLine($"Название: {play.Name}");
            }

            Console.WriteLine($"Самый лучший организатор: {Name}");
        }
    }

}
