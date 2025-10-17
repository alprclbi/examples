using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.oop
{
    public class Araba
    {
        //YAPICI METOD (Constuctor)
        public Araba(string marka)
        {
            Console.WriteLine($"Yapıcı metod çalıştı. Araç {marka}");
        }
        //YIKICI METOD (Desturctor)
        ~Araba()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Yıkıcı metod (finalizer) çalıştı!");
            Console.ResetColor();
        }
    }
}
