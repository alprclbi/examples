//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Çalışma
//{
//    public class KahveSiparisi2
//    {
//        public string Hazirla(string tur, int seker, bool sut)
//        {
//            string kahve = "";
//            if (sut)
//                kahve += "Sütlü ";
//            else
//                kahve += "Sütsüz ";

//            if (seker > 0)
//                kahve += $"{seker} şekerli";
//            else
//                kahve += "şekersiz";
//            return $"{kahve}, {tur} hazır...";
//        }
//        public decimal UcretiHesapla(string tur)
//        {
//            switch (tur)
//            {
//                case "Türk Kahvesi":
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
