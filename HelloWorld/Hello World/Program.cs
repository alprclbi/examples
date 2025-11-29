#region 1. Ders
#region TEMEL ÖRNEKLER
//Console.WriteLine("Hello World :)");
//Console.WriteLine("Alper Çelebi");
//Console.WriteLine("Yas: 30");
//Console.WriteLine("21.09.2025");

// yazdığım console komutlarını yan yana yazmak için Console.Write kullanmam lazım!!

//Console.Write("Alper"+" ");
//Console.Write("Çelebi");

//Console.Write("Lütfen Adınızı Ve Soyadınızı Giriniz: ");
//Console.WriteLine("Ekrana Girilen Değer: " + Console.ReadLine());
#endregion

#region DEĞİŞKENLER
//string ad = "Alper";
//string soyad = "Çelebi";
//Console.WriteLine(ad + " " + soyad);

#region STRING VERİ TİPİ ÖRNEK
//Console.Write("Lütfen Adınızı Giriniz: ");
//String ad = Console.ReadLine();

//Console.Write("Lütfen Soyadınızı Giriniz: ");
//String soyad = Console.ReadLine();

//Console.Write("Lütfen Yaşınızı Giriniz: ");
//String yas = Console.ReadLine();
//Console.WriteLine("Adınız: " + ad + ", " + "Soyadınız: " + soyad + ", " + "Yaş: " + yas);
#endregion
#endregion

#region 1. DERS ÖDEVİ
// TC kimlik kartında olan verileri ekrana işleyen bir konsol uygulaması yazılacak

//console.foregroundcolor = consolecolor.blue;
//console.writeline("soyadı/surname");
//console.resetcolor();
//string soyadı = console.readline();

//console.foregroundcolor = consolecolor.blue;
//console.writeline("\nadı/given name(s)");
//console.resetcolor();
//string adı = console.readline();

//console.foregroundcolor = consolecolor.blue;
//console.writeline("\ndoğum tarihi/date of birth");
//console.resetcolor();
//string dogumtarıhı = console.readline();

//console.foregroundcolor = consolecolor.blue;
//console.writeline("\ncinsiyeti/gender");
//console.resetcolor();
//string cınsıyet = console.readline();

//console.foregroundcolor = consolecolor.blue;
//console.writeline("\nanne adı/mother's name");
//console.resetcolor();
//string anneadı = console.readline();

//console.foregroundcolor = consolecolor.blue;
//console.writeline("\nbaba adı/father's name");
//console.resetcolor();
//string babaadı = console.readline();

//Console.ForegroundColor = ConsoleColor.Blue;
//Console.WriteLine("\nSoyadı" + "  " + "Adı" + "    " + "Dogum Tarihi" + "  " + "Cinsiyeti" + "  " + "Anne Adı" + "  " + "Baba Adı");
//Console.ResetColor();
//Console.WriteLine(soyadı + "  " + adı + "   " + dogumtarıhı + "    " + cınsıyet + "      " + anneadı + "     " + babaadı);

// CHATGPT GÖRSEL YARDIM ALINMIŞ HALİ

//Console.ForegroundColor = ConsoleColor.Blue;
//Console.WriteLine("\n+---------------+---------------+--------------------+---------------+---------------+---------------+");
//Console.WriteLine("| {0,-13} | {1,-13} | {2,-18} | {3,-13} | {4,-13} | {5,-13} |",
//    "Soyadı", "Adı", "Doğum Tarihi", "Cinsiyeti", "Anne Adı", "Baba Adı");
//Console.WriteLine("+---------------+---------------+--------------------+---------------+---------------+---------------+");
//Console.ResetColor();

//Console.WriteLine("| {0,-13} | {1,-13} | {2,-18} | {3,-13} | {4,-13} | {5,-13} |",
//    soyadı, adı, dogumtarıhı, cınsıyet, anneadı, babaadı);
//Console.WriteLine("+---------------+---------------+--------------------+---------------+---------------+---------------+");

#endregion
#endregion

#region 2. Ders
#region 2.Ders 1. Kısım
//int sayı1 = 25;
//int sayı2 = 5;
//Console.WriteLine("İki Sayının Toplamı: " + (sayı1 + sayı2));
//Console.WriteLine($"İki sayının toplamı: {sayı1 + sayı2}");

#region Toplama İşlemi
//int toplama = sayı1 + sayı2;
#endregion

#region Çıkarma İşlemi
// int çıkarma = sayı1 - sayı2;
#endregion

#region Bölme İşlemi
//int bölme = sayı1 / sayı2;
#endregion

#region Çarpma İşlemi
//int carpma = sayı1 * sayı2;
#endregion

