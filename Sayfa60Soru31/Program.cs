using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayfa60Soru31
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                i++;
                double sonuc = Math.Log10((double)i);
                Console.WriteLine("{0:F2}",sonuc);
            } while (i<10);
            Console.ReadLine();
        }
    }
}
