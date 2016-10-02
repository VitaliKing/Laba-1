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
            int a, b, c, d;
            Console.WriteLine("Введите координаты вектора A : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты вектора B : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты вектора C : ");
            c = int.Parse(Console.ReadLine());

            d=(a*a)+(b*b)+(c*c);

            Console.WriteLine("Длина вектора состовляет: "+d);

            Console.ReadKey();
        }
    }
}
