using hw9_Tumakov.Enum;
using hw9_Tumakov.Interface;
using System.Drawing;

namespace hw9_Tumakov.Class
{
    internal class Rectangle: Point, ICanPrintInfo, ICalculateArea
    {
        public float Lenght { get; set; }
        public float Width { get; set; }
        public Rectangle(Color color, Visibility visibility, float[] movement, float lenght, float width) : base(color, visibility, movement)
        {
            Lenght = lenght;
            Width = width;
        }
        public double Area()
        {
            return Width * Lenght;
        }

        public override void PrintOnConsole()
        {
            base.PrintOnConsole();
            Console.WriteLine($"Ширина -{Width}, длина - {Lenght}");
        }
    }
}
