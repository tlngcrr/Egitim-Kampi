using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Datebaseproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net --> C# programlama dilinde sql yapılarını kallnabilmemize olanak sağlayan bir çerçevedir
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Katgori Bilgi Sitemi *****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasıını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            SqlConnection connection = new SqlConnection("Data source=CAPER\\SQLEXPRESS;initial catalog=EgiimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory",connection);// Sorgu yapar.Bu tablo hangi veritabannda olduğunu bildirmek için yanına connection verilir
            SqlDataAdapter adapter = new SqlDataAdapter(command);  //Yanına bir nesne oluşturup command ile birlikte çalışsın dedik.C# kodları ile sql arasında bir köprü görevi görsün dedik
            DataTable dataTable = new DataTable(); //Datatable burda verilerimizin belleğe alınmasını sağlar.Geçiic belleğe alır
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
