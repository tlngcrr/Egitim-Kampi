using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
    }
}
/*
 SOLİD:
Single Responsibility: Tek sorumluluk ilkesi demek. Bir metot, bir sınıf ya da başka bir bileşen bağlı bulunduğu alnda sadece tek bir işlem yapmalıdır.

 */
