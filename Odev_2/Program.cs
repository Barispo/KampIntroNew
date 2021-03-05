using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Barış";
            musteri1.Soyadi = "ATEŞ";
            musteri1.kimlikNo = "01234567891";
            musteri1.Sehir = "İzmir";
            musteri1.cepTel = 3990039;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Selma";
            musteri2.Soyadi = "SU";
            musteri2.kimlikNo = "9876543210";
            musteri2.Sehir = "İzmir";
            musteri2.cepTel = 2222288;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Bülent";
            musteri3.Soyadi = "DOKTOR";
            musteri3.kimlikNo = "7776543210";
            musteri3.Sehir = "İzmir";
            musteri3.cepTel = 3332044;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine(musteri.kimlikNo);
                Console.WriteLine(musteri.cepTel);
                Console.WriteLine("================");
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Liste(musteri3);
        }
    }
}
