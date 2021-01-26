using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager 
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            //TasitKrediManager 
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            //KonutKrediManager
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //list kısmını yazınca karışmaması için comment yaptık


            //burada parantezin içine IKrediManager bir interface new lenemez çünkü ama
            //başvuru yaparken; ihtiyaç,konut taşit ı yollayabilirim
            //burası şubedeki arakdaşın ekranı.kullanılabilecek krediler. 3 tane suan
            //hangi krediyi gönderirsen aslında onun hesaplaması başlıyor. 

            //IhtiyacKrediManager, TasitKrediManager  bunları demek yerine IKrediMAnager da diyebiliriz.
            //bu demek oluyor ki; interfaceler de o interface ı implemente eden referans numarasını tutabiliyormuş.
            //yani interface onu implement eden class ın referansını tutabilir.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