//Console.WriteLine($"İki Sayının toplamı: {toplama}.");
//Console.WriteLine($"İki Sayının çıkarması: {çıkarma}.");
//Console.WriteLine($"İki Sayının bölümü: {bölme}.");
//Console.WriteLine($"İki Sayının çarpımı: {carpma}.");
#endregion


#region 2.Ders 2. Kısım

//Console.Write("Adınızı Giriniz: ");
//string ad = Console.ReadLine();
//Console.Write("Lütfen yaşınızı giriniz: ");
//int yas = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Merhaba {ad}. girmiş olduğunuz Yaş: {yas}");

//int sayi1 = 10;
//int sayı2 = 20;

//bool sonuc = sayi1 > sayı2;
//bool sonuc2 = sayi1 < sayı2;
//bool sonuc3 = sayi1 == sayı2;
//bool sonuc4 = sayi1 != sayı2;

//Console.WriteLine($"Sonuç: {sonuc}");
//Console.WriteLine($"Sonuç2: {sonuc2}");
//Console.WriteLine($"Sonuç3: {sonuc3}");
//Console.WriteLine($"Sonuç4: {sonuc4}");

// TODO:Ekrandan doğum tarihi isteyeceğim. Girilen değere göre yaş hesaplayıp ekrana yazdıracağım.

//Console.Write("Lütfen doğum tarihinizi giriniz: ");

//int dogumTarihi = int.Parse(Console.ReadLine());
//int hesaplananYasDegeri = DateTime.Now.Year - dogumTarihi;

//Console.WriteLine($"Yaşınız: {hesaplananYasDegeri}");

//Console.Write("Lütfen adınızı giriniz: ");
//string ad = Console.ReadLine();

//Console.Write("Lütfen maasşınızı giriniz: ");
//decimal maas = decimal.Parse(Console.ReadLine());

//decimal yevmiye = maas / 30;

//Console.WriteLine($"Merhaba {ad}. Senin günlük kazancın: {yevmiye}");

// TODO: Not ortalaması gösteren uygulama

//Console.Write("Lütfen notunuzu giriniz: ");

//int not = int.Parse(Console.ReadLine());
//int gecmeNotu = 45;
//bool sonuc = not >= gecmeNotu;

//Console.WriteLine($"Ders sonucu: {sonuc}");

// TODO: İndirimli ürün hesaplama programı
//decimal urunFiyati = 159.90m;
//decimal indirimOrani = 0.10m;

//decimal indirimMiktari = urunFiyati * indirimOrani;
//decimal indirimliFiyat = urunFiyati - indirimMiktari;

//Console.WriteLine($"Ürünün indirimli fiyatı: {indirimliFiyat} TL");

//TODO: Vize ve Final Not ortalaması uygulama

//Console.Write("Vize notu: ");
//int vizeNotu = int.Parse(Console.ReadLine());

//Console.Write("Final notu: ");
//int finalNotu = int.Parse(Console.ReadLine());

//double vizeOrtalama = 0.4;
//double finalOrtalama = 0.6;
//double not = (vizeNotu * vizeOrtalama) + (finalNotu * finalOrtalama);

//int gecmeNotu = 60;

//if (not >= gecmeNotu)
//{
//    Console.WriteLine($"Tebrikler !!! Dersi geçtiniz. Notunuz {not}");
//}
//else
//{
//    Console.WriteLine($"Üzgünüm !!!!! Dersi geçemediniz. Notunuz {not}");
//}

#endregion

#region 2. Ders Ödevi
// ÖDEV 1 - En az 5 farklı veri tipinden (string,int,double,decimal,bool) değişken tanımlayın ve ekrana yazdırın
// Adınızı,yaşınızı boyunuzu ve yaşadığınız şehri değişkenlerde saklayıp ekrana yazdıran program
// ÖDEV 2 - Kullanıcıdan alınan dakika bilgisini saat ve dakika formatına çeviren bir program yazınız (Örn: 135 dakika --> 2 saat 15 dakika)
// ÖDEV 3 - Kullanıcıdan sıcaklık değeri alınız ve bunu fahrenheit'a çevirip ekrana yazdıran program

// TODO: 1. ÖDEV

//Console.Write("Lütfen adınızı yazınız: ");
//string ad = Console.ReadLine();

//Console.Write("Lütfen yaşınızı yazınız: ");
//int yas = int.Parse(Console.ReadLine());

//Console.Write("Lütfen boyunuzu yazınız: ");
//double boy = double.Parse(Console.ReadLine());

//Console.Write("Lütfen kilonuzu yazın: ");
//double kilo = double.Parse(Console.ReadLine());

//Console.Write("Lütfen aylık kazancınızı yazınız: ");
//decimal maas = decimal.Parse(Console.ReadLine());

