using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            int sayac = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz : ",i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (dizi[i]%10==0)
                {
                    sayac++;
                }
            }
            Console.WriteLine("sonu 0 olan {0} tane sayı vardır",sayac);


            Console.ReadLine();
        }
    }
}
