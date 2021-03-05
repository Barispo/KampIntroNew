using System;
using System.Collections.Generic;
using System.Text;

namespace Musteri

{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklenmiştir  : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silinnmiştir  : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelenmiştir  : " + musteri.Adi + " " + musteri.Soyadi);
        }


    }


}
