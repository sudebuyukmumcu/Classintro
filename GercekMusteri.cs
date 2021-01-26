using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    class GercekMusteri:Musteri  //(gerçek müşteride bir müşteridir.
        //inheritance deniyor. Müşteride olan özellikler artık gerçekte de tüzel de de vardır demektir.

    {
       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
    }
}
