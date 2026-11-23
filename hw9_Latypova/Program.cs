using hw9_Latypova.Class;

namespace hw9_Latypova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Большие Гонки!!!");
            Organization OlivieGaniyan = new Organization("Оливье Ганьян");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Выберите дейсвтие");
                Console.WriteLine("1 - Вывод всех игр, 2 - Вывод полной информации, 3 - Выбор игр, 4 - Запуск игры,\n\t" +
                    "5 - Вывод информации о команде, 6 - Вывод информации о игре, 7 - Выход");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        OlivieGaniyan.PrintPlays();
                        break;
                    case "2":
                        OlivieGaniyan.PrintOnConsole();
                        break;
                    case "3":
                        OlivieGaniyan.ChoiceGame();
                        break;
                    case "4":
                        OlivieGaniyan.StartGames();
                        break;
                    case "5":
                        OlivieGaniyan.PrintCommand();
                        break;
                    case "6":
                        OlivieGaniyan.PrintGame();
                        break;
                    case "7":
                        Console.WriteLine("До скорых встреч!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
            
        }
    }
}
