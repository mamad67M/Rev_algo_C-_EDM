using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recherche_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbnote , min = 20, max = 0;
            Console.Write("saisissez le nombre de note = ");
            nbnote = int.Parse(Console.ReadLine());
            int[] note = new int[nbnote];
            for (int i = 0; i < nbnote; i++)
            {
                Console.Write("saisissez le note n°"+(i+1)+ " =");
                note[i] = int.Parse(Console.ReadLine());
                if (note[i] <min)
                {
                    min = note[i];
                }
                if (note[i]> max)
                {
                    max = note[i];
                }
            }
            Console.WriteLine("max ="+ max);
            Console.WriteLine("min =" + min);

            Console.ReadKey();
        }
    }
}
