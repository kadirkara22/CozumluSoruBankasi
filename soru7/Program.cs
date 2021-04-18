using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru: 3*3 'lük A ve B matrisleri klavyeden girilmektedir.Buna göre A ve B matrislerinin eşit olup olmadıklarını bulan programı yazınız.

            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int k = 0;
            //A matrisi
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("a[{0},{1}]=",i+1,j+1);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(new string('*',20));
            // B matrisi
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("b[{0},{1}]=",i+1,j+1);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("*** A Matrisi***");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,3}",a[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("***B matrisi***");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,3}",b[i,j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] != b[i, j])
                    {
                        Console.WriteLine("A ve B birbirine eşit değilidir");
                        k = 1;
                        break;
                    }
                }
                if (k==1)
                {
                    break;
                }
            }   
            
            if (k == 0)
            {
                Console.WriteLine("A ve B matrisleri birbirlerine eşittir");
            }
            Console.ReadLine();
        }
    }
}
