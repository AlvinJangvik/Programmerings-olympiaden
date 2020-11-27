using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pris: ");
            int pris = int.Parse(Console.ReadLine());
            int sedlar = 0;
            string choices = "1111111111";
            while (true)
            {
                if(pris - int.Parse(choices) >= 0)
                {
                    sedlar++;
                    pris -= int.Parse(choices);
                }
                else
                {
                    choices = choices.Remove(choices.Length - 1, 1);
                }

                if (pris == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sedlar);
            Console.ReadLine();
        }
    }
}
