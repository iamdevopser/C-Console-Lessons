using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_40._2    // out metodu
{
    internal class Program
    {
        // Main class ta tanimlanan degiskenin degeri metodun icinde belirlenir ve
        // metod icindeki fonksiyon uygulanarak tekrar main class a gonderilir

        static void arttir(out int s)
        {
            s = 12;
            s++;
        }
        static void Main(string[] args)
        {
            int a;
            arttir(out a);

            Console.WriteLine(a);
            Console.Read();
        }
    }
}
