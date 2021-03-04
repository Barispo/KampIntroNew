using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("TEBRİKLER  Sepete Eklendi :" + urun.Adi);
        }

        
        //Farklı bir ekleme metod operasyonu
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("TEBRİKLER  Sepete Eklendi :" + urunAdi);
        }
    }

}



//Manager,service,dal birer operasyon tutarlar
//Naming convention
//Syntax