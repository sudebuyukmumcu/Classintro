using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    class TuzelMusteri: Musteri //sen bir musterisin diyoruz. bu olaya miraz (inheritance) denir.
        //TuzelMusteri bir Musteridir demek bu. Müşteride olan her şey tüzel müşteride de kabul edilir.

    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
