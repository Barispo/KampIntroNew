using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 45;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 25;
            urun3.Aciklama = "Artvin Armudu";


            Urun[] urunler = new Urun[] {urun1,urun2,urun3 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-------O---------");
            }

            Console.WriteLine("------METODLAR---------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            //Aşağıdaki kod büyük sorun yaratabilecek bir kodlama şeklidir.Encapsulation için yazılmış bir kod örneğidir.
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,11);
            sepetManager.Ekle2("Karpuz", "Yeşil Karpuz", 12,12);
        }
    }
}


//Tekrar tekrar kullanılabilir kod blokları metodlar ile kodlanır.
//Don' Repeat Yourself - DRY
//Clean code - Best Practice (En iyi uygulama teknikleri)
//Type safe - Tip güvenli
// Encapsulation ekle ve ekle2 örnekleri önemlidir.