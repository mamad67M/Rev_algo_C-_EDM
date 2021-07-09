using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonction_moy_note
{
    class Program
    {
        public static double MoyNotes(double[] vec)
        {
            double sum = 0;
            for (int i = 0; i < vec.Length; i++)
            { 
                sum += vec[i];
            }
            double moy = sum / vec.Length;

            return moy;
        }
        static void Main(string[] args)
        {
            Console.Write(" saisissez le nombre de note: ");
            int nbNote = int.Parse(Console.ReadLine());
            double[] vec = new double[nbNote];
            for (int i = 0; i < nbNote; i++)
            {
                Console.Write("la note n° " + (i + 1) + " = ");
                vec[i] = double.Parse(Console.ReadLine());

                    double sum = 0;
                    sum += vec[i];
            }

            Console.WriteLine("la moyenne des note est: " + MoyNotes(vec));
            Console.ReadKey();
        }
    }
}
