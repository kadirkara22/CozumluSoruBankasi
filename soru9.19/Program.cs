using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._19
{
    class Program
    {
        static void Main(string[] args)
        {/*
          Arraylist sınıfınfından bir dizi oluşturduktan sonra GetRange, AddRange,InserRange, ve RemoveRange
            metotlarının kullanıldığı program yazınız.
          */
            ArrayList arabalar = new ArrayList();
            arabalar.Add("opel");
            arabalar.Add("bmw");
            arabalar.Add("ford");
            arabalar.Add("toyota");
            arabalar.Add("reno");
            arabalar.Add("kartal");
            arabalar.Add("seat");

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");
         ArrayList arrayList=arabalar.GetRange(3, 4);
            //getrange => kaçıncı indexten başladığını ve ne kadar gitmesini belli eder ve arraylist döndürür.

            Console.WriteLine("GetRange metodu");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");
            ArrayList yeniArabalar = new ArrayList();
            yeniArabalar.Add("mercedes");
            yeniArabalar.Add("ferrari");
            yeniArabalar.Add("fiat");
            yeniArabalar.Add("honda");

            arabalar.AddRange(yeniArabalar);

            Console.WriteLine("addrange metodu");

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");
            ArrayList ekyeniArabalar = new ArrayList();
            ekyeniArabalar.Add("volkswagen");
            ekyeniArabalar.Add("enter");
            arabalar.InsertRange(3, ekyeniArabalar);
            Console.WriteLine("InsertRange metodu");
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");
            arabalar.RemoveRange(5, 4);
            Console.WriteLine("RemoveRange metodu");
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");
            Console.ReadLine();
        }
    }
}
