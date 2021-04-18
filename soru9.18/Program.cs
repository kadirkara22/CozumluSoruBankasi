using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._18
{
    class Program
    {
        static void Main(string[] args)
        {/*
          Arraylist sınıfınfından bir dizi oluşturduktan sonra Remove, RemoveAt ve Clear
            metotlarını kullanarak program yazınız
          */
            ArrayList arrayList = new ArrayList();
            arrayList.Add("turker");
            arrayList.Add(10);
            arrayList.Add("numara");
            arrayList.Add("adamdır");
            arrayList.Add("ve");
            arrayList.Add("oğlunun");
            arrayList.Add("adı");
            arrayList.Add("Timur");

            Console.WriteLine("arraylist dizisinin elemanları");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Remove("ve");
            arrayList.RemoveAt(5);
            Console.WriteLine("Remove ve RemoveAt metotlarından sonra dizi");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Clear();
            Console.WriteLine("Clear  metotlarından sonra dizi");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
