using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayfa59soru30
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double bsin, bcos, btan, bcot;
            char c;
            do
            {
                Console.WriteLine("açı değeri giriniz");
                a = Convert.ToInt32(Console.ReadLine());
                bsin = Math.Sin((double)a * 3.14 / 180);
                bcos = Math.Cos((double)a * 3.14 / 180);
                btan = Math.Tan((double)a * 3.14 / 180);
                bcot = bcos / bsin;
                Console.WriteLine("{0} sinüsü : {1:F2}",a,bsin);
                Console.WriteLine("{0} cosünüsü : {1:F2}",a,bcos);
                Console.WriteLine("{0} tanjantı : {1:F2}",a,btan);
                Console.WriteLine("{0} kotanjantı : {1:F2}",a,bcot);
                Console.WriteLine("devam etmek istiyor musunuz (e/h)");
                c = Convert.ToChar(Console.ReadLine());
            } while (c=='e'||c=='E');
            Console.ReadLine();
        }
    }
}
