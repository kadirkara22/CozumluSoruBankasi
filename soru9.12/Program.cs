using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9._12
{
    class Program
    {
        /*
         soru : bir okulda bulunan bölümlerle ilgili programda dizideğişkenlerine ait olan CreateInstance metodu, SetValue metodu,
        getValue metodu ve copy metodlarını kullanan programı yazınız.
         */
        static void Main(string[] args)
        {
            Array bolumler = Array.CreateInstance(typeof(string), 5);
            string[] bolum = (string[])bolumler;
            string[] bolum2 = new string[3];
            bolum[0] = "inşaat";
            bolum[1] = "gemi";
            bolum[2] = "makine";
            bolum[3] = "bilgisayar";
            bolum[4] = "kimya";

            for (int i = 0; i < bolum.GetLength(0); i++)
            {
                Console.WriteLine(bolum.GetValue(i));
            }
            Console.WriteLine("*******************");
            bolum.SetValue("harita", 2);
            Console.WriteLine("setvalue komutundan sonra");
            for (int i = 0; i < bolum.GetLength(0); i++)
            {
                Console.WriteLine(bolum.GetValue(i));
            }

            Console.WriteLine("*******************");
            Array.Copy(bolum, bolum2, 3);
            Console.WriteLine("kopyalandıktan sonra");
            for (int i = 0; i < bolum2.GetLength(0); i++)
            {
                Console.WriteLine(bolum2.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}
