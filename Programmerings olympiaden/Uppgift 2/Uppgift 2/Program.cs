using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("format = xxxxxx(- eller +)xxxx");
            Console.Write("Personnummer: ");
            string prNum = Console.ReadLine();
            char tecken = prNum[6];
            prNum = prNum.Remove(6,1);
            if (tecken == '-')
            {
                int år = int.Parse(prNum.Remove(2,prNum.Length - 2));
                if(år > 20)
                {
                    Console.WriteLine("19"+prNum);
                }
                else
                {
                    Console.WriteLine("20" + prNum);
                }
            }
            else
            {
                int år = int.Parse(prNum.Remove(2, prNum.Length - 2));
                if (år < 00 || år > 20)
                {
                    Console.WriteLine("18" + prNum);
                }
                else
                {
                    Console.WriteLine("19" + prNum);
                }
            }
            Console.ReadLine();
        }
    }
}
