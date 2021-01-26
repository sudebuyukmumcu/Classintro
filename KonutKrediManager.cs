using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager //çünkü bunun da içerisinde hesap olsun istiyorum
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //buradada kodlar yazıldı varsayalım
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
