using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma
            //for(int i=1;i<=10;i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion
            #region Yan yana 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion
            #region Alt alta 10 tne yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("************");
            //}
            #endregion
            #region Dik Üçgen
            //for(int i=1;i<=5;i++)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Ters Dik Üçgen
            //for(int i=5;i>=1;i--)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region  dik ve Ters Üçgen Beraber
            //for(int i=1;i<=10;i++)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int a=9;a>=1;a--)
            //{
            //    for(int b=1;b<=a;b++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Baklava Dilimi
            //int n = 5;
            //for(int i=1;i<=n;i++)
            //{
            //    for(int j=n-1;j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1;k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////alt kısım
            //for(int i=n-1;i>=1;i--)
            //{
            //    for(int j=n-1;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1;k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Piramit
            //int n = 5;
            //for(int i=1;i<=n;i++)
            //{
            //    //Boşluklar için
            //    for(int j=n-i;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //Yıldızlar için
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Ters Piramit
            int n = 5;
            for(int i=n;i>=1;i--)
            {
                //Boşluklar
                for(int j=n-i;j>0;j--)
                {
                    Console.Write(" ");
                }
                //Yıldızlar
                for(int k=1;k<=2*i-1;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
