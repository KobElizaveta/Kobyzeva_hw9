namespace hw9_Latypova.Class
{
    public class Player
    {
        public string Name { get; set; } 
        public Guid Id { get; set; } = Guid.NewGuid();

        public Player(string name)
        {
            Name = name;
        }
    }
}
