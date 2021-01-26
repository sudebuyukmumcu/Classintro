using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //referans alanları. primary key dediğimiz Id leri ekleriz. kodun okunurluğu için sıralamyı bu şekilde yazarız.
        //bu tip classlarda sadece özellik olur.
        //burada eklemek,silmek,güncellemek gibi operasyonlar vardır.
    }
}
