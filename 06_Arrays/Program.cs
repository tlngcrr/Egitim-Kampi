﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2.4.6.8
            //sarı,kırızı,mavi,turuncu,beyaz
            //adana,ankara,bursa,istanbul
            //DeğişkenTürü [] DiziADı=new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);
            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[4]);
            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 23;
            //numbers[2] = 12;
            //numbers[3] = 45;
            //numbers[4] = 9;
            //numbers[8] = 10;
            //Console.WriteLine(numbers[9]);
            //string[] cities = { "Roma", "Üsküp", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);
            #endregion
            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for(int i=0;i<colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 74, 125, 635, 488, 520, 7456, 2365, 1120 };
            //for(int i=0;i<numbers.Length;i++)
            //{

            //    if(i%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i=0;i<symbols.Length;i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for(int i=0;i<myArray.Length;i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            //string[] persons = { "ali", "ahmet", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);//Tersten sıralama yapar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region Dizi Metotları
            //aradığımız değerin kaçıncı indexte olduğunu bulur
            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("dizinin en büyük elemanı:" + numbers.Max() + "dizinin en küçük elemanı:" + numbers.Min());

            #endregion
            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for(int i=0;i<cities.Length;i++)
            //{
            //    Console.Write($"Lütfen{i + 1}. şehri giriniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //for(int i=0;i<cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            int[] numbers = { 2, 42, 43, 64, 55, 66, 897, 748, 39, 220 };
            Console.WriteLine("Çift sayılar");
            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("---------");
            Console.WriteLine("Tek Sayılar");
            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i]%2==1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion
        }

    }
}
