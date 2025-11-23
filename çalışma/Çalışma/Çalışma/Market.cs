using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma
{
    public class Market
    {
        //TODO: Kullanici marketten 3 urun secer ve fiyatlarini girer.
        public void FiyatGir()
        {
            string[] urunler = new string[3];
            double[] fiyatlar = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1}. urun adi: ");
                urunler[i] = Console.ReadLine();
                Console.Write($"{i + 1}. urunun fiyati: ");
                fiyatlar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Toplam tutar: {ToplamHesapla(fiyatlar)}");
            Console.WriteLine($"Ortalama tutar: {OrtalamaHesapla(fiyatlar)}");
        }
        //TODO: Toplam hesaplama yapan metod.
        public double ToplamHesapla(double[] fiyatlar)
        {
            double toplam = 0;
            for (int i = 0; i < fiyatlar.Length; i++)
            {
                toplam += fiyatlar[i];
            }
            return toplam;
        }
        //TODO: Ortalama Hesabi yapan metod.
        public double OrtalamaHesapla(double[] fiyatlar)
        {
            double ortalama = 0;
            for (int i = 0; i < fiyatlar.Length; i++)
            {
                ortalama += fiyatlar[i];
            }
            return ortalama /= fiyatlar.Length;
        }
    }
}
