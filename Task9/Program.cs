using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int valueN;
            ulong result =1, factorial =1;
            Console.Write("Введіть ціле додатнє значення N: ");
            while (!int.TryParse(Console.ReadLine(), out valueN) || !(valueN % 1 == 0) || valueN <=0)
            {
                Console.WriteLine("Ви повинні ввести ціле додатнє число");
                Console.Write("Введіть значення N:");
            }
            for (int i =1; i<=valueN ;i++) {
                factorial *= (ulong)(i);
                result += factorial;
            }
            Console.WriteLine($"Результат = {result-1}");
        }
    }
}
