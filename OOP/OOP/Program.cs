#region Constructor / Destructor
//ÖDEV
#endregion

#region Encapsulatiion (Kapsullüme)
//ÖDEV
#endregion

#region Inheritance (Kalıtım)
//ÖDEV
#endregion

#region Polymorphism (Çok Biçimlilik)
using OOP;
using OOP.Polymorphism;
using System.ComponentModel.Design;
//Dog dog = new Dog();
//dog.Sound();

//Cat cat = new Cat();
//cat.Sound();
#endregion

#region Kim Milyoner Olmak İster yarışması?
////TODO: Sunucu karsilama yapar
//YarismaMesajlari.YarismaBaslangicMesajiVer();
//YarismaSesleri.AlkisSesiCikar(5, 2000);
//string[] yarismacilar = { "Alper", "Busra", "Yahya Alp" };
//Random rnd = new Random();
////TODO: Gundelik hayattan konusulur
//Console.ForegroundColor = ConsoleColor.Green;
//Console.Write($"(Sunucu) Merhaba {yarismacilar[rnd.Next(0, 3)]} yarismamiza hosgeldiniz. Heyecanli misiniz (E/H)?: ");
//string heycanCevapVer = Console.ReadLine();
//switch (heycanCevapVer.ToUpper())
//{
//    case "E":
//        Console.ForegroundColor = ConsoleColor.Green;
//        Thread.Sleep(1000);
//        Console.WriteLine("(Sunucu) Heyecanli olmaniza gerek yok. Sakin olmaniz sizin yarismada basarili olma sansinizini attirir. Bol san diliyorum.");
//        break;
//    case "H":
//        Console.ForegroundColor = ConsoleColor.Green;
//        Thread.Sleep(1000);
//        Console.WriteLine("(Sunucu) Super. Sakin olmaniz sizin yarismada basarili olma sansinizi arttirir. Bol sans diliyorum");
//        break;
//    default:
//        Console.ForegroundColor = ConsoleColor.Green;
//        Thread.Sleep(1000);
//        Console.WriteLine("(Sunucu) Yanlis Cevap verdiniz ben size heyecanli misiniz diye sordum?");
//        break;
//}
//Thread.Sleep(2000);
//Console.ForegroundColor = ConsoleColor.Magenta;
////TODO: Hazir olma mesaji verilir
//Console.Write("(Sunucu) Simdi yarismaya baslayalim mi (E/H)?: ");
//string yarismaBaslangicCevapVer = Console.ReadLine();
//if (yarismaBaslangicCevapVer.ToUpper().Equals("E"))
//{
//    int kazanc = 0;
//    YarismaMesajlari.YarismaBasliyorMesajiVer();
//    SoruCevap soruCevap = new SoruCevap();
//    for (int i = 0; i < 15; i++)
//    {
//    SoruyuTekrarla:
//        Console.WriteLine(soruCevap.SoruSor(i));
//        Console.Write("Cevabiniz: ");
//        string cevap = Console.ReadLine();
//        Thread.Sleep(2000);
//        if (cevap.ToUpper() == "A" || cevap.ToUpper() == "B" || cevap.ToUpper() == "C" || cevap.ToUpper() == "D")
//        {
//            bool cevapDonus = soruCevap.CevapKontrol(i, cevap.ToUpper());
//            if (!cevapDonus)
//            {
//                Console.WriteLine("Tuhh !! Elendiniz !! Yarismaciya kocaman bir alkis !!!!!!!");
//                YarismaSesleri.AlkisSesiCikar(10, 0);
//                Console.WriteLine($"Kazanciniz: {kazanc}");
//                break;
//            }
//            else
//            {
//                kazanc += 100000;
//                YarismaSesleri.AlkisSesiCikar(5, 0);
//                Console.WriteLine("Tebrikler !!! Cevabiniz dogru !!!");
//            }
//            Console.WriteLine($"Kazanciniz: {kazanc}");
//        }
//        else
//        {
//            Console.Write("\n(Sunucu) Sen kafayı mı yedin? Şıklar belli sen ne seçtin ? Soruyu tekrarlıyorum. İyi dinle.....");
//            Thread.Sleep(1000);
//            goto SoruyuTekrarla;
//        }
//    }
//}
//else
//{
//    Thread.Sleep(1000);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("(Sunucu) Anladim! hazir oldugunuzda lutfen tekrar yarismamiza katilin. Size yol parasi hediye ediyoruz alkislar yarismamiz icin !!!!");
//    YarismaSesleri.AlkisSesiCikar(10, 2000);
//}
//Console.ReadKey();


#endregion

#region Yarisma Programi Odevi
//TODO: Bilgi yarışması giriş kısmı oluştur ve kulllanıcıdan isim al
//Console.WriteLine("Bilgi Yarışmasına Hoşgeldiniz!");
//Console.Write("Lütfen isminizi giriniz: ");
//string isim = Console.ReadLine();

//Soru soru = new Soru();
//soru.SoruOlustur();

#endregion