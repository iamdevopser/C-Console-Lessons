using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_38 // Getter-Setter : Ucus bilgileri uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucak uck = new Ucak();

            uck.MARKA = "THY";
            uck.KALKIS = "Izmir";
            uck.VARIS = "IStanbul";
            uck.AD = "Tarik";
            uck.SOYAD = "Karakullukcu";
            uck.YAS = -37;
            uck.CINSIYET = "Bay";

            Console.WriteLine("Semt: " + uck.MARKA);
            Console.WriteLine("Oda Rengi: " + uck.KALKIS);
            Console.WriteLine("Oda Sayisi: " + uck.VARIS);
            Console.WriteLine("Kat No: " + uck.AD);
            Console.WriteLine("Toplam Alan: " + uck.SOYAD);
            Console.WriteLine("Toplam Alan: " + uck.YAS);
            Console.WriteLine("Toplam Alan: " + uck.CINSIYET);
            Console.Read();
        }
    }
}
