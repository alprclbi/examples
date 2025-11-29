//using DessignPatterns.Factory;
//using DessignPatterns.Singleton;
//using DessignPatterns.Student;
using DessignPatterns.Odev.FabrikaVeBaseSınıf;
using DessignPatterns.Strategy;
using System.Xml;

#region Singleton Pattern
//var logger = Logger.GetInstance();
//logger.Log("Program sağlıklı çalıştı.");

//StudentServices studentServices = new StudentServices(logger);
//studentServices.Add();
//studentServices.Delete();
//studentServices.Update();
//studentServices.List();
#endregion

#region Factory Pattern

//var sekilDaire = SekilFactory.GetSekil("daire");
//var sekilKare = SekilFactory.GetSekil("kare");


//sekilDaire.Ciz();
//sekilKare.Ciz();


#endregion

#region Ödev Singleton ve Factory Pattern
//Console.WriteLine("CHELEBI PIZZA'YA HOSGELDINIZ");
//Console.WriteLine("-------MENÜ-------");
//string[] pizza = { "1- Klasik Pizza", "2- Bol Malzemos Pizza", "3- Vejeteryan Pizza", "4- Sucuk Sever Pizza", "5- Margarita Pizza", };
//foreach (var item in pizza)
//{
//    Console.WriteLine(item);
//}
//Console.Write("Lütfen seçim yapınız: ");
//int secim = int.Parse(Console.ReadLine()!);
//Siparis siparis = new Siparis();
//siparis.PizzaSiparisi(secim);
#endregion

#region Strategy Pattern
var cebimdekiPara = 1000;
var anlikFiyat = 0;

Console.Write("Lütfen ürünün kodunu giriniz: ");
string kod = Console.ReadLine();

if (kod == "adidas")
{
    anlikFiyat = 1100;
}
else if (kod == "zara")
{
    anlikFiyat = 1300;
}

if (anlikFiyat > cebimdekiPara)
{
    var f = new FiyatStrategy { strateji = new Yüzde10() };
    Console.WriteLine($"Ödeme yöntemi kredi kartı --> ürün satış fiyatı {anlikFiyat}, indirimli fiyatı {f.Hesapla(anlikFiyat)}");
}
else
{
    var f = new FiyatStrategy { strateji = new Yüzde20() };
    Console.WriteLine($"Ödeme yöntemi nakit --> ürün satış fiyatı {anlikFiyat}, indirimli fiyatı {f.Hesapla(anlikFiyat)}");
}

#endregion
