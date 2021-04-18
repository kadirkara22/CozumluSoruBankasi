using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru29
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Sayı   karesi   küpü");
            Console.WriteLine(new string('*',20));


            do
            {
                
                Console.WriteLine("{0,2}      {1,3}    {2,4} ",i,i*i,i*i*i);

                i++;
            } while (i<=10);

            Console.ReadLine();
        }
    }
}
