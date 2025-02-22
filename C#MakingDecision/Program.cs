using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}
            //string capital, country;
            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if(capital=="ankara"&country=="türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");

            //}
            //int number;
            //Console.Write("Sayıyı giriniz:");
            //number = int.Parse(Console.ReadLine());
            //if(number==7)
            //{
            //    Console.Write("Girdiğiniz sayı doğru");
            //}
            //else
            //{
            //    Console.Write("Girdiğiniz sayı yanlıştır");
            //}

            //double exam1, exam2, exam3, average;
            //string result = "Hata";
            //Console.Write("Sınav1:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması:" + average);
            //if(average>0&average<=50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(average>50&average<=70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(average>70&average<=84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if(average>84&average<=100)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişini yapınız:");
            //city = Console.ReadLine();
            //if(city=="adana"|city=="bursa"|city=="ankara"|city=="trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.WriteLine("LÜtfen kullanıcı adınızı giriniz:");
            //string username = Console.ReadLine();
            //if(username!="admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez:");
            //}
            //else
            //{
            //    Console.Write("Hoş geldniz:");
            //}

            #endregion
            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Write("Lütfen birinci sayı giriniz:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("Birinci sayının ikinci sayının bölümünden kalan değer:" + result);
            //Console.Write("Lütfen birinci sayıyı giriniz:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //if(result==0)
            //{
            //    Console.Write("Birinci ikinci sayıya tam bölünür.");
            //}
            //else
            //{
            //    {
            //        Console.Write("Birinci sayı ikinci ayıya tam bölünmez");
            //    }
            //}
            // Console.Write("Lütfen  sayıyı giriniz:");
            // int number = int.Parse(Console.ReadLine());
            //if(number%2==0)
            // {
            //     Console.Write("Giridiğiniz sayıçift sayıdır.");
            // }
            // else
            // {
            //         Console.Write("Girdiğiniz sayı tek sayıdır.");           
            // }
            #endregion
            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz:");
            //team = char.Parse(Console.ReadLine());
            //if (team=='G'|team=='g')
            //{
            //    Console.Write("Takım Galatasaraydır.");
            //}
            //if(team=='F'| team=='f')
            //{
            //    Console.Write("Takım fenerbahçedir.");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.Write("Takım beşiktaştır.");
            //}
            #endregion
            #region Örnek Proje Uygulaması
            //Console.WriteLine("******C# Eğitim Kampı Restoran******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------------");

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menüyü seçiniz:");
            //menuItem = Console.ReadLine();
            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma tabağı");
            //    Console.WriteLine("3-fasulye pilav");
            //    Console.WriteLine("4-Fırında somon");
            //    Console.WriteLine("5-Patlıcan musakka");
            //}
            //if(menuItem=="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Çorbalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Pizzalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------İçecekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Tatlılar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //}
            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen ay girişi yapınız:");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("hatalı veri girişi");break;
            #endregion
            #region Switch Case Hesap Makinesi
            int number1, number2, result;
            char symbol;
            Console.Write("Birinci sayıyı giriniz:");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen yapmak istediğniz işlemi giriniz:");
            symbol = char.Parse(Console.ReadLine());
            switch(symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.Write("Toplam:" + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.Write("Fark:" + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.Write("Çarpma:" + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.Write("Bölme:" + result);
                    break;
                default: Console.Write("Girdiğiniz işlem geçersizdir.");
                    break;
            }
            #endregion
            Console.Read();
        }
    }
}
