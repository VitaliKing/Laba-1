using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите число ");
            a = double.Parse(Console.ReadLine());

            if (a % 1 == 0)
            {
                Console.WriteLine("Ваше число является целым");
            }
            else
            {
                Console.WriteLine("Ваше число не является целым");
            }
           
            Console.ReadKey();
        }
    }
}
