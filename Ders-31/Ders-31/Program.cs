using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BAKLAVA DILIMI CIZME

            Console.Write("Baklava dilim sayisini giriniz: ");
            int deger;
            deger = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= deger; i++)
            {
                for (int x = deger; x > i; x--)
                {
                    Console.Write(" ");
                }
                for (int y = 1; y <= i; y++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            for (int k = 1; k <= deger; k++)
            {
                for (int m = 1; m <= k; m++)
                {
                    Console.Write(" ");
                }
                for (int n = deger; n > k; n--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
