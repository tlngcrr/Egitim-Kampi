using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }// Her ürünün bir kategori ID'si olmalı.
        public virtual Category Category  { get; set; }// Bir ürünün kategori özelliklerine ulaşmak için kullanılır.
                                                       // kategori tablasonun değerlerine ürün üzerinden ulaşabilmek adına eklendi

        public List<Order> Orders { get; set; }//Order tablosu ile orders ismiyle çoğul olarak Code First'te ilişkiyi oluşturu
       

    }
}
