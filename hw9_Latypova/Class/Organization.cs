using hw9_Latypova.Games;
using hw9_Latypova.Interface;

namespace hw9_Latypova.Class
{
    public class Organization: IPrintInfo
    {
        public string Name { get; set; } 
        public List<Game> Plays { get; set; }
        public List<Game> CurrentPLays { get; set; }
        public List<Comand> Comands { get; set; }
        public Dictionary<Comand, int> ScoreBoard { get; }
        public Organization(string name)
        {
            Name = name;

            CurrentPLays = new List<Game>();

            Plays = new List<Game> ();
            var Beach = new BeachGame();
            var Fishing = new FishingGame();
            var Mousetrap = new MousetrapGame();
            var Postmen = new PostmenGame();
            var Sea = new SeaGame();
            var Slide = new SlideGame();
            var CockroachRaces = new CockroachRacesGame();
            Plays.AddRange(new Game[] { Beach, Fishing, Mousetrap, Postmen, Sea, Slide, CockroachRaces });

            Comands = new List<Comand>();
            var Russia = new Comand("Россия");
            Russia.AddPlayerInComand(new Player("Александр"), new Player("Дмитрий"), new Player("Максим"), new Player("Сергей"), new Player("Андрей"), 
                new Player("Алексей"), new Player("Артем"), new Player("Илья"), new Player("Кирилл"), new Player("Никита"), new Player("Матвей"), 
                new Player("Егор"), new Player("Анна"), new Player("Мария"), new Player("Елена"));

            var France = new Comand("Франция");
            France.AddPlayerInComand(new Player("Жан"), new Player("Пьер"), new Player("Люк"), new Player("Франсуа"), new Player("Антуан"),
                new Player("Жюльен"), new Player("Николя"), new Player("Оливье"), new Player("Тома"), new Player("Гастон"), new Player("Марсель"),
                new Player("Софи"), new Player("Камилла"), new Player("Элоиза"), new Player("Шарлотта"));

            var China = new Comand("Китай");
            China.AddPlayerInComand(new Player("Вэй"), new Player("Цзин"), new Player("Лэй"), new Player("Хао"), new Player("Цзянь"),
                new Player("Мин"), new Player("Пэн"), new Player("Тао"), new Player("Фэн"), new Player("Юн"), new Player("Бин"),
                new Player("Синь"), new Player("Лянь"), new Player("Юнь"), new Player("Ли"));

            var Kazakhstan = new Comand("Казахстан");
            Kazakhstan.AddPlayerInComand(new Player("Аслан"), new Player("Ерлан"), new Player("Нурлан"), new Player("Тимур"), new Player("Арман"),
                new Player("Асель"), new Player("Азамат"), new Player("Диас"), new Player("Санжар"), new Player("Алибек"), new Player("Ержан"),
                new Player("Рустам"), new Player("Айгуль"), new Player("Динара"), new Player("Мадина"));

            Comands.AddRange(new[] { Russia, France, China, Kazakhstan });

            ScoreBoard = new Dictionary<Comand, int>();
        }

        public void ChoiceGame()
        {
            Console.WriteLine($"Всевозможные игры: ");
            PrintPlays();
            Console.WriteLine();

            Console.WriteLine($"Количество текущих игр - {CurrentPLays.Count}");
            if (CurrentPLays.Count != 0)
            {
                Console.WriteLine("Текущие игры: ");
                foreach(Game game in CurrentPLays)
                {
                    Console.Write(game.Name + "  ");
                }
            }

            while(CurrentPLays.Count < 6)
            {
                Console.Write("Введите название игры для добавления:  ");
                string name = Console.ReadLine();
                bool isFound = false;
                foreach(Game game in Plays)
                {
                    if (game.Name == name && !CurrentPLays.Contains(game))
                    {
                        CurrentPLays.Add(game);
                        Console.WriteLine($"Игра {game.Name} добавлена");
                        isFound = true;
                        break;
                    }
                }
                if(!isFound) { Console.WriteLine("Игра не добавлена (либо не найдена, либо уже добавлена ранее)"); }
            }
        }

        public void StartGames()
        {
            if(CurrentPLays.Count != 6)
            {
                Console.WriteLine($"Текущее количество игр - {CurrentPLays.Count}, а должно быть 6! Сначала выберите 6 игр");
                ChoiceGame();
            }
            if (Comands.Count != 4)
            {
                Console.WriteLine("В игре должно участвовать ровно 4 команды. Сейчас количество иное. Игра не пройдет");
                return;
            }

            foreach(var command in Comands)
            {
                ScoreBoard.Add(command, 0);
            }

            foreach (Game game in CurrentPLays)
            {
                var victory = game.Play(Comands);

                if(victory is not null) { ScoreBoard[victory]++; }
                Console.WriteLine();
            }

            var sortedScoreBoard = ScoreBoard.OrderByDescending(x => x.Value).ToList();
            Console.WriteLine($"По итогам всех игр, победителем стала команда - {sortedScoreBoard[0].Key.Name}");
        }

        public void PrintPlays()
        {
            foreach(Game play in Plays)
            {
                Console.WriteLine($"Название: {play.Name}; описание: {play.Description}");
            }
        }

        public void PrintCommand()
        {
            Console.Write("Введите название команды:  ");
            string name = Console.ReadLine();
            foreach(Comand command in Comands)
            {
                if(command.Name == name)
                {
                    command.PrintOnConsole();
                    return;
                }
            }
            Console.WriteLine("Команда не найдена!");
        }

        public void PrintGame()
        {
            Console.Write("Введите название игры:  ");
            string name = Console.ReadLine();
            foreach (Game game in Plays)
            {
                if (game.Name == name)
                {
                    game.PrintOnConsole();
                    return;
                }
            }
            Console.WriteLine("Игра не найдена!");
        }

        public void PrintOnConsole()
        {
            Console.WriteLine("Наши команды!");
            foreach(Comand comand in Comands)
            {
                Console.WriteLine($"Название: {comand.Name}; количесвто участников: {comand.Players.Count}");
            }
            Console.WriteLine();

            Console.WriteLine("Наши игры!");
            foreach(Game play in Plays)
            {
                Console.WriteLine($"Название: {play.Name}");
            }
            Console.WriteLine();

            Console.WriteLine($"Самый лучший организатор: {Name}");
        }
    }

}
