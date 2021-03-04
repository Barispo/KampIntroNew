using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Barış PİŞMİŞOĞLU";
            kurs1.IzlenmeOrani = 36;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Phython";
            kurs2.Egitmen = "Selma PİŞMİŞOĞLU";
            kurs2.IzlenmeOrani = 51;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Bülent PİŞMİŞOĞLU";
            kurs3.IzlenmeOrani = 65;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.Egitmen = "Emine PİŞMİŞOĞLU";
            kurs4.IzlenmeOrani = 75;


            //Console.WriteLine(kurs1.KursAdi + " : " +kurs1.Egitmen);      //listeleme şekli!
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        //proop yap ve 2 kez tab tuşuna bas
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
