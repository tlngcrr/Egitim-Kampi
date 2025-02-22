using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        //İnternal bir access modifiersdir. Yani erişim belirleyicidir
        //İnternale bulunduğu katmandan erişim sağlayabiliyor
        //Public halkarzdır. HEerkes erişebilir.
        //Private sadece bulunduğu classtan bulunduğu alandan erişim sağlıyor.
        //Protected ise bir sınıf ve o sınıfın miras aldığı yerlerden erişim sağlayabiliyor

        public int CategoryId { get; set; } //get alır set ayarlar
        public string CategoryName { get; set; } 
        public bool CategoryStatus { get; set; } 



    }
}/*
   Fielde-Variable-Property
   aralarında fark vardır.
   Eğer ki bir değişken direkt sınıfın şiçerisinde tanımlanırsa bu bir fielddir.
   Eğer ki o değişken sonuna get ve set alırsa o bir propertydir
   Eğer ki değer bir metot içerisinde tanımlanırsa değişken oluyor
  */
