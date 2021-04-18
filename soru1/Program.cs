using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] dizi = new int[17];
            int i;
            int max;
            for (i = 0; i < 17; i++)
            {
                Console.Write("{0}.sayıyı giriniz :",i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = dizi[0];
            for (i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > max)
                {
                   max=dizi[i];
                }
                
            }
            Console.WriteLine("En büyük sayı : {0}", max);

            Console.ReadLine();
        }
    }
}