//decimal maasOrtalaması = 30000;
//bool sonuc = maas > maasOrtalaması;

//Console.WriteLine($"\nAdınız: {ad} - Yaşınız: {yas} - Boyunuz: {boy} - Kilonuz: {kilo} - Aylık Kazancınız: {maas} - {sonuc}");

//TODO 2.ÖDEV

//Console.Write("Eylül ayında kaç dakika ekran başında kaldınız: ");
//int dakika = int.Parse(Console.ReadLine());

//int saat = dakika / 60;
//int kalanDakika = dakika - (saat * 60);

//Console.WriteLine($"Toplamda {saat} saat {kalanDakika} dakika boyunca ekran başındaydınız.");

//if (dakika > 7500)
//{
//    Console.WriteLine("Ekran başında çok fazla vakit geçiriyorsunuz. Lütfen dikkat ediniz!!!");
//}
//else
//{
//    Console.WriteLine("Ekran başında geçirdiğiniz vakit normal seviyede.");
//}

//TODO 3.ÖDEV
//Console.Write("Lütfen Ankara'da bugünkü hava durumu sıcaklığını söyleyiniz: ");
//int derece = int.Parse(Console.ReadLine());

//double fahrenheit = (derece * 9 / 5) + 32;
//Console.WriteLine($"Ankarada bugün sıcaklık {fahrenheit} fahrenheit'tır.");
#endregion
#endregion

#region 3. Ders

#region 3. Ders 1. Kısım
//Console.Write("Lütfen adınızı giriniz: ");
//string ad = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(ad))
//{
//    Console.WriteLine("Ekrana girilen değer boş, lütfen programı tekrar çalıştırınız.");
//}
//else
//{
//    Console.WriteLine($"Ekrana girilen değer: {ad}");
//}
#endregion

#region 3. Ders 2. Kısım

//Baslangiç:
//Console.Clear();
//Console.WriteLine("====MENÜ====)");
//Console.WriteLine("1- Ekrana 'Merhaba Dünya !' Yazdır");
//Console.WriteLine("2- Ekrana rastgele bir sayı Yazdır");
//Console.WriteLine("3- Çıkış");
//Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
//string secim = Console.ReadLine();

//if (secim == "1")
//{
//    Console.WriteLine("Merhaba Dünya !");
//    Console.WriteLine("Ana menüye dönmek için bir tuşa basınız...");
//    Console.ReadKey();
//    goto Baslangiç;
//}
//else if (secim == "2")
//{
//    var rnd = new Random();
//    Console.WriteLine($"Programda üretilen rastgele sayı: {rnd.Next(1, 100)}");
//    Console.WriteLine("Ana menüye dönmek için bir tuşa basınız...");
//    Console.ReadKey();
//    goto Baslangiç;
//}
//else if (secim == "3")
//{
//    Console.Write("Çıkış yapılıyor...");
//    Thread.Sleep(5000);
//    Environment.Exit(0);
//}
//else
//{
//    Console.WriteLine("Geçersiz bir seçim yaptınız. Devam etmek için bir tuşa basınız.");
//    Console.ReadKey();
//    goto Baslangiç;
//}

#endregion

#region 3. Ders 3. Kısım
//Baslangiç:
//Console.Clear();
//Console.WriteLine("====ÇELEBİ KEBAP SALONU====");
//Console.WriteLine("======HOŞGELDİNİZ======");
//Console.WriteLine("1- Adana Kebap - 300 TL");
//Console.WriteLine("2- Urfa Kebap - 275 TL");
//Console.WriteLine("3- Beyti Kebap - 375 TL");
//Console.WriteLine("4- Tavuk kanat - 250 TL");
//Console.WriteLine("5- Tavuk Şiş - 275 TL");
//Console.WriteLine("6- Lahmacun - 100 TL");

//Console.Write("\nTekrar Hoşgeldiniz. Lütfen yemek seçimi yapınız: ");
//string menuSecim = Console.ReadLine();

//switch (menuSecim)
//{
//    case "1":
//        Console.WriteLine("Adana Kebap seçtiniz. Fiyat: 300 TL");
//        break;
//    case "2":
//        Console.WriteLine("Urfa Kebap seçtiniz. Fiyat: 275 TL");
//        break;
//    case "3":
//        Console.WriteLine("Beyti Kebap seçtiniz. Fiyat: 375 TL");
//        break;
//    case "4":
//        Console.WriteLine("Tavuk Kanat seçtiniz. Fiyat: 250 TL");
//        break;
//    case "5":
//        Console.WriteLine("Tavuk Şiş Kebap seçtiniz. Fiyat: 275 TL");
//        break;
//    case "6":
//        Console.WriteLine("Lahmacun seçtiniz. Fyat: 100 TL");
//        break;
//    default:
//        Console.WriteLine("Geçersiz seçim yaptınız.");
//        break;
//}
//if (menuSecim == "1" || menuSecim == "2" || menuSecim == "3" || menuSecim == "4" || menuSecim == "5" || menuSecim == "6")
//{
//    Console.Write("Yemek siparişiniz hazırlanıyor, lütfen bekleyiniz...");
//    Thread.Sleep(5000);
//    Console.WriteLine("\nYemek siparişiniz hazır. Afiyet olsun :)");
//    Environment.Exit(0);
//}

