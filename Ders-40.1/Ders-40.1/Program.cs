using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_40._1 // Ref metodu
{
    //Main class ta verilen degiskenin degerini metodla referanslayip degerini degistirmeye yarar **
    class Program
    {
        static void arttir(ref int s)
        {
            s++;
        }
        static void Main(string[] args)
        {
            int a = 10;
            arttir(ref a);

            Console.WriteLine(a);
            Console.Read();
        }
    }
}
}
