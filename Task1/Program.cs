using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double sideA, sideB, perimeterAB, aeraAB;
            Console.Write("Введіть довжину сторони А: ");
            while (!double.TryParse(Console.ReadLine(), out sideA) || sideA <= 0) {
                Console.WriteLine("Ви повинні ввести число більше за 0");
                Console.Write("Введіть довжину сторони A:");
            }
            Console.Write("Введіть довжину сторони B: ");
            while (!double.TryParse(Console.ReadLine(), out sideB) || sideB <= 0)
            {
                Console.WriteLine("Ви повинні ввести число більше за 0");
                Console.Write("Введіть довжину сторони B:");
            }
            perimeterAB = sideA * 2 + sideB * 2;
            aeraAB = sideA * sideB;
            Console.WriteLine($"Периметр = {perimeterAB} ");
            Console.WriteLine($"Площа = {aeraAB}");
        }
    }
}