//Console.WriteLine("Lütfen menüye dönmek için herhangi bir tuşa basınız.");
//Console.ReadKey();
//goto Baslangiç;

#endregion

#region 3. Ders 4.Kısım

//string ogrenciBilgisi, harfNotu = " ";
//double vizeNotu, finalNotu, puan;
//double vizeOrtalamasi = 0.4;
//double finalOrtalamasi = 0.6;

////TODO: Öğrenci bilgisi iste

//Baslangiç:
//Console.Clear();
//Console.WriteLine("====ÇELEBİ ÜNİVERSİTESİ ÖĞRENCİ İŞLERİNE HOŞGELDİNİZ====");
//Console.Write("Lütfen öğrenci adını ve soyadını giriniz: ");
//ogrenciBilgisi = Console.ReadLine();

////TODO: hocaya not girişi ile ilgili soru sor (E/H)

//Notgirisi:
//Console.Write($"\nMerhaba {ogrenciBilgisi} adlı öğrenci için ders seçimi yapmak istiyor musunuz? (E/H): ");
//string dersSecim = Console.ReadLine();
//dersSecim = dersSecim.ToUpper();

//switch (dersSecim)
//{
//    case "E":
//        //TODO: hocaya ders listesi gönder

//        Console.WriteLine("\n====DERS SEÇİMİ====");
//        Console.WriteLine("1- Matematik");
//        Console.WriteLine("2- Fizik");
//        Console.WriteLine("3- Kimya");
//        Console.WriteLine("4- Biyoloji");
//        Console.WriteLine("5- Tarih");
//        Console.WriteLine("====DERS SEÇİMİ====");
//        Console.Write("Lütfen ders seçiminizi yapınız: ");
//        string dersDegeri = Console.ReadLine();


//        //TODO: hocaya vize ve final notu sor

//        Console.WriteLine("------------ NOT GİRİŞİ ------------");
//        Console.Write("Lütfen vize notunu giriniz: ");
//        vizeNotu = double.Parse(Console.ReadLine()) * vizeOrtalamasi;
//        Console.Write("Lütfen final notunu giriniz: ");
//        finalNotu = double.Parse(Console.ReadLine()) * finalOrtalamasi;
//        puan = vizeNotu + finalNotu;
//        Console.WriteLine("------------ NOT GİRİŞİ ------------");

//        // TODO çıkan puana göre harf notu belirle

//        if (puan > 0 && puan <= 49)
//            harfNotu = "FF";
//        else if (puan >= 50 && puan <= 59)
//            harfNotu = "DD";
//        else if (puan >= 60 && puan <= 64)
//            harfNotu = "DC";
//        else if (puan >= 65 && puan <= 74)
//            harfNotu = "CC";
//        else if (puan >= 75 && puan <= 79)
//            harfNotu = "CB";
//        else if (puan >= 80 && puan <= 84)
//            harfNotu = "BB";
//        else if (puan >= 85 && puan <= 89)
//            harfNotu = "BA";
//        else if (puan >= 90 && puan <= 100)
//            harfNotu = "AA";

//        Console.WriteLine($"Seçim yapılan dersten aldığınız not: {harfNotu}");
//        Console.WriteLine("Başka bir öğrencinin not girişi yapmak için bir tuşa basınız:...");
//        Console.ReadKey();
//        goto Baslangiç;
//    case "H":
//        goto Notgirisi;
//    default:
//        goto Notgirisi;
//}


#endregion

#region 3. Ders 1. Ödev
//TODO: 1.ÖDEV - kullanıcıdan bir sayı isteyip, bu sayının tek mi çift mi ve pozitif mi negatif mi olduğunu ekrana yazdıran program

//Baslangic:
//Console.Clear();
//Console.Write("Lütfen ekrana bir sayı giriniz: ");
//int sayi = int.Parse(Console.ReadLine());

