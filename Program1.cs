using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Ввведите число :");
            a = int.Parse(Console.ReadLine());

            b = a / 10;
            c = a % 10;
            if (c == b)
            {
                Console.WriteLine(c + " Ни равны " + b);
            }
            else if (b > c)
            {
                Console.WriteLine(b + " Больше " + c);
            }
            else
                Console.WriteLine(c + " Больше " + b);
            Console.ReadKey();
        }
    }
}
