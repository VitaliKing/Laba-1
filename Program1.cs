using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, c1, c2;
            Console.WriteLine("Введите число:");
            a = int.Parse(Console.ReadLine());

            c1 = a / 10;
            c2 = a % 10;
            if (c1 > c2)

                Console.WriteLine("Значение {0} больше {1}", c1, c2);
            else
                Console.WriteLine("Значение {0} больше {1} ", c2, c1);

            Console.ReadKey();
        }
    }
}