//if (sayi % 2 == 0)
//{
//    Console.WriteLine($"Girmiş olduğunuz sayı '{sayi}' çift bir sayıdır.");
//    Console.WriteLine("Devam etmek için bir tuşa basınız...");
//    Console.ReadKey();
//}
//else if (sayi % 2 != 0)
//{
//    Console.WriteLine($"Girmiş olduğunuz sayı '{sayi}' tek bir sayıdır.");
//    Console.WriteLine("Devam etmek için bir tuşa basınız...");
//    Console.ReadKey();
//}
//else
//{
//    Console.WriteLine("\nEkrana girilen '0' sayısı çift sayıdır.");
//    Console.WriteLine("Tekrar sayı girmek için bir tuşa basınız...");
//    Console.ReadKey();
//    goto Baslangic;
//}

//if (sayi > 0)
//{
//    Console.WriteLine($"\nGirmiş olduğunuz sayı '{sayi}' pozitif bir sayıdır.");
//    Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//    Console.ReadKey();
//    goto Baslangic;

//}
//else if (sayi < 0)
//{
//    Console.WriteLine($"\nGirmiş olduğunuz sayı '{sayi}' negatif bir sayıdır.");
//    Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//    Console.ReadKey();
//    goto Baslangic;

//}
//else
//{
//    Console.WriteLine("\nEkrana girilen '0' sayısı ne pozitif ne negatif bir sayıdır.");
//    Console.WriteLine("Tekrar sayı girmek için bir tuşa basınız...");
//    Console.ReadKey();
//    goto Baslangic;
//}
#endregion

#region 3. Ders 2. Ödev
//TODO: Kullanıcından iki sayı iste ve (+ - * /) işlemlerinden birini seçmesini sağla. Seçilen işleme göre sonucu ekrana yazdır.

//Baslangıc:
//Console.Clear();
//Console.Write("Lütfen birinci sayıyı giriniz: ");
//double sayi1 = double.Parse(Console.ReadLine());

//Console.Write("Lütfen ikinci sayıyı giriniz: ");
//double sayi2 = double.Parse(Console.ReadLine());

//Console.Write("\nLütfen yapmak istediğiniz işlemi seçiniz: ");
//string islem = Console.ReadLine();

//switch (islem)
//{
//    case "+":
//        Console.WriteLine($"\nİşlem sonucu: {sayi1 + sayi2}");
//        Console.WriteLine("Tekrar işlem yapmak için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangıc;
//        break;
//    case "-":
//        Console.WriteLine($"\nİşlem sonucu: {sayi1 - sayi2}");
//        Console.WriteLine("Tekrar işlem yapmak için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangıc;
//        break;
//    case "*":
//        Console.WriteLine($"\nİşlem sonucu: {sayi1 * sayi2}");
//        Console.WriteLine("Tekrar işlem yapmak için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangıc;
//        break;

//    case "/":
//        if (sayi2 == 0)
//        {
//            Console.WriteLine("\nBir sayı 0'a bölünemez. Lütfen tekrar deneyiniz...");
//            Console.WriteLine("Tekrar işlem yapmak için bir tuşa basınız...");
//            Console.ReadKey();
//            goto Baslangıc;
//        }
//        Console.WriteLine($"\nİşlem sonucu: {sayi1 / sayi2}");
//        Console.WriteLine("Tekrar işlem yapmak için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangıc;
//        break;
//}


#endregion

#region 3. Ders 3. Ödev
////TODO: Kullanıcıdan 1-7 arasında bir sayı iste

//Baslangic:
//Console.Clear();
//Console.Write("Lütfen 1-7 arasında bir sayı giriniz: ");
//int sayi = int.Parse(Console.ReadLine());

////TODO: Girilen sayıya göre haftanın gününü ekrana yazdır

//switch (sayi)
//{
//    case 1:
//        Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı  Pazartesi gününe denk gelmektedir.");
//        Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangic;
//        break;
//    case 2:
//        Console.WriteLine($"\nGirmiş olduğunuz {sayi} sayısı  SALI gününe denk gelmektedir.");
//        Console.WriteLine("\nTekrar bir sayı girmek için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangic;
//        break;
//    case 3:
//        Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı  Çarşamba gününe denk gelmektedir.");
//        Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangic;
//        break;
//    case 4:
//        Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı  Perşembe gününe denk gelmektedir.");
//        Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangic;
//        break;
//    case 5:
//        Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı  Cuma gününe denk gelmektedir.");
//        Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangic;
//        break;
//    case 6:
//        Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı  Cumartesi gününe denk gelmektedir.");
//        Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangic;
//        break;
//    case 7:
//        Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı  Pazar gününe denk gelmektedir.");
//        Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangic;
//        break;
//    default:
//        Console.WriteLine("Ekrana 1-7 arasında bir sayı girmediniz. Lütfen tekrar deneyiniz...");
//        Console.WriteLine("Tekrar bir sayı girmek için bir tuşa basınız...");
//        Console.ReadKey();
//        goto Baslangic;
//        break;
//}
#endregion
#endregion

