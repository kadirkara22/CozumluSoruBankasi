using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             soru: LastIndexOf metodunu kullanarak bir dizi içerisinde arama
            işlemini yapan programı yazınız.
             */
            string[] ogrenciler = {"kadir","sezer","türker","ahmet","timur"};

            Console.WriteLine("aramak istediğiniz öğrencinin adını giriniz");
            string ogrenci = Console.ReadLine();

            if (ogrenciler.Contains(ogrenci)==true)
            {
                Console.WriteLine(Array.LastIndexOf(ogrenciler,ogrenci)+1+ ". sıradaki öğrenci");
            }
            else
            {
                Console.WriteLine("aramak istediğiniz öğrenci bulunamadı \n\n listemizdeki öğrenciler");
            }
            Console.WriteLine("**********");
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                Console.WriteLine(ogrenciler.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}
