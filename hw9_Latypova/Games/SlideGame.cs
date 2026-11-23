using hw9_Latypova.Class;

namespace hw9_Latypova.Games
{
    public class SlideGame: Game
    {
        public override string Name
        {
            get { return "Горка"; }
        }
        public override string Description
        {
            get { return "Задача игры - подняться на гору быстрее всех"; }
        }
        public override string Rules
        {
            get { return "Участники должны подняться на вершину крутой горки, используя только силу рук и специальные шесты. Запрещено помогать себе ногами или локтями. Побеждает команда, которая первой доберется до вершины и водрузит флаг.\r\n"; }
        }
    }
}
