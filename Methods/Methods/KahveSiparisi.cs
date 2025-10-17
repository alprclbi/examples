//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Metods
//{
//    public class KahveSiparisi
//    {
//        public string Hazirla(string tur, int seker, bool sut)
//        {
//            string kahve = "";
//            if (sut)
//            {
//                kahve += "Sutlu ";
//            }
//            else
//            {
//                kahve += "Sutsuz ";
//            }
//            if (seker > 0)
//            {
//                kahve += $"{seker} sekerli";
//            }
//            else
//            {
//                kahve += "sekersiz";
//            }
//            return $"{kahve} {tur} hazir !!!";
//        }
//        public decimal UcretiHesapla(string tur)
//        {
//            switch (tur)
//            {
//                case "Turk Kahvesi":
//                    return 40;
//                case "Latte":
//                    return 60;
//                case "Espresso":
//                    return 50;
//            }
//            return 0;
//        }
//    }
//}