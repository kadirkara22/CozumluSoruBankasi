using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._20
{
    class Program
    {
        static void Main(string[] args)
        {/*
          Arraylist sınıfınfından bir dizi oluşturduktan sonra CopyTo, clone ve ToArray
            metotlarının kullanıldığı programı yazınız.
          */
            Array arabalar = Array.CreateInstance(typeof(string), 7);
            arabalar.SetValue("opel",0);
            arabalar.SetValue("bmw",1);
            arabalar.SetValue("ford",2);
            arabalar.SetValue("toyota",3);
            arabalar.SetValue("reno",4);
            arabalar.SetValue("kartal",5);
            arabalar.SetValue("seat",6);

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");
            ArrayList yeniArabalar = new ArrayList();
            yeniArabalar.Add("mercedes");
            yeniArabalar.Add("ferrari");
            yeniArabalar.CopyTo(arabalar, 3);
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");

           ArrayList yedekarabalar=(ArrayList)yeniArabalar.Clone();
            foreach (var item in yedekarabalar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");
           string[] yeniAraba=(string[])yedekarabalar.ToArray(typeof(string));
            foreach (var item in yeniAraba)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********************");


            Console.ReadLine();
        }
    }
}
