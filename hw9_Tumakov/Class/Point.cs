using hw9_Tumakov.Enum;
using System.Drawing;
using hw9_Tumakov.Interface;

namespace hw9_Tumakov.Class
{
    internal class Point: Figure, ICanPrintInfo, ICalculateArea
    {
        public Point(Color Color, Visibility Visibility, float[] Movement) : base(Color, Visibility, Movement) { }

        public double Area()
        {
            Console.WriteLine("Невозможно расчитать площадь для данной фигуры");
            return 0;
        }
    }
}
