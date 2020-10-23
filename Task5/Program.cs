using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int numberOfDay;
            Console.Write("Введіть число дня тижня: ");
            while (!int.TryParse(Console.ReadLine(), out numberOfDay))
            {
                Console.WriteLine("Ви повинні ввести число");
                Console.Write("Введіть число дня тижня:");
            }
            switch(numberOfDay)
            {
                case 1:
                    Console.WriteLine("1 - понеілок");
                    break;
                case 2:
                    Console.WriteLine("2 - вівторок");
                    break;
                case 3:
                    Console.WriteLine("3 - середа");
                    break;
                case 4:
                    Console.WriteLine("4 - четверг");
                    break;
                case 5:
                    Console.WriteLine("5 - п'ятниця");
                    break;
                case 6:
                    Console.WriteLine("6 - субота");
                    break;
                case 7:
                    Console.WriteLine("7 - неділя");
                    break;
                default:
                    Console.WriteLine("Ви ввели недопустиме значення дня тижня");
                    break;
            }
        }
    }
}
