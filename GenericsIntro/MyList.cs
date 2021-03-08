using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>   //mylist'te T ile çalışacağım demek, bana bit tip ver demek !
    {
        T[] items;
        public MyList()   //ctor 2 tab ile oluşuyor.Bu bir CONSTRUCTOR blok ve metod'dur.New dediğin anda bu blok otomatik çalışır.
        {
            items = new T[0];    //o elemanlı bir dizi anlamında...
        }
        public void Add(T item)     //T türünde verdiğim ne ise isteyeceğim o'dur.item genel bir isimdir, takma ad gibi
        {
            T[] tempArray = items;     //Geçici dizinin tutturulması, önceki elemanların new'lendiğinde kaybolmaması için geçici dizi!!

            items = new T[items.Length + 1];  //Dizinin eleman sayısı
            for (int i = 0; i < tempArray.Length; i++)  //for yazıp, 2 defa tab yapıyoruz.//Bu kod, tempArray'ın tüm elemanlarını i' ye geri atıyoruz.
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;  //aslında eklanmek istenen eleman bu satırda ekleniyor.
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
                    {
            get { return items; }
        }
    }
}

//Bir class çalışırken NEW' lendiğinde çalışan bloğa CONSTRUCTOR denir.!!!!!!