using hw9_Tumakov.Class;

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

        static void TaskHW()
        {
            Console.WriteLine("Домашнее задание 10.1");
        }
        static void Main(string[] args)
        {
            TaskEx();
            TaskHW();
        }
    }
}
