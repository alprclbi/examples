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
        public string turu;
        public int sekerSayisi;
        public bool sutluMu;
        public string Hazirla(string tur, int seker, bool sut)
        {
            turu = tur;
            sekerSayisi = seker;
            sutluMu = sut;

            string sutTercihi = sutluMu ? "Sütlü" : "Sade";
            string sekerMiktarı = (sekerSayisi == 0) ? "Şekersiz" : $"{sekerSayisi} şekerli";
            string turIsmı = string.IsNullOrWhiteSpace(turu) ? "Kahve" : turu;
            return $"{sutTercihi}, {sekerMiktarı} {turIsmı} hazır";
        }
        public double UcretiHesapla(string tur)
        {
            double ucret = 0;
            string turKucuk = tur.ToLower();
            if (tur == "türk")
                ucret = 40;
            else if (tur == "latte")
                ucret = 60;
            else if (tur == "espresso")
                ucret = 50;
            else
                ucret = 0;
            return ucret;
        }
    }
}
