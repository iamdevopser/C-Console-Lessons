using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_39 // Virtual - Override Metodlari
{
    class Insan
    {
        public virtual void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Ornek Subat 2023";
            Console.WriteLine("Gecmis olsun Turkiye");

        }
    }

    class Turk : Insan
    {
        public override void selamver()
        // selamver sinifinin icindekileri degil de turk sinifinin
        // icindekileri yaziyor
        {
            Console.WriteLine("Esenlikler");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Turk turk = new Turk();
            turk.selamver();
            Console.Read();
        }

    }
}
