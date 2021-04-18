using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9
{
    class Program
    {
        static void Main(string[] args)
        {
            // soru :n*n 'lik birim matrisi oluşturan matrisi yazın.

            Console.WriteLine("matrisin boyutunu giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] dizi = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==j)
                    {
                        dizi[i, j] = 1;
                    }
                    else
                    {
                        dizi[i, j] = 0;
                    }
                    
                }
            }
            Console.WriteLine("***Birim matrisi***");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}",dizi[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
