using Çalışma;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma
{
    public class Soru
    {
        public string Metin { get; set; }
        public string[] Secenekler { get; set; }
        public char DogruCevap { get; set; }
        public static void SoruOlustur()
        {
            Soru soru1 = new Soru
            {
                Metin = "Türkiye'nin başkenti neresidir?",
                Secenekler = [ "A) İstanbul", "B) Ankara", "C) İzmir", "D) Bursa" ],
                DogruCevap = 'B'
            };
            Soru soru2 = new Soru
            {
                Metin = "Dünyanın en büyük okyanusu hangisidir?",
                Secenekler = [ "A) Atlantik Okyanusu", "B) Hint Okyanusu", "C) Arktik Okyanusu", "D) Pasifik Okyanusu" ],
                DogruCevap = 'D'
            };

            Soru soru3 = new Soru
            {
                Metin = "Hangi elementin kimyasal sembolü 'O' dur?",
                Secenekler = [ "A) Altın", "B) Oksijen", "C) Gümüş", "D) Hidrojen" ],
                DogruCevap = 'B'
            };
            Soru soru4 = new Soru
            {
                Metin = "Hangi gezegen Güneş'e en yakın olandır?",
                Secenekler = ["A) Venüs", "B) Mars", "C) Merkür", "D) Dünya" ],
                DogruCevap = 'C'
            };
            Soru soru5 = new Soru
            {
                Metin = "Hangi yıl Birleşmiş Milletler (BM) kuruldu?",
                Secenekler = [ "A) 1945", "B) 1918", "C) 1939", "D) 1950" ],
                DogruCevap = 'A'
            };

            Soru[] sorular = { soru1, soru2, soru3, soru4, soru5, };

            int puan = 0;
            foreach (var soru in sorular)
            {
            SoruTekrarla:
                Console.WriteLine($"\n{soru.Metin}");

                foreach (var secenek in soru.Secenekler)
                {
                    Console.WriteLine(secenek);
                }
                Console.Write("Cevabınızı girin (A, B, C, D): ");
                string kullaniciCevabi = Console.ReadLine().ToUpper();
                char cevap = kullaniciCevabi[0];

                
                if (cevap == soru.DogruCevap)
                {
                    puan += 10;
                    Console.WriteLine($"Doğru! Toplam puanınız: {puan}");
                }
                else if (cevap != 'A' & cevap != 'B' & cevap != 'C' & cevap != 'D')
                {
                    Console.WriteLine("\nGeçersiz cevap. Lütfen A, B, C veya D seçeneklerinden birini girin.");
                    goto SoruTekrarla;
                }
                else
                {
                    Console.WriteLine($"Yanlış cevap verdiniz. Oyun Bitti!!\r\nToplam puanınız: {puan}");
                    return;
                }
            }
            Console.WriteLine("\nTEBRİKLER YARIŞMAYI TAMAMLADINIZ");
        }
    }
}