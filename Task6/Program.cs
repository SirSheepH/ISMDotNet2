using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int valueA, valueB, resultAB = 1, path =0;

            Console.Write("Введіть значення A: ");
            while (!int.TryParse(Console.ReadLine(), out valueA) || !(valueA % 1 ==0))
            {
                Console.WriteLine("Ви повинні ввести ціле число");
                Console.Write("Введіть значення A:");
            }
            Console.Write("Введіть значення B: ");
            while (!int.TryParse(Console.ReadLine(), out valueB) || valueB<valueA || !(valueB % 1 == 0))
            {
                Console.WriteLine("Ви повинні ввести ціле число яке більше за A");
                Console.Write("Введіть значення B:");
            }
            for (int i = valueA ; path< 1 + (valueB - valueA); i++) {
                resultAB *= i;
                path++;
            }
           Console.WriteLine($"Результат = {resultAB}");
        }
    }
}
