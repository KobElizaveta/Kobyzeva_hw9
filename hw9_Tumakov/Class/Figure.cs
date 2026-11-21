using hw9_Tumakov.Enum;
using System.Drawing;
using hw9_Tumakov.Interface;

namespace hw9_Tumakov.Class
{
    public abstract class Figure: ICanPrintInfo
    {
        public Color Color { get; set; }
        public Visibility Visibility { get; set; }
        public float[] Movement { get; set; }

        public Figure(Color color,  Visibility visibility,  float[] movement)
        {
            Color = color;
            Visibility = visibility;
            Movement = movement;
        }

        public void MovementOX(float movement)
        {
            Movement[0] += movement;
        }

        public void MovementOY(float movement)
        {
            Movement[1] += movement;
        }

        public bool ChangeColor(object newColor)
        {
            if(newColor is Color)
            {
                Color = (Color)newColor;
                return true;
            }
            return false;
        }
        public void StatusInquiry()
        {
            Console.Write("Какое состояние фигуры? (видимый - Visible, невидимый - Invisible):  ");
            bool isParseStatus = Visibility.TryParse(Console.ReadLine(), out Visibility status);
            if (isParseStatus)
            {
                if(status is Visibility.Visible) { Visibility = Visibility.Visible; }
                else { Visibility = Visibility.Invisible; }
                Console.Write("Изменения внесены.");
            }
            else { Console.Write("Изменения НЕ внесены."); }
            Console.WriteLine($"Текущее состояние - {Visibility.ToString()}");
        }

        public virtual void PrintOnConsole()
        {
            Console.WriteLine($"Тип фигуры - {GetType().Name}, цвет - {Color}, видимость - {Visibility.ToString()}, координаты ({Movement[0]}, {Movement[1]})");
        }
    }
}