#region 4. Ders

#region 4. Ders 1. Kısım

//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine($"Dizinin birinci elemanı: {sayilar[0].ToString()}");


//int[] dizi = new int[5];
//dizi[0] = 1;
//dizi[1] = 2;
//dizi[2] = 3;
//dizi[3] = 4;
//dizi[4] = 5;

//Console.WriteLine($"Bu dizi toplam {dizi.Length} elemanlıdır");


//Console.Write("1. Sayıyı giriniz: ");
//string sayi1 = Console.ReadLine();

//Console.Write("2. Sayıyı giriniz: ");
//string sayi2 = Console.ReadLine();

//if (int.TryParse(sayi1, out int number1) && int.TryParse(sayi2, out int number2))
//{
//    Console.WriteLine($"Bu iki sayının toplamı: {number1 + number2}");
//}
//else
//{
//    Console.WriteLine("İstenilen format doğru değil. Lütfen tekrar deneyiniz.");
//}
#endregion

#region 4. Ders 2. Kısım (Döngüler)

//string[] ogrenciler = { "Alper", "Sevde", "Hilal" };

//for (int i = 0; i < ogrenciler.Length; i++)
//{
//    Console.WriteLine(ogrenciler[i]);
//}

//

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Döngüdeki sıra: {i}");
//}


//string[] ogrenciler = { "Alper", "Sevde", "Hilal", "Onur" };
//for (int i = 0; i < ogrenciler.Length; i++)
//{
//    if (ogrenciler[i] == "Alper")
//    {
//        Console.WriteLine($"Dizideki {i} eleman '{ogrenciler[i]}' değeridir.");
//        break;
//    }
//    else continue;
//}


//for (int i = 5; i >= 0; i--)
//{
//    Console.WriteLine(i.ToString());
//}

//string isim =  "SEVDE";
//for (int i = 0; i < isim.Length; i++)
//{
//    Console.WriteLine(isim[i]);
//}

//Console.WriteLine("Lütfen bir metin giriniz: ");
//string girdi = Console.ReadLine();
//girdi = girdi.ToLower();
//string[] parcala = girdi.Split(' ');

//Console.WriteLine("Hangi harf ya da kelime saydırmak istiyorsunuz?: ");
//string karakter = Console.ReadLine();
//karakter = karakter.ToLower();

//int sayac = 0;
//for (int i = 0; i < parcala.Length; i++)
//{
//    if (parcala[i].ToString().Contains(karakter))
//    {
//        sayac++;
//    }
//}
//Console.WriteLine($"{karakter} harf ya da kelime içeren kayıt sayısı: {sayac}");

#endregion

#region 4. Ders 3. Kısım

//string[] dizi = { "Prison Break", "Game Of Thrones", "Breaking Bad", "La Casa de Papel", "Dark" };
//foreach (string item in dizi)
//{
//    Console.WriteLine(item);
//}

//string isim = "ALPER";
//foreach (char item in isim)
//{
//    Console.WriteLine(item);
//}

//double[] sayilar = { 55.2, 77.4, 83.12, 55, 12.4 };
//double sonuc = 0;
//foreach (double item in sayilar)
//{
//    sonuc += item;
//}
//Console.WriteLine($"Dizideki bütün elemanların toplamı: {sonuc}");

//string metin = "Merhaba C#";
//int karaktersayisi = 0;
//foreach (var item in metin)
//{
//    if (item != ' ') { karaktersayisi++;}
//}
//Console.WriteLine($"Metindeki karakter sayısı: {karaktersayisi}");


//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//foreach (int item in sayilar)
//{
//    if (item % 2 == 0)
//    {
//        Console.WriteLine($"{item} bir çift sayıdır.");
//    }
//    else
//    {
//        Console.WriteLine($"{item} bir tek sayıdır.");
//    }
//}

//string[] dersler = { "Matematik", "Fizik", "Coğrafya", "Edebiyat", "Geometri", "Tarih" };
//int[] puanlar = { 70, 65, 80, 70, 90, 20 };

//for (int i = 0; i < dersler.Length; i++)
//{
//    Console.WriteLine($"{dersler[i]} dersinden {puanlar[i]} puan aldın !!!");
//}
#endregion

#region 4. Ders 1. Ödevi

//Baslangic:
//Console.Clear();
//var rnd = new Random();
//int sayi = rnd.Next(1, 50);

