using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, v;
            Console.WriteLine("Введите x :");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y :");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите z :");
            z = int.Parse(Console.ReadLine());

            v = x * x + y * y + z * z;
            Console.WriteLine("Длина вектора: {0}", v);


            Console.ReadKey();
        }
    }
}
