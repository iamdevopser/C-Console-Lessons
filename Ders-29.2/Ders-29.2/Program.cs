using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_29._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //YILDIZLARLA TERS DIK UCGEN SEKLI CIZME

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
