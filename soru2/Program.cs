using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            int i,j,gec;
            for (i = 0; i <5; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz",i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
       
            for (i = 0; i < 4; i++)
            {
                for (j = i+1; j < 5; j++)
                {
                    if (dizi[i]<dizi[j])
                    {
                        gec = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = gec;
                    }
                }

            }
            Console.WriteLine();
            for ( i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}.sayı : {1}",i+1,dizi[i]);
            }




            Console.ReadLine();
        }
    }
}