//Console.WriteLine("Bilgisayar 1-50 arasında bir sayı üretecek senden bu sayıyı tahmin etmeni istiyorum.");
//Console.WriteLine("Sayıyı tahmin etmek için 5 tahmin hakkın var. Hazırsan başlayalım !!!");
//Console.Write("\nLütfen tahmininizi giriniz?: ");
//int tahmin = int.Parse(Console.ReadLine());

//int hak = 5;

//for (int i = 0; i < 5; i++)
//{
//    hak--;
//    if (tahmin < 0 || tahmin > 50)
//    {
//        Console.WriteLine($"Girdiğiniz sayı 1-50 arasında değildir lütfen tekrar deneyiniz. Kalan hakkınız {hak} !!!");
//        if (hak == 0)
//        {
//            Console.WriteLine("\nÜZGÜNÜM TAHMİN HAKKIN BİTTİ :(");
//            Console.WriteLine($"Bilgisayarın ürettiği sayı: {sayi}");
//            break;
//        }

//        Console.Write("\nLütfen tahmininizi giriniz?: ");
//        tahmin = int.Parse(Console.ReadLine());
//    }
//    else if (tahmin < sayi)
//    {
//        Console.WriteLine($"Daha büyük bir sayı giriniz. Kalan hakkınız {hak} !!!");
//        if (hak == 0)
//        {
//            Console.WriteLine("\nÜZGÜNÜM TAHMİN HAKKIN BİTTİ :(");
//            Console.Write($"Bilgisayarın ürettiği sayı: {sayi}");
//            break;
//        }
//        Console.Write("\nLütfen tahmininizi giriniz?: ");
//        tahmin = int.Parse(Console.ReadLine());
//    }
//    else if (tahmin > sayi)
//    {
//        Console.WriteLine($"Daha küçük bir sayı giriniz. Kalan hakkınız {hak} !!!");
//        if (hak == 0)
//        {
//            Console.WriteLine("\nÜZGÜNÜM TAHMİN HAKKIN BİTTİ :(");
//            Console.Write($"Bilgisayarın ürettiği sayı: {sayi}");
//            break;
//        }
//        Console.Write("\nLütfen tahmininizi giriniz?: ");
//        tahmin = int.Parse(Console.ReadLine());
//    }
//    else if (tahmin == sayi)
//    {
//        Console.WriteLine("\nTEBRİKLERRRRR !!! Doğru tahmin ettin :)");
//        Console.Write("Tekrar oynamak ister misin? (E/H): ");
//        string cevap = Console.ReadLine().ToUpper();
//        if (cevap == "E")
//            goto Baslangic;
//        else
//            break;
//    }
//    if (hak == 0)
//    {
//        Console.WriteLine("\nÜZGÜNÜM TAHMİN HAKKIN BİTTİ :(");
//        Console.Write($"Bilgisayarın ürettiği sayı: {sayi}");
//        break;
//    }
//}
#endregion

#region 4. Ders 2. Ödevi

//string[] kavanoz = { "Kırmızı Şeker", "Kırmızı Şeker", "Yeşil Şeker", "Kırmızı Şeker", "Mavi Şeker", "Sarı Şeker", "Kırmızı Şeker" };
//int sayac = 0;
//foreach (string item in kavanoz)
//{
//    if (item == "Kırmızı Şeker") sayac++;
//}
//Console.WriteLine($"Kavanoz içerisinde {sayac} adet Kırmızı Şeker vardır.");
#endregion

#region 4.Ders 3. Ödevi
////TODO: 3 öğrenci ve notları var for döngüüsü ile puan ortalamasını bulunuz.
//string[] ogrenciler = { "Alper", "Hilal", "Sevde" };
//double[] notlar = { 80, 70, 90, 60, 100, 75, 95, 85, 100};

//for (int i = 0; i < ogrenciler.Length; i++)
//{
//    double toplam = 0;
//    for (int j = 0; j < notlar.Length / ogrenciler.Length; j++)
//    {
//        toplam += notlar[i * (notlar.Length / ogrenciler.Length) + j];
//    }
//    Console.WriteLine($"{ogrenciler[i]} adlı öğrencinin not ortalaması: {toplam / (notlar.Length / ogrenciler.Length)}");
//}

////TODO: Foreach döngüsü ile notlar arasındaki en yüksek notu bulalım.
//double enYuksekNot = double.MinValue;
//foreach (double item in notlar)
//{
//    if (item > enYuksekNot)
//    {
//        enYuksekNot = item;
//    }
//}
//Console.WriteLine($"\nNotlar arasındaki en yüksek not: {enYuksekNot}");

#endregion

#region 4. Ders 4. Ödevi

//Console.Write("Lütfen bir kelime giriniz: ");
//string kelime = Console.ReadLine();
//kelime = kelime.ToLower();
//int sayac = 0;

