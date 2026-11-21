using hw9_Tumakov.Class;
using hw9_Tumakov.Enum;
using System.Drawing;

namespace hw9_Tumakov
{
    internal class Program
    {
        static void TaskEx()
        {
            Console.WriteLine("Упражнение 10.1");

            List<string> tests = new List<string> { "Abracadabra", "Zebra", "I like 10 watermelons!" };

            Console.WriteLine("Проверка функционала класса ACipher");
            foreach(string test in tests)
            {
                Console.Write($"Вход: {test}");
                ACipher line = new ACipher(test);
                string encodeLine = line.encode();
                Console.Write($"  Кодировка: {encodeLine}");
                ACipher encodedLine = new ACipher(encodeLine);
                Console.WriteLine($"  Декодировка (закодированного слова): {encodedLine.dencode().ToString()}");
            }

            Console.WriteLine("Проверка функционала класса BCipher");
            foreach (string test in tests)
            {
                Console.Write($"Вход: {test}");
                BCipher line = new BCipher(test);
                string encodeLine = line.encode();
                Console.Write($"  Кодировка: {encodeLine}");
                BCipher encodedLine = new BCipher(encodeLine);
                Console.WriteLine($"  Декодировка (закодированного слова): {encodedLine.dencode().ToString()}");
            }
        }

        static object AddFigure()
        {
            Console.WriteLine("Добавление фигуры");
            bool flagAdd = true;
            while(flagAdd)
            {
                Console.Write("Тип фигуры ( Прямоугольник, Точка, Круг ):  ");
                string typeFigure = Console.ReadLine();
                Console.Write("Цвет ( Red, Blue, Green, White, Black ):  ");
                string strColor = Console.ReadLine();
                Console.Write($"Прозрачность ( Visible, Invisible ): ");
                bool isParseVisibility = Visibility.TryParse(Console.ReadLine(), out Visibility visibility);
                Console.Write("Координаты x: ");
                bool isParseX = float.TryParse(Console.ReadLine(), out float movementX);
                Console.Write("Координаты y: ");
                bool isParseY = float.TryParse(Console.ReadLine(), out float movementY);

                if (isParseX && isParseY && isParseVisibility && new[] { "Прямоугольник", "Точка", "Круг" }.Contains(typeFigure) && new[] { "Red", "Blue", "Green", "White", "Black" }.Contains(strColor))
                {
                    if (typeFigure == "Прямоугольник")
                    {
                        Console.Write("Ширина:  ");
                        bool isParseWidth = float.TryParse(Console.ReadLine(), out float width);
                        Console.Write("Длина:  ");
                        bool isParseLenght = float.TryParse(Console.ReadLine(), out float lenght);
                        if (isParseWidth && isParseLenght)
                        {
                            return new Class.Rectangle(Color.FromName(strColor), visibility, [movementX, movementY], lenght, width);
                        }
                    }
                    else if (typeFigure == "Точка")
                    {
                        return new Class.Point(Color.FromName(strColor), visibility, [movementX, movementY]);
                    }
                    else if (typeFigure == "Круг")
                    {
                        Console.Write("Радиус:  ");
                        bool isParseRadius = float.TryParse(Console.ReadLine(), out float radius);
                        if (isParseRadius)
                        {
                            return new Circle(Color.FromName(strColor), visibility, [movementX, movementY], radius); ;
                        }
                    }
                }
                Console.WriteLine("Неверно введены данные. Фигура не добавлена. Попробуйте заново");
            }
            return null;
        }

        static void ActionWithFigure()
        {
            var figure = AddFigure();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Дейсвтия: 1 - Расчет Площадь, 2 - Вывести информацию, 3 - Поменять цвет, 4 - Изменить статус видимости,\n\t5 - Сдвинуть по оси OX, 6 - Сдвинуть по оси OY, 7 - Изменить фигуру, 8 - Выйти");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        figure.Area();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                }
            }
        }
        static void TaskHW()
        {
            Console.WriteLine("Домашнее задание 10.1");
            ActionWithFigure();
        }
        static void Main(string[] args)
        {
            TaskEx();
            TaskHW();
            //Продумать это нечто с типами данных при добавлении фигуры, дописать метод ActionWithFigure
        }
    }
}
