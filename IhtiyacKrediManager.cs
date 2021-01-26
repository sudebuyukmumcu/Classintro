using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager  //her kredi mutalaka KrediManagerdakileri içermek zorunda
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //burada da işlemler kodlar yazıldı farzedelim
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
