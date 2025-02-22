using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud -->Create-Read-Update-Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------");
            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı:");
            //string categoryName=Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data source=CAPER\\SQLEXPRESS;initial catalog=EgiimKampiDb;//Veritabanı adresi tutar integrated security=true");
            //connection.Open();
            //Comman sorgu işlerini yapar
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values(@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);//@ Karakteri SQL tarafından tanımlanan özel bir karakter
            //command.ExecuteNonQuery();//Koşulsuz bir şekilde sorguyu çalıştır
            //connection.Close();
            //Console.Write("Katgori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adı:");
            //productName=Console.ReadLine();
            //Console.Write("Ürün Fiyatı:");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=CAPER\\SQLEXPRESS;initial catalog=EgiimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TableProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();//Değişiklikleri kaydedip SQL tabanına gönderir
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data source=CAPER\\SQLEXPRESS;initial Catalog=EgiimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select *From TableProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);//SQL'den verileri çekerken köprü görevi görür
            //DataTable dataTable = new DataTable();//Verileri hafızaya alabilmek için geçici belleğe alabilmek için olan sınıf
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("silinecek ürün Id:");
            //int Productid=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=CAPER\\SQLEXPRESS;initial Catalog=EgiimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TableProduct Where Productid=@productid",connection);
            //command.Parameters.AddWithValue("@productid",Productid);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("silme başarıyla yapıldı");
            #endregion

            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellenecek ürün Id:");
            int Productid=int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek ürün adı:");
            string productName=Console.ReadLine();

            Console.Write("Güncellenecek ürün fiyatı:");
            decimal productPrice=decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data source=CAPER\\SQLEXPRESS;initial Catalog=EgiimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TableProduct Set ProductName=@productName,ProductPrice=@productPrice where Productid=@productid", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productid", Productid);
           command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Güncelleme başarılı!");
            #endregion
            Console.Read();
        }
    }
}
