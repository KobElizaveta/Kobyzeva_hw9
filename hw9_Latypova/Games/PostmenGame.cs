using hw9_Latypova.Class;

namespace hw9_Latypova.Games
{
    public class PostmenGame: Game
    {
        public override string Name
        {
            get { return "Почтальоны"; }
        }
        public override string Description
        {
            get { return " Скоростная доставка «писем» через полосу препятствий"; }
        }
        public override string Rules
        {
            get { return "Игроки в костюмах почтальонов должны пронести хрупкие «посылки» через вращающуюся центрифугу и скользкую горку. Если посылка падает, ее нужно поднять и продолжить путь. Побеждает команда, доставившая больше посылок."; }
        }
    }
}
