using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N ");
            long antal = int.Parse(Console.ReadLine()) - 1; // Antal öar
            long[] öar = new long[antal];
            Console.WriteLine();

            Console.Write("K ");
            long paddeltag = int.Parse(Console.ReadLine()); // Antal padeltag per paddel
            Console.WriteLine();

            Console.Write("H ");
            string tempS = Console.ReadLine();
            long hMeter = Int64.Parse(tempS); // Antal meter i häxameter
            Console.WriteLine();

            for(int i = 0; i < antal; i++)
            {
                Console.WriteLine();
                int show = i + 1;
                Console.Write("d" + show + " ");
                öar[i] = int.Parse(Console.ReadLine());
            }

            long paddlar = 0;
            long[] önInnan = new long[antal];
            long[] önLängd = new long[antal];
            long[] extraPaddel = new long[antal];
            if (antal > 1) // ifall de är mer en 1 ö
            {
                for (int i = 0; i < antal; i++)
                {
                    if (i + 1 < antal)
                    {
                        önInnan[i] = (hMeter * öar[i + 1]) / paddeltag;
                    }
                    önLängd[i] = (öar[i] * hMeter) - (önInnan[i] * 6);
                    if ((önLängd[i] * 7) - (öar[i] * hMeter) > 0)
                    {
                        extraPaddel[i] = 1;
                    }

                    if (i + 1 >= antal - 1)
                    {
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                for (int i = 0; i < antal; i++)
                    paddlar += ((önLängd[i] / paddeltag) + extraPaddel[i]) + önInnan[i];
            }
            else
            {
                paddlar += (hMeter * öar[0]) / paddeltag;
            }

            Console.WriteLine(paddlar);
            Console.ReadLine();
        }
    }
}
