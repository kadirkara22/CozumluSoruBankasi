using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayfa54Soru25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int toplam = 0;
            while (i<=100)
            {
                
                toplam += i;
                i++;
            }
            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı: {0}",toplam);
            Console.ReadLine();
        }
    }
}
