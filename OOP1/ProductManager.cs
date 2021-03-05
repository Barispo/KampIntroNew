using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi");
        }     
    }
}
// (1)Void şeklinde belirtilen metodlar emir kipinde iş yaptırmaktır.Emir kipinde işi çağırıp, yapıyor.
//İşin sonucunda ortaya çıkan değeri başka bir yerde kullanabilmek mümkün olmuyor.

//return' u ise sonucu tekrar kullanabilmek için kullanıyoruz. !!
