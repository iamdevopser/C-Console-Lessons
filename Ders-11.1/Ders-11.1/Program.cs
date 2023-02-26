using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-8 arasi sayilarin fibonacci serisi icerisinde yazdirilimi 
            int a = 1;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 1; i <= 8; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
