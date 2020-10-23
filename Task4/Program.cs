using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double valueA, valueB, valueC, x1, x2, x, D;
            Console.Write("Введіть значення a: ");
            while (!double.TryParse(Console.ReadLine(), out valueA))
            {
                Console.WriteLine("Ви повинні ввести число");
                Console.Write("Введіть значення A:");
            }
            Console.Write("Введіть значення B: ");
            while (!double.TryParse(Console.ReadLine(), out valueB))
            {
                Console.WriteLine("Ви повинні ввести число");
                Console.Write("Введіть значення B:");
            }
            Console.Write("Введіть значення C: ");
            while (!double.TryParse(Console.ReadLine(), out valueC))
            {
                Console.WriteLine("Ви повинні ввести число");
                Console.Write("Введіть значення C:");
            }
            D = valueB * valueB - 4 * valueA * valueC;
            Console.WriteLine($"Дискримінант = {D}");
            if (D > 0)
            {
                x1 = (-valueB + Math.Sqrt(D)) / 2 * valueA;
                x2 = (-valueB - Math.Sqrt(D)) / 2 * valueA;
                Console.WriteLine($"X1 = {x1}");
                Console.WriteLine($"X2 = {x2}");
            }
            else {
                if (D == 0)
                {
                    x = -valueB / 2 * valueA;
                    Console.WriteLine($"X = {x}");
                }
                else
                    Console.WriteLine("Коренів немає");
            }
        }
    }
}
