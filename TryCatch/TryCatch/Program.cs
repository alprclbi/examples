Baslangic:
try
{
	Console.Write("Lütfen bir sayı giriniz: ");
	int sayi = int.Parse(Console.ReadLine());
	Console.WriteLine("Girilen değer " + sayi + "");
}
catch (Exception)
{
	Console.WriteLine("Uygulama hata verdi ama sen uygulamayı hala kullanmaya devam ediyorsun.");
	goto Baslangic;
	throw;
}