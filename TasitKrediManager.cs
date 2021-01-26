using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
        //şimdi erkes kendi kurallarını yazabilir
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {

            //burada bununla ilgili bir sürü kod yazıldığını farzet

            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
