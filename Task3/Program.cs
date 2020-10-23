using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double valueX, valueA,  valueB, valueY;
            Console.Write("Введіть значення x: ");
            while (!double.TryParse(Console.ReadLine(), out valueX))
            {
                Console.WriteLine("Ви повинні ввести число");
                Console.Write("Введіть значення x:");
            }
            Console.Write("Введіть не нульове значення a: ");
            while (!double.TryParse(Console.ReadLine(), out valueA) || valueA == 0)
            {
                Console.WriteLine("Ви повинні ввести число яке не дорівнює 0");
                Console.Write("Введіть значення a:");
            }
            Console.Write("Введіть значення b: ");
            while (!double.TryParse(Console.ReadLine(), out valueB))
            {
                Console.WriteLine("Ви повинні ввести число");
                Console.Write("Введіть значення b:");
            }
            valueY = 2.4 * Math.Abs((valueX * valueX + valueB) / valueA) + (valueA - valueB) * Math.Sin(valueA - valueB) * Math.Sin(valueA - valueB) + Math.Pow(10, -2) * (valueX - valueB);
            Console.WriteLine($"y = {valueY}");
        }
    }
}
