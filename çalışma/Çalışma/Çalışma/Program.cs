#region 1. TEKRAR

#region TEMEL ÇALIŞMA
//Console.WriteLine("Hello World");

//Console.Write("I wıll be developer");

//Console.Write("How old are you?: ");
//String old = Console.ReadLine();
//Console.Write("You are " + old + " years old");

#endregion

#region KİMLİK KARTI ÇALIŞMA
//static void WriteLineRed(string text)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(text);
//    Console.ResetColor();
//}

//WriteLineRed("SOYADI");
//String soyad = Console.ReadLine();

//WriteLineRed("ADI");
//String ad = Console.ReadLine();

//WriteLineRed("DOGUM TARIHI");
//String dogumtarıhı = Console.ReadLine();

//WriteLineRed("ANNE ADI");
//String anneadı = Console.ReadLine();

//WriteLineRed("BABA ADI");
//String babaadı = Console.ReadLine();

//WriteLineRed("\nSOYADI    ADI   DOGUM TARIHI   ANNE ADI    BABA ADI");
//Console.Write(soyad + "   " + ad + "   " + dogumtarıhı + "     " + anneadı + "       " + babaadı);

#endregion

#region TEKRAR KIMLIK KARTI ÇALIŞMA

//Console.WriteLine("SOYADINIZ");
//String soyad = Console.ReadLine();

//Console.WriteLine("ADINIZ");
//String ad = Console.ReadLine();

//Console.WriteLine("DOGUM TARIHI");
//String dogumtarıhı = Console.ReadLine();

//Console.WriteLine("ANNE ADI");
//String anneadı = Console.ReadLine();

//Console.WriteLine("BABA ADI");
//String babaadı = Console.ReadLine();

//Console.WriteLine("\nSOYADINIZ" + "   " + "ADINIZ" + "   " + "DOGUM TARIHINIZ" + "   " + "ANNE ADINIZ" + "   " + "BABA ADINIZ");
//Console.WriteLine(soyad + "      " + ad + "      " + dogumtarıhı + "         " + anneadı + "           " + babaadı);
#endregion

#region KARAR YAPILARI

//Console.WriteLine("Yaşınızı Giriniz: ");
//int yas = Convert.ToInt32(Console.ReadLine());

//if (yas >= 18)
//    Console.WriteLine("Ehliyet Alabilirsin");
//else
//    Console.WriteLine("Yaşın Küçük");

#endregion
#endregion

#region 2. TEKRAR
//Console.WriteLine("Hello World! :)");
//Console.WriteLine("I am Alper, I wıll be developer");
////
//string ad = "Alper";
//string soyad = "Çelebi";
//int yaş = 30;
//Console.WriteLine(ad + " " + soyad + " " + yaş);
////
//Console.Write("Hangi Kursa Gidiyorsun?: ");
//string kurs = Console.ReadLine();
//
//int sayi = 50;
//int sayi1 = 2;
//int toplama = sayi + sayi1;
//int çıkarma = sayi - sayi1;
//int çarpma = sayi * sayi1;
//int bölme = sayi / sayi1;

//Console.WriteLine($"İki Sayının Toplamı: {toplama}");
//Console.WriteLine($"İki Sayının Çıkarma: {çıkarma}");
//Console.WriteLine($"İki Sayının Çarpımı: {çarpma}");
//Console.WriteLine($"İki Sayının Bölümü: {bölme}");

//

//Console.Write("Önce 1. sayıyı sonra 2. sayıyı giriniz: ");
//int sayi2 = int.Parse(Console.ReadLine()), sayi3 = int.Parse(Console.ReadLine());

//Console.Write("Bu sayılara hangi işlemi uygulayalım? (+, -, *, /)?: ");
//string işlem = Console.ReadLine();

//if (işlem == "+")
//    Console.WriteLine($"İki Sayının Toplamı: {sayi2 + sayi3}");
//else if (işlem == "-")
//    Console.WriteLine($"İki Sayının Farkı: {sayi2 - sayi3}");
//else if (işlem == "*")
//    Console.WriteLine($"İki Sayının Çarpımı: {sayi2 * sayi3}");
//else if (işlem == "/")
//    Console.WriteLine($"İki Sayının Bölümü: {sayi2 / sayi3}");
//else
//    Console.WriteLine("Geçersiz İşlem");

//

//Console.Write("Lütfen doğum tarihinizi giriniz: ");
//int dogumTarihi = int.Parse(Console.ReadLine());
//int yaş = DateTime.Now.Year - dogumTarihi;
//Console.WriteLine($"Yaşınız: {yaş}");

