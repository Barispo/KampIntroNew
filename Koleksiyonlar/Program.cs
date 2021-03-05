using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Barış", "Selma", "Bülent", "Zeki" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5];
            isimler[4] = "İftihar";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            //Yukarıdaki örnekte dizi oluşturulurken sadece 4 elemanlı bir yer Heap'te oluşturuldu. 
            //Sonradan 5.elemanı yazdırmak için isimleri new yapıldığında önceki dizinin heap'te tutulan adres bırakıldığı için 
            //sadece isimlerin 4.elemanının (İftihar) da dahil olduğu 5 elemanlı bir dizi tutmaya başladı, diğer elemanları 
            //tanımlanmadığı içn ekrana boş sayfa gelir.15.ve 16.satırlardaki kodlar düzeltmeyi sağlamaya yönelik bir çözüm yöntemi.


            List<string> isimler2 = new List<string> { "Barış", "Selma", "Bülent", "Zeki" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İftihar");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //Bir diziye eleman eklemek ve önceki elemanların da tutulmaya devamını sağlamak için yukarıdaki 
            //isimler2 list'i kullanılır. Kullanım genel bir kullanımdır.
            
            
        }
    }
}
