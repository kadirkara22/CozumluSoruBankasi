using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayfa62soru33
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 2;
            
            Console.WriteLine("1.sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int a = sayi1;
            int enbuyuk = a;
            do
            {
                Console.WriteLine("{0}.sayıyı giriniz",sayac);
                int i = Convert.ToInt32(Console.ReadLine());
                if (i > enbuyuk)
                    enbuyuk = i;
                sayac++;
            } while (sayac<=10);
            Console.WriteLine("en büyük sayı : "+enbuyuk);

            Console.ReadLine();
        }
    }
}
