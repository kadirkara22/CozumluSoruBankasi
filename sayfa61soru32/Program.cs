using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayfa61soru32
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int k = 0;
            int sayıadeti = 1;
            do
            {
                Console.WriteLine(" "+sayıadeti+".sayıyı giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi>=100 &&sayi<1000 || sayi>-1000 && sayi<=-100)
                {
                    k++;  
                }
                sayıadeti++;
            } while (sayıadeti <= 10);

            Console.WriteLine("{0} tane 3 basamaklı sayı vardır",k);
            Console.ReadLine();
        }
    }
}
