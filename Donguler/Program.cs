using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Phyton";
            string kurs5 = "C#";

           
            //array - dizi //KURSLARIN DİZİ İÇERİSİNDE GÖSTERİLMESİ
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç İçin Temel Kurs","Java","Phyton","c#","Fortran","Cobol"};

            //PROGRAMLAMA DİLLERİ GENELLİKLE SAYMAYA 0 (SIFIR)'DAN BAŞLAR.
            //kURSLARIN BİR DÖNGÜ İÇEİRİSNDE LİSTELENMESİNE AİT KOD
            //AŞAĞIDAKİ KOD GENEL KULLANIM AMAÇLIDIR.
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar [i]);
            }
            Console.WriteLine("--------FOR BİTTİ-------");
            
            
            //AŞAĞIDAKİ DİZİ TEMELLİ YAPILARI TEK TEK DÖNME KODU'DUR.
            //AŞAĞIDAKİ "KURS" SADECE TAKMA İSİMDİR-ALIAS, VERİ TUTARKEN KOLAYLIK SAĞLAMASINI AMAÇLAR.
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            
            
            Console.WriteLine("-----------SAYFA SONU-------FOOTER-----");
        }
    }
}
