using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKredisManager();
            IKrediManager esnafkredisi = new EsnafKredisiManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLogerService = new FileBaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafkredisi, new List<ILoggerService> {new DataBaseLoggerService(), new SmsLoggerService()});  //Database ile ilgili instance' ı "new dataBaseLoggerService()" şeklinde de yazabiliriz
            //Üst satırdaki kodda ILoggerService için ayrıca instance yazarak  2 farklı loglama işlemi yaptırılabilir.   
            

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager };  //Krediler arasında seçim
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



            //Interface' ler onu implemente eden class'ın referans numarasını tutabiliyor.!!!!!
            //IKrediManager ifadesini İhtiyacKredisiManager yada diğer TasitKrediManager ya da KonutKrediManager değiştirdiğinde sorun çıkmaz !!!

        }
    }
}
