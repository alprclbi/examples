using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class KahveSiparisi
    {
        public string Hazırla(string kahveTuru, int seker, bool sut)
        {
            string turu = kahveTuru;
            string sutDurumu = sut ? "sütlü" : "sade";
            string sekerMıktarı = (seker == 0) ? "şekersiz" : $"{seker} şekerli";
            return $"{sutDurumu}, {sekerMıktarı} {turu} hazır!";
        }
        public double Hesap(string turu)
        {
            double ucret = 0;
            if (turu == "türk kahvesi")
                ucret = 40;
            else if (turu == "latte")
                ucret = 60;
            else if (turu == "espresso")
                ucret = 50;
            else
                ucret = 0;
            return ucret;

            //SWITCH İLE DAHA AÇIK YONTEM
            //return turu.ToLower() switch
            //{
            //    "türk kahvesi" => 40,
            //    "latte" => 60,
            //    "espresso" => 50,
            //    _ => 0,
            //}

        }
    }
}
