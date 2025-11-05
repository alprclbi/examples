using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma.Dependency_inversion_principle
{
    public class Email : IMesaj
    {
        public string EmailAdresi { get; set; }
        public string Konu { get; set; }
        public void MesajGonder()
        {
            Console.WriteLine("Email gönderildi.");
            Console.WriteLine($"Mail adresi: {EmailAdresi}");
            Console.WriteLine($"Konu: {Konu}");
        }

    }
}
