#region Single Responsibility Principle
using Sunum.DependencyInversion;
using Sunum.InterfaceSegregation;
using Sunum.LiskovSubstitution;
using Sunum.OpenClosed;
using Sunum.SingleResponsibility;

//RaporYazici raporYazici = new RaporYazici();
//RaporKaydedici raporKaydedici = new RaporKaydedici();

//raporKaydedici.RaporuKaydet("Satış Raporu");
//raporYazici.RaporuYazdir("Satış Raporu");

#endregion

#region Open/Closed Principle

//KrediKartiOdeme krediKartiOdeme = new KrediKartiOdeme();
//krediKartiOdeme.Odeme();

//HavaleOdeme havaleOdeme = new HavaleOdeme();
//havaleOdeme.Odeme();

#endregion

#region Liskov Substitution Principle

//Kanarya kanarya = new Kanarya();
//kanarya.Uc();

//Tavuk tavuk = new Tavuk();
//tavuk.Uc();


//Bmw bmw = new Bmw();
//bmw.Calistir(); bmw.KlimaAc();

//Dogan dogan = new Dogan();
//dogan.Calistir();

#endregion

#region Interface Segregation Principle

//BasitYazici basitYazici = new BasitYazici();
//basitYazici.Yazdir();

#endregion

#region Dependency Inversion Principle
//using Sunum.DependencyInversion;
//OdemeIslemcisi odemeIslemcisi = new OdemeIslemcisi(new Sunum.DependencyInversion.KrediKartiOdeme());
//odemeIslemcisi.OdemeYap();
#endregion

