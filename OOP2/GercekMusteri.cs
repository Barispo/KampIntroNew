using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri  // yan taraftaki ":Musteri" ifadesi INHERITANCE miras, yani Musteri' de olan herşey burada da kabul edilir.
    {
       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }


    }
}
