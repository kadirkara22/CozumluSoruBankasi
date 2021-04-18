using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*soru: Contains ve Indexof metodlarını kullanarak
            bir dizi içerisinde arama işlemlerini gerçekleştiren programı yazınız.*/

            string[] spor = {"futbol","basketbol","voleybol","hentbol"};
            Console.WriteLine("seçeceğniz dalı seçiniz");
            string sporDal = Console.ReadLine();

            if (spor.Contains(sporDal)==true)
            {
                Console.WriteLine(Array.IndexOf(spor,sporDal)+1+" sırada seçtiğiniz alan bulundu");
            }
            else
            {
                Console.WriteLine("seçtiğiniz alan bulunamadı \n var olan spor dalları");

              
            }
            for (int i = 0; i < spor.GetLength(0); i++)
            {
                Console.WriteLine(spor.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}