//if (yaş < 18)
//    Console.WriteLine("Ehliyet Alamazsın, DEFOL");
//else if (yaş == 18)
//    Console.WriteLine("Ehliyet alabilirsin");
//else
//    Console.WriteLine("HALA EHLİYET ALMADIN MI????");

//

//int sayi4 = 10;
//int sayi5 = 20;

//bool sonuc = sayi4 > sayi5;
//bool sonuc1 = sayi4 != sayi5;
//Console.WriteLine(sonuc);
//Console.WriteLine(sonuc1);

//

//Console.Write("Ürünün fiyatını giriniz: ");
//decimal fiyat = decimal.Parse(Console.ReadLine());

//decimal indirimOrani = 0.25m;
//decimal indirimliFiyat = fiyat - (fiyat * indirimOrani);
//Console.WriteLine($"İndirimli Fiyat: {indirimliFiyat}");

//

//Baslangic:
//Console.Write("Lütfen adınızı giriniz: ");
//string ad = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(ad))
//{
//    Console.WriteLine("Ad boş olamaz. Lütfen geçerli bir ad giriniz.");
//    goto Baslangic;
//}
//else
//{
//    Console.WriteLine($"Merhaba {ad}!");
//}

//
#endregion

#region 3. TEKRAR

//for (int i = 0; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}

//

//for(int i = 0; i <= 50; i++)
//{
//    if (i % 2 == 0)
//        Console.WriteLine(i);
//}

//

//Console.Write("Lütfen bir sayı giriniz: ");
//int sayı = int.Parse(Console.ReadLine());
//int toplam = 0;

//for (int i = 0; i < sayı; i++)
//{
//    toplam += i;
//}
//Console.WriteLine($"1'den girmiş olduğunuz sayıya kadar olan sayıların toplamı: {toplam}");

//

//string[] name = { "Alper" };
//for (int i = 0; i < name[0].Length; i++)
//{
//    Console.WriteLine(name[0][i]);
//}

//

//string[] meyve = { "Elma", "Armut", "Muz", "Karpuz", "Çilek" };
//foreach (string item in meyve)
//{
//    Console.WriteLine(item);
//}

//

//int[] sayilar = { 10, 20, 30, 40, 50 };
//int toplam = 0;
//foreach(int item in sayilar)
//{ 
//    toplam += item;
//}
//Console.WriteLine($"Dizideki sayıların toplamı: {toplam}");

//

//string name = "Alper";
//foreach (char item in name)
//{
//    Console.Write($"{item} ");
//}

//

//int[] sayilar = { 10, 20, 30, 40, 50, 85, 75, 60, 90, 110, 25 };

//int enYuksekSayi = int.MinValue;

//foreach (int item in sayilar)
//{
//    if (item > enYuksekSayi)
//    {
//        enYuksekSayi = item;
//    }
//}
//Console.WriteLine($"Dizideki en büyük sayı: {enYuksekSayi}");

//

//string[] kelime = { "Ay", "Masa", "Kalem", "Çiçeklik", "Kütüphane" };
//string enUzun = string.Empty;

//foreach (string item in kelime)
//{
//    if (item.Length > enUzun.Length)
//    {
//        enUzun = item;
//    }
//}
//Console.WriteLine($"Dizideki en uzun kelime: {enUzun}");

#endregion

#region 4. TEKRAR
#region 4.Ders 1.Ödev
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

#region 4.Ders 2.Ödev

//string[] kavanoz = { "Kırmızı Şeker", "Kırmızı Şeker", "Yeşil Şeker", "Kırmızı Şeker", "Mavi Şeker", "Sarı Şeker", "Kırmızı Şeker" };
//int sayac = 0;
//foreach (string item in kavanoz)
//{
//    if (item == "Kırmızı Şeker") sayac++;
//}
//Console.WriteLine($"Kavanoz içerisinde {sayac} adet Kırmızı Şeker vardır.");
#endregion

#region 4.Ders 3. Ödev

//TODO: 3 öğrenci ve notları var for döngüüsü ile puan ortalamasını bulunuz.
//string[] ogrenciler = { "Alper", "Hilal", "Sevde" };
//double[] notlar = { 80, 70, 90, 60, 100, 75, 95, 85, 100 };

//for (int i = 0; i < ogrenciler.Length; i++)
//{
//    double toplam = 0;
//    for (int j = 0; j < notlar.Length / ogrenciler.Length; j++)
//    {
//        toplam += notlar[i * (notlar.Length / ogrenciler.Length) + j];
//    }
//    Console.WriteLine($"{ogrenciler[i]} adlı öğrencinin not ortalaması: {toplam / (notlar.Length / ogrenciler.Length)}");
//}


