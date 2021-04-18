using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            int toplam = 0;
            int sayac = 0;
            Random rnd = new Random(0);
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = rnd.Next(1,1001);
                
            }
            for (int i = 0; i < 10; i++)
            {
                if (dizi[i]>=500 && dizi[i]<=600)
                {
                    toplam += dizi[i];
                }


                if (dizi[i]>=100 && dizi[i]<=500)
                {
                    sayac++;
                }
            }
            Console.WriteLine("500 ile 600 arasındaki sayıların toplamı : {0}",toplam);
            Console.WriteLine("100 ile 500 arasındaki sayıların adedi : {0}",sayac);


            Console.ReadLine();
        }
    }
}
