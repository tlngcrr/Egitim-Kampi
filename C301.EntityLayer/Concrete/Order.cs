using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }//Hangi ürünün satıldığı bilinmeli
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }//Adet fiyatı
        public decimal Totalprice { get; set; }
        public int CustomerId { get; set; }//Kime satıldı
        public virtual Customer Customer { get; set; }//Müşterinin diğer bilgilerine ulaşmak için
    }
}
