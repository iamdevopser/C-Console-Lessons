using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Ders_44 // Ses dosyasi calistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer ses = new SoundPlayer();
            string path;
            path = "C:\\Users\\C\\Download\\11.mp3"; // Dosya yolu
            ses.SoundLocation = path;
            ses.Play();
            Console.ReadLine();
        }
    }
}
