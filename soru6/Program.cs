using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[6];
            Console.WriteLine("Oynamak istediğiniz kolon sayısını giriniz");
            int kolonAdet = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            if (kolonAdet>=1 && kolonAdet<=8)
            {
                for (int i = 0; i <= kolonAdet-1; i++)
                {
                    Console.WriteLine("{0}.kolon :", i+1);

                    for (int j = 0; j <= 5; j++)
                    {
                        dizi[j] = rnd.Next(1, 50);
                        Console.Write("{0}  ", dizi[j]);
                    }
                    Console.WriteLine();
                    Console.WriteLine(new string('*', 15));
                }
            }
            else
            {
                Console.WriteLine("en az 1 veya en fazla 8 kolon oynayabilirsiniz");
            }
            
            Console.ReadLine();
        }
    }
}
