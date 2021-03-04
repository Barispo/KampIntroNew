using System;

namespace BarisDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac arac1 = new Arac();
            arac1.aracMarka = "HONDA";
            arac1.aracModel = "Jazz";
            arac1.aracModelYil = 2009;

            Arac arac2 = new Arac();
            arac2.aracMarka = "TOYOTA";
            arac2.aracModel = "Corolla";
            arac2.aracModelYil = 2019;

            Arac arac3 = new Arac();
            arac3.aracMarka = "SUBARU";
            arac3.aracModel = "Impreza";
            arac3.aracModelYil = 2015;

            Arac arac4 = new Arac();
            arac4.aracMarka = "Mazda";
            arac4.aracModel = "626";
            arac4.aracModelYil = 1998;

            Arac[] araclar = new Arac[] { arac1, arac2, arac3,arac4 };
            foreach (var arac in araclar)
            {
                Console.WriteLine(arac.aracMarka + "   /   " + arac.aracModel + "   /   " + arac.aracModelYil );
            }
        }
    }
}

class Arac

{
    public string aracMarka { get; set; }
    public string aracModel { get; set; }
    public int aracModelYil { get; set; }
}
