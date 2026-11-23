using hw9_Latypova.Class;

namespace hw9_Latypova.Games
{
    public class FishingGame: Game
    {
        public override string Name
        {
            get { return "Рыбалка"; }
        }
        public override string Description
        {
            get { return "Эстафета с гигантскими удочками и «рыбой»"; }
        }
        public override string Rules
        {
            get { return "Участники с помощью огромных удочек должны выловить как можно больше надувных рыб из «озера» (бассейна) и перенести их в ведро своей команды. Побеждает команда с самым большим уловом.\r\n"; }
        }
    }
}
