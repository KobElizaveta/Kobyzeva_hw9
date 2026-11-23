using hw9_Latypova.Class;

namespace hw9_Latypova.Games
{
    public class MousetrapGame: Game
    {
        public override string Name
        {
            get { return "Мышеловка"; }
        }
        public override string Description
        {
            get { return "Гонка в гигантских костюмах мышей за кусочком сыра"; }
        }
        public override string Rules
        {
            get { return "Игроки в костюмах мышей должны преодолеть полосу препятствий, взять «сыр» из центра арены и принести его в свою нору. Побеждает команда, которая принесет больше «сыра» за отведенное время."; }
        }
    }
}
