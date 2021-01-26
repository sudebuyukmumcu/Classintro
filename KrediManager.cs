using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //bu sadece base görevi görüyor. ama tek başına asla bir anlam ifade etmiyor.
        //imzanın aynı olduğu ama içerisinin farklı olduğu durumlarda biz class olarak değilde interface olarak oluştururuz.
        //interface aslında benim şablonum görevini görüyor.
        //I ile başlarız KrediManager ın başına böylece Interface olduğunu anlarız.
        //interface ara yüz demek  bu aşağıdaki voidlerde yazılanlara uymak zorundasın demek.
    {
        void Hesapla();
        void BiseyYap();
                         
    }
}