#endregion

#region 4.Ders 4. Ödev

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

#region 5. TEKRAR
//(VERİ TİPLERİ)
////TODO: Kullanıcıdan adını, yaşını ve boyunu al ve ekrana yazdır
//Console.Write("Lütfen adınızı giriniz: ");
//string ad = Console.ReadLine();
//Console.Write("Lütfen yaşınızı giriniz: ");
//int yas = int.Parse(Console.ReadLine());
//Console.Write("Lütfen boyunuzu giriniz: ");
//int boy = int.Parse(Console.ReadLine());
//Console.WriteLine($"\nMerhaba {ad}, Yaşın: {yas} ve Boyun: {boy} cm");

////TODO: Kullanıcıdan 3 tane sayı iste ve bu sayıların ortalamasını hesapla
//Console.Write("Lütfen ekrana 1. sayıyı giriniz: ");
//double sayi1 = double.Parse(Console.ReadLine());
//Console.Write("Lütfen ekrana 2. sayıyı giriniz: ");
//double sayi2 = double.Parse(Console.ReadLine());
//Console.Write("Lütfen ekrana 3. sayıyı giriniz: ");
//double sayi3 = double.Parse(Console.ReadLine());
//double toplam = sayi1 + sayi2 + sayi3;
//double ortalama = toplam / 3;
//Console.Write($"\nGirmiş olduğunuz sayıların ortalaması: {ortalama}");

////TODO: Kullanıcıdan adı,yaşı,boyu ve kilo bilgilerini iste.
//Console.Write("Lütfen adınızı giriniz: ");
//string ad = Console.ReadLine();
//Console.Write("Lütfen yaşınızı giriniz: ");
//int yas = int.Parse(Console.ReadLine());
//Console.Write("Lütfen boyunuzu giriniz: ");
//double boy = double.Parse(Console.ReadLine());
//boy = boy / 100;
//Console.Write("Lütfen kilonuzu giriniz: ");
//double kilo = double.Parse(Console.ReadLine());
////TODO: Kullanıcının Vücut Kitle İndeksini hesapla ve sonucu ekrana yazdır.
//double vücutKitleIndeksi = kilo / (boy * boy);

//string durum;
//if (vücutKitleIndeksi < 18.5)
//    durum = "Zayıf";
//else if (vücutKitleIndeksi < 25)
//    durum = "Normal";
//else if (vücutKitleIndeksi < 30)
//    durum = "Kilolu";
//else
//    durum = "Obez";

//Console.WriteLine("<18.5 = zayıf, 18.5–24.9 = normal, 25–29.9 = kilolu, 30+ = obez");
//Console.WriteLine($"Merhaba {ad} VKİ değeriniz: {vücutKitleIndeksi:F2} ({durum})");

//(KARAR YAPILARI)
//TODO: Kullanıcıdan bir sayı iste. Negatif - Pozitif - 0 mı olduğu yazdır.
//Console.Write("Lütfen bir sayı giriniz: ");
//int sayi = int.Parse(Console.ReadLine());
//if (sayi == 0)
//    Console.WriteLine("Girmiş olduğunuz sayı 0'dır.");
//else if (sayi < 0)
//    Console.WriteLine("Girmiş olduğunuz sayı Negatif bir sayıdır.");
//else
//    Console.WriteLine("Girmiş olduğunuz sayı Pozitif bir sayıdır.");

////TODO: Kullanıcıdan yaşını iste sonuca göre reşit veya reşit değil.
//Console.Write("Lütfen yaşınızı giriniz: ");
//int yas = int.Parse(Console.ReadLine());
//if (yas >= 18)
//    Console.WriteLine($"Yaşınız: {yas}, Reşitsiniz");
//else
//    Console.WriteLine($"Yaşınız: {yas}, Reşit Değilsiniz");

////TODO: Kullanıcıdan 0-100 arası bir not al, nota göre harf belirle.
//Baslangiç:
//Console.Clear();
//Console.Write("Lütfen Matematik dersinden aldığınız notu giriniz: ");
//int not = int.Parse(Console.ReadLine());
//string harfPuan = " ";
//if (not <= 100 && not >= 90)
//    harfPuan = "A";
//else if (not <= 89 && not >= 80)
//    harfPuan = "B";
//else if (not <= 79 && not >= 70)
//    harfPuan = "C";
//else if (not <= 69 && not >= 60)
//    harfPuan = "D";
//else if (not <= 59 && not >= 0)
//    harfPuan = "F";
//else
//{
//    Console.WriteLine("Geçersiz bir not girdiniz");
//    Console.ReadKey();
//    goto Baslangiç;
//}
//Console.WriteLine($"Aldığınız not: {not} Harf Notunuz: {harfPuan}");
//Console.ReadKey();
//goto Baslangiç;

