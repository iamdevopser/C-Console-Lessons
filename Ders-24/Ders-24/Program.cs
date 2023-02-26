using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_24   // 2x2 matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[2, 2];
            dizi[0, 0] = 34;
            dizi[0, 1] = 22;
            dizi[1, 0] = 47;
            dizi[1, 1] = 10;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)

                    Console.Write(" {0} ", dizi[i, j]);
                Console.WriteLine();

            }

            Console.Read();
        }
    }
}
