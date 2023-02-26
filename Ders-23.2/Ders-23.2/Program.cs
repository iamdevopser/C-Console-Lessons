using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_23._2    // Konsol title ve arka plan rengi degistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "7 Şubat 2023";
            Console.Clear();

            Console.Write("6 Şubat 2023 , Başın sağolsun Türkiye");

            Console.Read();
        }
    }
}