//(DÖNGÜLER)
////TODO: 1-10 a kadar sayıları for döngüsüyle ekrana yazdır.
//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine($"Döngüdeki sıra: {i}");
//}

////TODO: Şehirlerden oluşan string dizisi yap foreach ile ekrana yazdır
//string[] sehirler = { "Ankara", "Antalya", "Muğla", "Aydın" };
//foreach (string s in sehirler)
//{
//    Console.WriteLine(s);
//}

//TODO: int dizisi içinde sayıların çiftini bul.
//int[] sayilar = { 3, 8, 12, 5, 20, 7 };
//int toplam = 0;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    if (sayilar[i] % 2 == 0)
//    {
//        Console.WriteLine(sayilar[i]);
//        toplam += sayilar[i];
//    }
//}
//Console.WriteLine($"\nÇift Sayıların toplam: {toplam}");

////TODO: 1. kullanıcıdan 5 tane şehir ismi al, bir diziye kaydet.
//string[] sehirler = new string[5];
//for (int i = 0; i < sehirler.Length; i++)
//{
//    Console.Write($"lütfen {i + 1}. şehri giriniz: ");
//    sehirler[i] = Console.ReadLine();
//}

////TODO: 2. bu şehirlerin harf sayılarının ortalamasını bul ve ekrana yazdır.
//int toplamharf = 0;
//foreach (string sehir in sehirler)
//{
//    toplamharf += sehir.Length;
//}

//double ortalama = (double)toplamharf / sehirler.Length;

//Console.WriteLine($"\nşehirlerin ortalama harf sayısı: {ortalama:f2}");

////TODO: Int dizisi oluştur. tek sayıları topla, çift sayıları çarp
//int[] sayilar = { 12, 45, 67, 23, 90, 34 };
//int toplama = 0;
//int carpma = 1;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    if (sayilar[i] % 2 == 0)
//    {
//        carpma *= sayilar[i];
//    }
//    else
//    {
//        toplama += sayilar[i];
//    }
//}
//Console.WriteLine($"Çift sayıların çarpımı: {carpma} ");
//Console.WriteLine($"Tek sayıların toplamı: {toplama} ");

////TODO: String dizisi oluştur. Elemanların son harflerini ekrana yazdır.
//string[] kelime = { "CSharp", "Yazılım", "Kodlama" };
//for (int i = 0; i < kelime.Length; i++)
//{
//    char sonHarf = ' ';
//    for (int j = 0; j < kelime[i].Length; j++)
//    {
//        sonHarf = kelime[i][j];
//    }
//    Console.WriteLine($"{kelime[i]} kelimesinin son harfi: {sonHarf}");
//}

//string[] kelimeler = { "CSharp", "Yazılım", "Kodlama" };

//foreach (string kelime in kelimeler)
//{
//    char sonHarf = kelime[kelime.Length - 1];
//    Console.WriteLine($"{kelime} kelimesinin son harfi: {sonHarf}");
//}

////TODO: Dizi içerisindeki en uzun ve en kısa şehir ismini bul ekrana yazdır.
//string[] sehir = { "Ankara", "İstanbul", "Aydın", "Balıkesir" };
//string enUzun = sehir[0];
//string enKısa = sehir[0];
//foreach (string s in sehir)
//{

//    if (s.Length > enUzun.Length)
//    {
//        enUzun = s;
//    }
//    else if (s.Length < enKısa.Length)
//    {
//        enKısa = s;
//    }

//}
//Console.WriteLine($"Dizideki en uzun şehir: {enUzun}");
//Console.WriteLine($"Dizideki en kısa şehir: {enKısa}");

////TODO: Dizideki sayıların ortalamasını bul
//int[] sayilar = { 10, 25, 40, 60, 80, 100 };
//double toplam = 0;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    toplam += sayilar[i];
//}
//double ortalama = toplam / sayilar.Length;
//Console.WriteLine($"Dizideki sayıların ortalaması: {ortalama}");
////TODO: Ortalamanın üzerindeki sayıları ekrana yazdır.
//for (int i = 0;i < sayilar.Length; i++)
//{
//    if(sayilar[i] > ortalama)
//    {
//        Console.WriteLine($"\nDizide ortalama üzerinde kalan sayılar: {sayilar[i]}");
//    }
//}

