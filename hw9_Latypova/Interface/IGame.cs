using hw9_Latypova.Class;

namespace hw9_Latypova.Interface
{
    internal interface IGame
    {
        string Name { get; }
        string Description { get; }
        string Rules { get; }
        Comand? Play(List<Comand> commands);
    }
}
