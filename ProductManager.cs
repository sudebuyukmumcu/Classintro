using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //string ad der gibi bir şey. Product diye bir veri tipine product ismini tanımlamışız gibi düşün.
        //aslında bu parantezin içi bizim metodumuzun nasıl çağırılacağını anlattığı yerdir.
        //diyor ki; ProductManager ın içindne çağıracaksın beni benim adım Add ve parametre olarak bana bir tane metin yolla diyorsun.
        //o yüzden bana burada da product türünde bir şey ver.
        //buranın amacı Product.cs nin tamamını kapsayarak kümülatif bir sistem oluşturmaktır.
        //sen bana product türünde bir şey göndereceksin ben onu product türünde bir şeyle tutuyor olacağım demektir buradaki anlamı.
        //biz bir ürün ekleyeceksek bu ekleme operasyonuna neyi ekleyeceğimizi söylememiz gerekir.
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
        
    }
}
//void ne işe yarıyor?
//void diye belirttiğimiz metodlar; senin bu işlem sonucunun ne olduğuyla ilgili bir bilgiye ihtiyacın yoksa void diye tanımlıyoruz
//örnek:
//public int Topla(int sayi1, int sayi2)
//return sayi1 +sayi2
//böyle yapsam ne olur?
//public void Topla2(int sayi1, int sayi2)
//Console.WriteLine(sayi1 + sayi2); 
//böyle yapsam ne olur? niye return'e ihtiyacım oldu?
//işlem sonucunda ortaya çıkan işlem sonucunu bir daha kullanmak istiyorsam, void yapamam.
//çünkü void git yap bitir demek. Eğer senin işlem sonucunda değeri kullanmaya devam etmekye ihtiyacın varsa void olmaz.
//int toplamaSonucu= productManager.Topla(3,6) return de verilen değeri buradaki int toplamaSonucu'na atayabiliyorum.
//bu toplamayı: Program.cs sayfasında productManager.Topla2(3, 6); şu şekilde yazarak hesapladık.
//kısacası bu sonucu tekrar kullanabilmek iiçin returnleri kullanıyoruz.


