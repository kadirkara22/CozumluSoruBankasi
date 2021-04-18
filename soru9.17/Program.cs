using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._17
{
    class Program
    {
        static void Main(string[] args)
        {/*
          Arraylist sınıfınfından bir dizi oluşturduktan sonra sort metodu ile dizi
            içerisindeki bilgileri sıralayan,Reverse metodu ile ters çeviren  ve count metodu ile de dizinin elaman sayısını bulan programı yazınız.
          */
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(10);
            arrayList.Add(99);
            arrayList.Add(45);
            arrayList.Add(-5);

            Console.WriteLine("dizi elemanları");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***************");
            Console.WriteLine("Sort metodu kullandıktan sonra");
            arrayList.Sort();
            int adet = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
                adet++;
            }
            Console.WriteLine($"adet: {adet}");
            Console.WriteLine("***************");
            Console.WriteLine("Reverse metodu kullandıktan sonra");
            arrayList.Reverse();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
              
            }
            Console.ReadLine();
        }
    }
}
