using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             soru: BinarySearch metodunu kullanarak bir dizi içerisinde arama işlemini gerçekleştiren programı yazınız.(not: eğer dizi elemanları sıralı değilse bulunamaz, bulunabilmesi için artan bir sıralama olması gerekir.)
             */

            string[] isimler = {"kadir","türker","sezer","mustafa","can","ramazan","ali"};

            Console.Write("aramak istediğiniz ismi giriniz : ");
            string isim = Console.ReadLine();
            string geciciIsim;
            Console.WriteLine("***************");
            // karakter sayısına göre sıralma
            Console.WriteLine("karakter sayısına göre sıralama");
            for (int i = 0; i < isimler.Length; i++)
            {
                for (int j = i+1; j < isimler.Length; j++)
                {
                    if (isimler[i].Length >= isimler[j].Length)
                    {
                        geciciIsim = isimler[i];
                        isimler[i] = isimler[j];
                        isimler[j] = geciciIsim;
                    }
                }
            }

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.WriteLine("***************");
            //ilk harfe göre a'dan z'ye sıralama
            Console.WriteLine("ilk harfe göre a'dan z'ye sıralama");
            Array.Sort(isimler);

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.WriteLine("***************");
            int bulunacakisim = Array.BinarySearch(isimler, isim);
            if (bulunacakisim>=0)
            {
                Console.WriteLine("aradığınız isim bulundu");
            }
            else
            {
                Console.WriteLine("aradığınız isim bulunamadı");
            }
            Console.ReadLine();
        }
    }
}
