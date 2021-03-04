using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // ekrana yazdırılsaydı sayi1 kaç çıkardı ?  
            //CEVAP: 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] elemanı kaç olurdu ?           
            //CEVAP: 999


            //int, decimal, float, double,bool(arka planda 1 ve 0'ı tutar)  == DEĞER TİPLERDİR.
            //array, class, interface  == REFERANS TİPLERDİR.

            //Bellekte Stack ve Heap alanları vardır.Değer tipler STACK ve Referans tipler HEAP' te gerçekleşir.

            //==========DEĞER TİPLERDE "DEĞER" ATANIR, REFERANS TİPLERDE "ADRES" ATANIR !!!!==========

            //===SORU 1 ÇÖZÜM===                          
            //Sayi1 = 10 (30 olarak değeri atanır,10 ile bağlantı kopar)                
            //Sayi2 = 30 (65 olarak değeri atandığı için 30 ile bağlantısı kopar)
            //Yukarıdaki örnekte sayi1 sayi2'ye eşitlendiğinde, atandığında sayi1'in 10 ile bağlantısı kopar, sayi2'nin de sayi2 = 65 değeri atandığında 30 ile bağlantısı kopar.


            //===SORU 2 ÇÖZÜM===
            //   STACK                                                                                              HEAP
            //int[] sayilar1 = new kodu yazılınca bellekte 101(örn) no'lu adreste "sayilar1"---------> 101 no'lu adreste [10,20,30] değerlerini tutar.
            //int[] sayilar2 = new kodu yazılınca bellekte 102(örn) no'lu adreste "sayilar2"---------> 102 no'lu adreste [100,200,300] değerlerini tutar.
                        //sayilar1 = sayilar2' nin okunuşu ise sayilar1'in referans kodu == sayilar2'in referans kodu'dur.
            //sayilar1 = sayilar2 dendiğinde sayilar1'in tuttuğu referans kodu 101 iken, 102 olarak değişir!!!!!, 101 ile bağlantı kopar,
            //sayilar2[0] = 999 ile demek istenen sayilar2'nin 0.elemanı=999'dur.
            //102 no'lu adreste tutulan dizinin ilk elemanı [999,...,....] olur !!!!! 

            //====Stack' te 101'i tutan olmayınca .net'in garbage collector bu adresi bellekten atar===


        }
    }
}
