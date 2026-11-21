using hw9_Latypova.Interface;

namespace hw9_Latypova.Class
{
    public class Comand: IPrintInfo
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public Comand(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        public bool AddPlayerInComand()
        {
            Console.WriteLine($"Добавление участника в команду {Name}");
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            if (name is not null)
            {
                Player newPlayer = new Player(name);
                Console.WriteLine($"{newPlayer.Name} успешно добавлен в команду {this.Name}");
                return true;
            }
            Console.WriteLine($"{name} НЕ добавлен в команду {this.Name}");
            return false;
        }

        public bool RemovePlayerFromComand()
        {
            Console.WriteLine($"Удаление участника из команды {Name}");

            if (Players.Count == 0)
            {
                Console.WriteLine("Участников в данной команде нет. Удаление невозможно");
                return false;
            }

            Console.Write("Имя: ");
            string name = Console.ReadLine();
            
            foreach(Player player in Players)
            {
                if(name ==  player.Name)
                {
                    Players.Remove(player);
                    Console.WriteLine($"{name} удален из команды {Name}");
                    return true;
                }
            }
            Console.WriteLine("Участник не найден. Удаление НЕ выполнено");
            return false;
        }

        public void PrintOnConsole()
        {
            Console.WriteLine($"Команда: {Name}");
            if (Players.Count > 0)
            {
                Console.WriteLine("Участники:");
                foreach(Player player in  Players)
                {
                    Console.WriteLine($"Имя - {player.Name}, id - {player.Id}");
                }
            }
            else { Console.WriteLine("Участников пока нет"); }
        }
    }
}
