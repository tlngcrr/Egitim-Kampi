using C301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp301.DataAccessLayer.Context
{
    public class KampContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }//Entity katmanında olan tabloları verir
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet< Customer>Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
//Veri tabanına yansıyacak olan bütün sınıflar Kampcontex'in içinde yer alır.
//Category ifadesi ile Categories arasındaki fark  Category ifadesi C# tarafından kullanılacak olan sınıf ismi.
//Categories ise SQL'e yansayacak olan tablo ismi