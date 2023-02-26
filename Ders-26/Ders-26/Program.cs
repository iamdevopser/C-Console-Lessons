using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_26   // iki matrix in toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrixlerde Toplama");

            int[,] dizi1 = { {32,44,52,13}, {26,87,54,27},
                             {20,10,55,35}, {19,46,32,78}};
            int[,] dizi2 = { {13,67,38,90}, {41,39,73,24},
                             {34,55,60,12}, {89,52,70,91}};

            int[,] toplam = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    toplam[i, j] = dizi1[i, j] + dizi2[i, j];
                }
            }

            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine();
                for (int m = 0; m < 4; m++)
                {
                    Console.Write(toplam[k, m] + " ");
                }
            }
            Console.Read();
        }
    }
}
