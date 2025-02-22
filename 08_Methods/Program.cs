using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //() -> Bir şeyi metot yapan şey parantezlerinin kapalı olmasıdır
            // Özünde ikiye ayrılırlar 1-)Değer döndürmeyen metotlar
            //Customer--> Listele, ekle, sil, güncelle
            //Geriye değer döndürmeyen metotlar void olarak tanımlanıyor
            //Geriye değer döndürmeyen metotlar belirli işlemleri kurtarmak için programlamada önemli yere ve konuma sahiptir
            //

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 2;
            //    int y = 5;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void Customercard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri:" + name + " " + surName);

            //}
            //Customercard("Mehmet","Yıldız");
            //Customercard("Ayşegül","Kaya");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Fonksiyonlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(studentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)

            //{
            //    string cardInfo = "Ülke:" + countryName + "-Başkent:" + capital + "-Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke adını giriniz:");
            //x = Console.ReadLine();

            //Console.WriteLine("Başkenti giriniz:");
            //y = Console.ReadLine();

            //Console.WriteLine("bayrak rengini giriniz:");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(20, 90));
            //Console.WriteLine(Sum(36, 65));
            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result >=50)
            //    {
            //        return student + " İsimli öğrenci sınavı geçti" + "Ortalama:" + result;
            //    }
            //    else
            //    {
            //        return student + " İsimli öğrenci sınavı geçemedi" + "Ortalama:" + result;   
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 45, 81));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            #endregion

            Console.Read();
        }

    }
}
