using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma.Dependency_inversion_principle
{
    public class Discord : IMesaj
    {
        public string KullaniciAdi { get; set; }
        public string Kanal { get; set; }
        public void MesajGonder()
        {
            Console.WriteLine("Discord mesajı gönderildi.");
            Console.WriteLine($"Kullanıcı Adı: {KullaniciAdi}");
            Console.WriteLine($"Kanal: {Kanal}");
        }
    }
}
