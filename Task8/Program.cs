using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double valueA, result =1;
            int valueN;
            Console.Write("Введіть дробове значення A: ");
            while (!double.TryParse(Console.ReadLine(), out valueA) || valueA % 1 == 0)
            {
                Console.WriteLine("Ви повинні ввести дробове число");
                Console.Write("Введіть значення A:");
            }
            Console.Write("Введіть ціле значення степеня N: ");
            while (!int.TryParse(Console.ReadLine(), out valueN) || !(valueN % 1 == 0))
            {
                Console.WriteLine("Ви повинні ввести ціле число");
                Console.Write("Введіть значення степеня N:");
            }
            for (double i = 1; i <= valueN; i++) {
                result *= valueA;
            }
            Console.WriteLine($"Число {valueA} в степені {valueN} = {result}");
        }
    }
}
