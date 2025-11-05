using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma.Dependency_inversion_principle
{
    public class Whatsapp: IMesaj
    {
        public string TelefonNumarasi { get; set; }
        public string Icerik { get; set; }
        public void MesajGonder()
        {
            Console.WriteLine("Whatsapp mesajı gönderildi.");
            Console.WriteLine($"Telefon Numarası: {TelefonNumarasi}");
            Console.WriteLine($"İçerik: {Icerik}");
        }
    }
}
