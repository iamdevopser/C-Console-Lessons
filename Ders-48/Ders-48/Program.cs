using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ders_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter dosya = new StreamWriter(@"C:\Users\C\Desktop\Belgem.txt");
            string veri;
            Console.WriteLine("Buraya notunuzu yaziniz: ");
            veri = Console.ReadLine();
            dosya.WriteLine(veri);
            dosya.Close();
        }
    }
}
