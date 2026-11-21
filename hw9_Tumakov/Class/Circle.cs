using hw9_Tumakov.Enum;
using hw9_Tumakov.Interface;
using System.Drawing;

namespace hw9_Tumakov.Class
{
    internal class Circle: Point, ICanPrintInfo, ICalculateArea
    {
        public float Radius { get; set; }

        public Circle(Color Color, Visibility Visibility, float[] Movement, float radius): base(Color, Visibility, Movement)
        {
            Radius = radius;
        }

        public override void PrintOnConsole()
        {
            base.PrintOnConsole();
            Console.WriteLine($"Радиус - {Radius}");
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
