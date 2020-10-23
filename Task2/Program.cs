using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double m, n, z1, z2;
            Console.Write("Введіть додатнє значення m: ");
            while (!double.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.WriteLine("Ви повинні ввести число яке більше 0");
                Console.Write("Введіть значення m:");
            }
            Console.Write("Введіть не від'ємне значення n: ");
            while (!double.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Ви повинні ввести не від'ємне число");
                Console.Write("Введіть значення n:");
            }
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3)*n) + n * m + m * m - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"Z1 = {z1}");
            Console.WriteLine($"Z2 = {z2}");
        }
    }
}
