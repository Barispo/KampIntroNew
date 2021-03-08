using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelMusteri:Musteri   // yan taraftaki ":Musteri" ifadesi INHERITANCE miras, yani Musteri' de olan herşey burada da kabul edilir
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
