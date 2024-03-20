using System;
namespace HomeTask_2.NET
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введiть кiлькiсть грошей у Петрика: ");
            decimal s = decimal.Parse(Console.ReadLine());

            Console.Write("Введiть цiну одного зошита: ");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.Write("Введiть цiну одної ручки: ");
            decimal y = decimal.Parse(Console.ReadLine());

            Console.Write("\nВведiть кiлькiсть зошитiв: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введiть кiлькiсть ручок: ");
            int m = int.Parse(Console.ReadLine());

            decimal p = x * n + y * m; /* p - сума покупки */

            if (s >= p)
            {
                Console.Write($"\nПiсля покупки у Петрика залишиться {s - p} гривень.");
            }
            else
            {
                Console.Write("\nПетрику не вистачило грошей.");
            }
        }
    }
}
