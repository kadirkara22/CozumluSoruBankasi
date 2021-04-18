using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayfa63soru34
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =1;
            int toplam = 0;
            int sayac = 1;
            int n = 1;
            Console.WriteLine("Lütfen bir sayı giriniz");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                
                Console.Write(sayac);
                toplam += (a * sayac);
                a = a * (-1);
                if (a==-1)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("+");
                }
                sayac++;

            } while (sayac<=n);
            Console.WriteLine("="+ toplam);

            Console.ReadLine();
        }
    }
}
