using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayfa53Soru24
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz");
                i = Convert.ToInt32(Console.ReadLine());
                if (i==0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("girilen sayı : {0}",i);
                    Console.WriteLine("girilen sayının karesi : {0}",i*i);
                }
            }
            Console.ReadLine();
        }
    }
}
