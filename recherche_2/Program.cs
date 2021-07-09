using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recherche_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbtemp, min, max ;

            Console.Write(" nb temp est: ");
            nbtemp = int.Parse(Console.ReadLine());

            Console.Write(" la premiere temp est = ");
            min = max = int.Parse(Console.ReadLine());
            
            int[] temp = new int[nbtemp];
            for (int i = 0; i < nbtemp; i++)
            {
                Console.Write("saisissez la temp n°" + (i + 2) + " =");
                temp[i] = int.Parse(Console.ReadLine());
                if (temp[i] < min)
                {
                    min = temp[i];
                }
                if (temp[i] > max)
                {
                    max = temp[i];
                }
            }
            Console.WriteLine("max =" + max);
            Console.WriteLine("min =" + min);


            Console.ReadKey();
        }
    }
}
