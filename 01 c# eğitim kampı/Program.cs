using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__eğitim_kampı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırmakomutları
            // Console.WriteLine("Merhaba nasilsin?");
            // Console.WriteLine("Selam");
            // Console.WriteLine("******Yemek Katagorileri******");
            // Console.WriteLine();
            // Console.WriteLine("1-Çorbalar");
            // Console.WriteLine("2-Sıcak Yemekler");
            // Console.WriteLine("3-Soğuk içecekler");
            // Console.WriteLine("4-Tatlılar");
            // Console.WriteLine("5-İçecekler");
            // Console.WriteLine();
            // Console.WriteLine("******Yemek Katagorileri******");
            // Console.Read();
            #endregion
            #region Değişkenler
            // string değişkenler
            // Değişken_türü değişken_adı;
            // string name;
            // name = "Tülin";
            // Console.Write(name);
            //string dogalkaynaksuyu;
            //dogalkaynaksuyu = "Desni";
            //Console.Write(dogalkaynaksuyu);
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;
            customerName = "Tülin";
            customerSurname = "Geçer";
            customerPhone = "53744680851";
            customerEmail = "gecertulin1349@gmail.com";
            district = "Mutki";
            city = "Bitlis";
            Console.WriteLine("*******Rezervasyon Kartı******");
            Console.WriteLine();
            Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            Console.WriteLine("İletişim:" + customerPhone);
            Console.WriteLine("Email:" + customerEmail);
            Console.WriteLine("İlçe:" + district + "/" + city);
            #endregion
            #region Int Değişkenler
            int hamburgerPrice = 200;
            int waterPrice = 10;
            int friesPrices = 35;
            int pizzaPrice = 250;
            Console.WriteLine("**** Restoran Menu Fiyatı******");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı:" + hamburgerPrice+"TL");
            Console.WriteLine("-----Su fiyatı:" + waterPrice + "TL");
            Console.WriteLine("-----Pizza Fiyatı:" + pizzaPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menu Fiyatı ******");
            Console.WriteLine();
            int hamburgerCount;
            int pizzaCount;
            int waterCount;
            int friesCount;
            int totalhamburgerPrice = 0;

            hamburgerCount = 3;
            waterCount = 4;
            friesCount = 5;
            pizzaCount = 2;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            Console.WriteLine("------------------------");
            Console.WriteLine("Hamburger tutarı:" + totalhamburgerPrice + "TL");
            #endregion
            Console.Read();
        }
    }
}