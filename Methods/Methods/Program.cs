#region 1.Kısım
//DortIslemPrametreli(4, 2, global::DortIslem.Toplama);
//DortIslemPrametreli(4, 2, global::DortIslem.Çıkarma);
//DortIslemPrametreli(4, 2, global::DortIslem.Çarpma);
//DortIslemPrametreli(4, 2, global::DortIslem.Bölme);

//static void DortIslemPrametreli(double sayi1, double sayi2, DortIslem islemTipi)
//{
//    switch(islemTipi)
//    {
//        case global::DortIslem.Toplama:
//            Console.WriteLine($"Toplama İşleminin sonu: {sayi1 + sayi2}");
//            break;
//        case global::DortIslem.Çıkarma:
//            Console.WriteLine($"Çıkarma İşleminin sonu: {sayi1 - sayi2}");
//            break;
//        case global::DortIslem.Çarpma:
//            Console.WriteLine($"Çarpma İşleminin sonu: {sayi1 * sayi2}");
//            break;
//        case global::DortIslem.Bölme:
//            Console.WriteLine($"Bölme İşleminin sonu: {sayi1 / sayi2}");
//            break;
//    }
//}
#endregion
#region 2.Kısım
//static double DortİslemGeriDonuslu(int sayi1, int sayi2, DortIslem islemTipi)
//{
//    switch (islemTipi)
//    {
//        case DortIslem.Toplama:
//            return sayi1 + sayi2;
//        case DortIslem.Çıkarma:
//            return sayi1 - sayi2;
//        case DortIslem.Çarpma:
//            return sayi1 * sayi2;
//        case DortIslem.Bölme:
//            return sayi1 / sayi2;
//        default:
//            return 0;
//    }
//}
//double sonuc = DortİslemGeriDonuslu(4, 2, DortIslem.Toplama);
//Console.WriteLine($"Toplama işleminin sonucu: {sonuc} ");
//enum DortIslem
//{
//    Toplama,
//    Çıkarma,
//    Çarpma,
//    Bölme,
//}

//using Methods;

//OgrenciIslemleri ogrenci = new OgrenciIslemleri();
//ogrenci.SelamVer();
//ogrenci.SelamVer("Alper");
//Console.WriteLine($"Yaşınız parametresiz: {ogrenci.yasHesapla()}");
//Console.WriteLine($"Yaşınız parametreli: {ogrenci.yasHesapla(1995)}");

#region 1.Ödev
//Console.Write("Lütfen kahve türünü seçin: (1 - Turk Kahvesi, 2 - Latte, 3 - Espresso): ");
//string turu = Console.ReadLine();

//Console.Write("Lutfen seker sayisini girin: ");
//int sekerSayisi= int.Parse(Console.ReadLine());

//Console.Write("Sut ister misiniz (E/H)?: ");
//string sutluMu = Console.ReadLine().ToUpper();
//bool sutVarMi = false;
//if (sutluMu == "E")
//{
//    sutVarMi= true;
//}
//switch(turu)
//{
//    case "1":
//        turu = "Turk Kahvesi";
//        break;
//    case "2":
//        turu = "Latte";
//        break;
//    case "3":
//        turu = "Espresso";
//        break;
//}

//KahveSiparisi kahve = new KahveSiparisi();
//Console.WriteLine($"{kahve.Hazirla(turu, sekerSayisi, sutVarMi)}");
//Console.WriteLine($"Odenecek tutar: {kahve.UcretiHesapla(turu)}");

#endregion
#region 2.Ödev
//Market market = new Market();
//market.FiyatGir();
#endregion
#endregion
#region 3.Kısım
using Methods;
using Methods.oop;

// CONSTRUCTUR - DESTRUCTUR
Araba araba = new Araba("AUDI");


// ENCAPSULATION (KAPSULLEME)
Ogrenci ogrenci = new Ogrenci();
ogrenci.a1 = "AHJGKR2";
ogrenci.a2 = "SDFKTMD";
ogrenci.harcama = 15000;

Console.WriteLine($"ApiKey: {ogrenci.a1}, ApiSecret: {ogrenci.a2}, Maas: {ogrenci.harcama}");

//INHERITANCE



#endregion