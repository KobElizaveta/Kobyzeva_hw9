using hw9_Latypova.Class;

namespace hw9_Latypova.Games
{
    public class SeaGame: Game
    {
        public override string Name
        {
            get { return "Море"; }
        }
        public override string Description
        {
            get { return "Испытание на выносливость и равновесие на плавучей платформе"; }
        }
        public override string Rules
        {
            get { return "Командам нужно перебраться по качающимся плотам и скользким мостикам над водой, чтобы собрать флаги. Упавшие в воду выбывают из раунда. Побеждает команда, собравшая больше флагов"; }
        }
    }
}