////TODO: Dizideki kelimelerin son harflerinden yeni bir kelime oluştur.
//string[] kelime = { "Yazılım", "CSharp", "Kodlama" };
//string sonHarfler = "";
//foreach (string harf in kelime)
//{
//    char sonHarf = harf[harf.Length - 1];
//    Console.WriteLine($"{harf} kelimesinin son harfi: {sonHarf}");
//    sonHarfler += sonHarf;
//}
//Console.WriteLine($"{sonHarfler}");

//TODO: Kullanıcıdan 10 tane tam sayı al.
//using Çalışma;

//Console.Write("Lütfen ekrana 10 tane tam sayı giriniz: ");
//int sayilar = int.Parse(Console.ReadLine());
//int[] hesap = { sayilar };
//int enBüyük = 0;
//foreach (int item in hesap)
//{
//    if (item >= enBüyük)
//    {
//        enBüyük = item;
//    }
//}
//Console.WriteLine($"Dizideki en büyük sayı {enBüyük}");

#endregion

#region 6. TEKRAR
////TODO: Kullanici kahve siparisini verirken scecek turu, seker sayisi, sut nasil olacagini secsin
//using Çalışma;

//Console.Write("Lütfen kahve türünü seçin: (1 - Turk Kahvesi, 2 - Latte, 3 - Espresso): ");
//string turu = Console.ReadLine();

//Console.Write("Lutfen seker sayisini girin: ");
//int sekerSayisi = int.Parse(Console.ReadLine());

//Console.Write("Sut ister misiniz (E/H)?: ");
//string sutluMu = Console.ReadLine().ToUpper();
//bool sutVarMi = false;
//if (sutluMu == "E")
//{
//    sutVarMi = true;
//}
//switch (turu)
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

//TODO: 2. ODEV
//using Çalışma;

//Market  market = new Market();
//market.FiyatGir();
#endregion

#region 7.TEKRAR
////TODO: Kullanıcıdan içecek türü, şeker sayısı ve süt isteğini sor.
//using Çalışma;

//Console.Write("Lütfen kahve türünü seçin: (1 -Türk Kahvesi, 2 -Latte, 3 -Espresso): ");
//string turu = Console.ReadLine();

//Console.Write("Lütfen şeker sayısını giriniz: ");
//int sekerSayısı = int.Parse(Console.ReadLine());

//Console.Write("Süt ister misiniz?(E/H): ");
//string sut = Console.ReadLine();
//bool sutVarmı = false;
//if (sut == "E")
//{
//    sutVarmı = true;
//}

//switch (turu)
//{
//    case "1":
//        turu = "Türk Kahvesi";
//        break;
//    case "2":
//        turu = "Latte";
//        break;
//    case "3":
//        turu = "Espresso";
//        break;
//}

//KahveSiparisi2 getır = new KahveSiparisi2();
//Console.WriteLine($"{getır.Hazirla(turu, sekerSayısı, sutVarmı)}");
//Console.WriteLine($"Ödenecek tutar: {getır.UcretiHesapla(turu)} TL");


#endregion

#region 8. TEKRAR
//Console.Write("Lütfen yaşınızı giriniz: ");
//int yas = int.Parse(Console.ReadLine());
//if (yas >= 18)
//{
//    Console.WriteLine("Reşitsiniz");
//}
//else
//{
//    Console.WriteLine("Reşit değilsiniz");
//}

//string gun = Console.ReadLine().ToLower();

//switch (gun)
//{
//    case "cumartesi":
//    case "pazar":
//        Console.WriteLine("Hafta sonu");
//        break;
//    default:
//        Console.WriteLine("Hafta içi");
//        break;
//}

#endregion

#region 9. TEKRAR

using Çalışma;
using Çalışma.Dependency_inversion_principle;
//Console.WriteLine("BILGI YARIŞMASINA HOŞGELDİNİZ");
//Console.Write("Lütfen adınızı giriniz: ");
//string isim = Console.ReadLine();

//Soru.SoruOlustur();
#endregion

#region 10. TEKRAR

Email email = new Email
{
    EmailAdresi = "alperclbi@hotmail.com",
    Konu = "Merhaba, nasılsın?",
};

Whatsapp whatsapp = new Whatsapp
{
    TelefonNumarasi = "05551234567",
    Icerik = "Selam, bugün buluşalım mı?",
};

Discord discord = new Discord
{
    KullaniciAdi = "flashalp",
    Kanal = "Genel Sohbet",
};

Bildirim bildirim = new Bildirim(new List<IMesaj> { email, whatsapp, discord });
bildirim.BildirimGonder();

#endregion
