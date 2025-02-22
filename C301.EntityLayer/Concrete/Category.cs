using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }  
        public bool CategoryStatus { get; set; }
        public List <Product> Products { get; set; }// Bir tarafa tekil bir tarafa çoğul olmak üzere iki tane property eklendi.
                                                    // Product tarafına tekil olarak ID eklendi.
                                                    // Her bir ürünün sadece bir tanesi kategorisi olmalı.
                                                    // Burada çoğul olmasının sebebi bir kategori birden fazla ürün için olabilir.
                                                    
    }
}
