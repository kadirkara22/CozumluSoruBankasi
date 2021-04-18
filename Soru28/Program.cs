using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int sonuc = 0;
            if (sayi2<0)
            {
                sayi2 = -sayi2;
                sayi1 = -sayi1;
            }

            while (0<sayi2)
            {
                sonuc += sayi1;
                sayi2--;
            }
            
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
