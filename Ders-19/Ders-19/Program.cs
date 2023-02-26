using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_19   // Decimal uygulamalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal x = 0.996m;
            decimal y = 999999;
            Console.WriteLine("Para 1 {0:C} ", x);
            Console.WriteLine("Para 2 {0:C} ", y);
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.ReadLine();
        }
    }
}
