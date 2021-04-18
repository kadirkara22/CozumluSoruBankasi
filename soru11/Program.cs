using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "araba", "kedi", "ankara", "istanbul", "köpek", "deniz" };
            Console.WriteLine("dizimizdeki değerler");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("[{0,1}]  :{1}",i+1,dizi[i]);
            }


            Array.Resize(ref dizi, dizi.Length + 5);

            Console.WriteLine("dizimizin boyutunu artırdığımızda dizinin içindeki değerler");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("[{0,1}]  :{1}", i + 1, dizi[i]);
            }

            Array.Resize(ref dizi, 4);
            Console.WriteLine("dizimizin boyutunu azalttığımızda dizinin içindeki değerler");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("[{0,1}]  :{1}", i + 1, dizi[i]);
            }
            Console.ReadLine();
        }
    }
}
