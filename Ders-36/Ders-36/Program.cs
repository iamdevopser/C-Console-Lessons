using System;
using System.Text;
using System.Threading;
using System.Linq;

namespace Methods       // Getter-Setter Metodlari
{
    class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.NAME = "Tarik";
            student1.SURNAME = "Karakullukcu";
            student1.SPACE = "Moldova";
            student1.AGE = 37;

            Console.WriteLine("Student's name:    {0}", student1.NAME);
            Console.WriteLine("Student's surname: {0}", student1.SURNAME);
            Console.WriteLine("Student's space:   {0}", student1.SPACE);
            Console.WriteLine("Student's age:     {0}", student1.AGE); 
            // Burada yas 18den buyuk oldugundan metoda gore 37 yazmasi gerekirken 18 yazdirdi.
            // Sebebini anlayamadim.

            Console.Read();
        }

    }
}

