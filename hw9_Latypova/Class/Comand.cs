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

        public void AddPlayerInComand(params object[] players)
        {
            foreach(object p in players)
            {
                if (p is Player)
                {
                    Players.Add((Player)p);
                }
            }
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
