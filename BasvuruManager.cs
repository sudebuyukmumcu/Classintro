using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager) //bu parametreyi yazmam sayesinde ihtiyaç,taşıt,konut hangisini istersen yollayabilirim demek
          //eğer buraya ihtiyaç kredisini gönderirsem bellekteki ihtiyaç kredisinin işlemi çalışır. vb...

        {
            //Başvuran bilgilerini değerlendirme
            //
            ////KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //bu şekilde yazmayıp aşağıdaki imlementi yazarım.

            krediManager.Hesapla(); 

            //****ÖNEMLİ: böyle yaparsam tüm başvuruları konutkredisine bağımlı hale getirim.bu yanlış
            //basvuru yaparken bir parametre alsam. bu başvuruyu hangi krediye başvurmamı söylesin.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //bir liste olduğuna göre foreach yaparız ki listedeki her şeyi tek tek dolaşalım.

            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); //listedeki her bir kredinin hesabını yap demek.
            }
            //bu noktada bana bir liste ver ve bu listenin türü IKrediManager olsun diyorum.
        }
    }
}
