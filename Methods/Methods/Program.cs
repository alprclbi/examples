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
#region 2. Kısım
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
#endregion

using Methods;

OgrenciIslemleri ogrenci = new OgrenciIslemleri();
ogrenci.SelamVer();
ogrenci.SelamVer("Alper");
Console.WriteLine($"Yaşınız parametresiz: {ogrenci.yasHesapla()}");
Console.WriteLine($"Yaşınız parametreli: {ogrenci.yasHesapla(1995)}");
