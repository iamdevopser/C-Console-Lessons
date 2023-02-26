using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //YILDIZLARLA ICI BOS SEKLI CIZME

            Console.Write("Kenar sayisini giriniz: ");
            int kare;
            kare = Convert.ToInt16(Console.ReadLine());

            // ust kenar
            for (int i = 0; i < kare; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            //sol kenar
            for (int j = 0; j < kare - 2; j++)
            {
                Console.Write("*");
                for (int k = 0; k < kare - 2; k++)
                {
                    Console.Write("  ");
                }
                Console.Write(" *");
                Console.WriteLine();

            }
            // alt kenar
            for (int n = 0; n < kare; n++)
            {
                Console.Write("* ");
            }
            Console.Read();
        }
    }
}
