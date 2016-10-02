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
            int  x ;
            int  y ;
            Console.WriteLine(" Введите X Y");
            Console.WriteLine("Введите X");
             x=int.Parse(Console.ReadLine());
             Console.WriteLine("Введите Y");
             y=int.Parse(Console.ReadLine());

             if (x > 0 & y > 0)
             {
                 Console.WriteLine("Точка находится в 1 четверти ");
             }
             if (x < 0 & y > 0)
             {
                 Console.WriteLine("Точка находится в 2 четверти");
             }
             if (x < 0 & y < 0)
             {
                 Console.WriteLine("Точка находится в 3 четверти");
             }
             if (x > 0 & y < 0)
             {
                 Console.WriteLine("Точка находится в 4 четверти");
             }

             Console.ReadKey();
        }
    }
}
