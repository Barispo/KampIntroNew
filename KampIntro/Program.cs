using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety  -Tip Güvenliği, tanımlanacak verinin önüne veri tipi yazılmalı(string, int., dec.vs)
            //do not repeat yourself - kendini tekrarlama


            string kategoriEtiketi = "Kategoriler";
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 320000000;        //tamsayıların tutulduğu veri tipi
            double faizOrani = 1.45;             //ondalıklı sayıların tutulduğu veri tipi
            bool sistemeGirisYapmisMi = true;   //döngülerin tutulduğu veri tipi

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            //-------------------şart blokları örneği------
            double dolarDun = 7.5;    
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
        }



    }
}
