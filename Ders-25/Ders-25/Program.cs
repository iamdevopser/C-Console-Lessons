using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_25   // 3x2 matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[3, 3];
            dizi[0, 0] = 34;
            dizi[0, 1] = 22;
            dizi[0, 2] = 47;
            dizi[1, 0] = 12;
            dizi[1, 1] = 10;
            dizi[1, 2] = 30;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)

                    Console.Write(" {0} ", dizi[i, j]);
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
