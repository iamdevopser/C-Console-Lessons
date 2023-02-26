using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_34   // Metod - obje iliskisi kurarak toplama islemi yapma
{
    internal class Program
    {
        class Metodlar
        {
            int topla(int a, int b)// method
            {
                return a + b;
            }

            static void Main(string[] args)
            {
                Metodlar mtr = new Metodlar();
                int z;
                z = mtr.topla(1, 3);
                Console.WriteLine("Toplam: " + z);
                Console.Read();
            }

        }
    }
}
