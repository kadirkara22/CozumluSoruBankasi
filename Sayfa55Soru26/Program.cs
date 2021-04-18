using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayfa55Soru26
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int i = 0;
            Console.WriteLine("Sayı aralığı için ilk sayı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı aralığı için ilk sayı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1>sayi2)
            {
                i = sayi1;
                sayi1 = sayi2;
                sayi2 = i;
            }
            while (sayi1<=sayi2)
            {
                toplam += sayi1;
                sayi1++;
            }
            
            Console.WriteLine("sayıların toplamı: {0}",toplam);
            Console.ReadLine();
        }
    }
}
