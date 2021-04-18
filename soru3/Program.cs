using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = new string[5];
            string isim;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. ismi giriniz : ", i + 1);
                dizi[i] = Console.ReadLine();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (string.Compare(dizi[i],dizi[j])>0 )
                    {
                        isim = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = isim;
                    }
                    
                }
            }
            Console.WriteLine("alfabetik ayarlama yapıldıktan sonra");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}.isim : {1}",i+1,dizi[i]);

            }

            Console.ReadLine();
        }
    }
}
