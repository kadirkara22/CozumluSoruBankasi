using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Arraylist sınıfınfından bir dizi oluşturduktan sonra,
             * Add ve Insert metotlarını kullanarak diziye yeni değerler ekleyin.*/

            ArrayList arrayList = new ArrayList();
            arrayList.Add("turker");
            arrayList.Add(10);
            arrayList.Add("numara");
            arrayList.Add("adamdır");
            
            Console.WriteLine("arraylist dizisinin add metotduyla kullanımından sonra elamanları");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Insert(1,"cansu");

            Console.WriteLine("arraylist dizisinin Insert metoduyla kullanımdan sonra elemanları");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
