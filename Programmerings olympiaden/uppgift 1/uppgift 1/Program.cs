using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många äpplen? ");
            int apple = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många päron?");
            int pears = int.Parse(Console.ReadLine());

            apple = apple * 7;
            pears = pears * 13;

            if(apple > pears)
            {
                Console.WriteLine("Axel tjänade mest");
            }
            else if (pears > apple)
            {
                Console.WriteLine("Petra tjänade mest");
            }
            else
            {
                Console.WriteLine("De tjänade lika mycket");
            }
            Console.ReadLine();
        }
    }
}
