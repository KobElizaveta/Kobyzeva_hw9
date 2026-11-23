using hw9_Latypova.Class;

namespace hw9_Latypova.Games
{
    public class CockroachRacesGame: Game
    {
        public override string Name
        {
            get { return "Тараканьи бега"; }
        }
        public override string Description
        {
            get { return "Взрослые люди в огромных костюмах тараканов пытаются пролезть через лабиринт с препятствиями к «съедобному призу»"; }
        }
        public override string Rules
        {
            get { return "Игроки должны преодолеть полосу препятствий, ползком пробраться через узкие туннели и добраться до финиша, не застряв. Побеждает команда, чьи «тараканы» первыми доберутся до финиша."; }
        }
    }
}