//foreach (char harf in kelime)
//{
//    if (harf == 'a') sayac++;
//}
//Console.WriteLine($"Girdiğiniz kelimede {sayac} adet 'a' harfi bulunmaktadır.");

//foreach (char harf in kelime)
//{
//    Console.WriteLine(harf);
//}
#endregion
#endregion

#region 5.Ders (Tekrar)
#region 1.Ödev

//TODO: 1. Bilgisayarr 1-50 arasında rastgele bir sayı üretir.
Random random = new Random();
int gizliSayi = random.Next(1, 51);

Console.WriteLine("1 ile 50 arasında bir sayı tuttum. 5 tahmin hakkın var");
//TODO: 2. Kullanıcıya 5 tahmin hakkı verirlir
for (int hak = 1; hak <= 5; hak++)
{
    Console.Write("Tahmini giriniz: ");
    int tahmin = int.Parse(Console.ReadLine());

    if (tahmin == gizliSayi)
    {
        Console.WriteLine("Tebrikler !!!!! Sayıyı doğu bildiniz");
        break;
    }

    if (hak == 5)
    {
        Console.WriteLine("Hakkınız bitti");
        break;
    }
     else if (tahmin < gizliSayi)
    {
        Console.WriteLine("Daha büyük bir sayı dene !");
    }
    else
    {
        Console.WriteLine("Daha küçük bir sayı dene !");
    }
}

//TODO: 3. Tahmin hakkı bitince yapılacak işlemle
Console.WriteLine($"\nTahmin hakkın bitti !! :( Doğru sayı {gizliSayi}");
#endregion

#region  2.Ödev
////TODO: 1. Şeker dizisi tanımla
//string[] sekerler = { "Kırmızı Şeker", "Mavi Şeker", "Yeşil Şeker", "Kırmızı Şeker", "Sarı Şeker" };
//int kirmiziSekerSayisi = 0;
////TODO: 2. foreach döngüsü ile kavanozdaki şekerleri dolaş
//foreach (string seker in sekerler)
//{
//    if (seker == "Kırmızı Şeker")
//    {
//        kirmiziSekerSayisi++;
//    }
//}
////TODO 3. SOnucu ekrana yazdır
//Console.WriteLine($"Kavanozda {kirmiziSekerSayisi} tane Kırmızı Şeker var.");
#endregion

#region 3.Ödev
////TODO: 1. Öğrrenciler dizisi oluştur
//int[,] notlar = {
//    { 70,80,90}, //--> Öğrenci 1
//    { 60,100,75}, // --> Öğrenci 2
//    { 95,85,100}, // --> Öğrenci 3
//};
////TODO:2. for ile öğrencilerrin ortalaması hesapla
//for (int i = 0; i < 3; i++)
//{
//    int toplam = 0;
//    for (int j = 0; j < 3; j++)
//    {
//        toplam += notlar[i, j];
//    }
//    Console.WriteLine($"Öğrenci {i + 1} Ortalaması: {toplam / 3}");
//}
////TODO:3. Foreach ile enyüksek notu bul
//int enYüksekNot = 0;
//foreach (int not in notlar)
//{
//    if (not > enYüksekNot)
//    {
//        enYüksekNot = not;
//    }
//}
//Console.WriteLine($"En Yüksek not: {enYüksekNot}");
#endregion

#region 5. Ders 1. Kısım (Metodlar)
//METODLARR (Fonksiyonlar)
//Selamver();
//MerhabaOgrenci("Alper");
//Hesapla(10, 5, "çarpma");

//static void Selamver()
//{
//    Console.WriteLine("Merhaba C# öğrenmeye devam ediyorum :)");
//}

//static void MerhabaOgrenci(string ogrenciAdi)
//{
//    Console.WriteLine($"Merhaba öğrenci {ogrenciAdi}");
//}

//static void Hesapla(int sayi1, int sayi2, string islem)
//{
//    switch (islem)
//    {
//        case "toplama":
//            Console.WriteLine($"Toplama İşleminin sonucu: {sayi1 + sayi2}");
//            break;
//        case "çıkartma":
//            Console.WriteLine($"Çıkartma İşleminin sonucu: {sayi1 - sayi2}");
//            break;
//        case "çarpma":
//            Console.WriteLine($"Çarpma İşleminin sonucu: {sayi1 * sayi2}");
//            break;
//        case "bölme":
//            Console.WriteLine($"Bölme İşleminin sonucu: {sayi1 / sayi2}");
//            break;
//        default:
//            Console.WriteLine("Geçersiz işlem");
//            break;
//    }
//    Selamver();
//}

#endregion
#endregion

Console.WriteLine("test");