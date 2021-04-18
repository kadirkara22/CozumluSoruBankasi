using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayfa56soru27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sayifak = 1;

            if (sayi>=0)
            {
                while (i <= sayi)
                {
                    sayifak *= i;
                    i++;
                }
               
            }
            else
            {
                Console.WriteLine("Negatif sayıların fatöriyeli olmaz");
            }
            Console.WriteLine("{0} sayısının faktöriyeli : {1}",sayi,sayifak);
            Console.ReadLine();
        }
    }
}
