using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int valueN;
            double result = 0;
            Console.Write("Введіть додатнє значення N: ");
            while (!int.TryParse(Console.ReadLine(), out valueN) || valueN <=0)
            {
                Console.WriteLine("Ви повинні ввести ціле додатнє число");
                Console.Write("Введіть значення N:");
            }
            for (double i =1; i<=valueN; i++) {
                result += 1 / i;
            }
            Console.WriteLine($"Результат = {result}");
        }
    }
}
