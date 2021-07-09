using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notes_sup_inf
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbnote, nbSup=0, nbInf = 0;
            Console.Write("saisissez le nombre de note: ");
            nbnote = int.Parse(Console.ReadLine());
            // declaration du tableau
            int[] notes = new int[nbnote];
            for (int i = 0; i < nbnote; i++)
            {
                Console.Write(" la notes n°"+(i+1)+ "=");
                notes[i] = int.Parse(Console.ReadLine());

                if (notes[i] > 10)
                {
                    nbSup++;
                }
                else nbInf++;
            }
            Console.WriteLine("le nombre de note sup à 10 est: "+ nbSup);
            Console.WriteLine("le nombre de note inf à 10 est: " + nbInf);

            Console.ReadKey();
        }
    }
}
