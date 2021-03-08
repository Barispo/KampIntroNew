using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123354";
            musteri1.Adi = "Barış";
            musteri1.Soyadi = "PİŞMİŞOĞLU";
            musteri1.TcNo = "1234567890";


            //SOLID yazılım geliştirme prensipleri

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "23455";
            musteri2.SirketAdi = "BPO";
            musteri2.VergiNo = "123456789";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);



        }
    }
}
