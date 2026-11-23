using hw9_Latypova.Class;

namespace hw9_Latypova.Games
{
    public class BeachGame: Game
    {
        public override string Name
        {
            get { return "Пляж"; }
        }
        public override string Description
        {
            get { return "Классическое ипсытание на песке с элементами воды и скольжения"; }
        }
        public override string Rules
        {
            get { return "Участники должны пересечь песчаную арену, не упав в бассейн с пеной, и добраться до финиша быстрее соперников. Главное правило — не толкать других игроков"; }
        }
    }
}
