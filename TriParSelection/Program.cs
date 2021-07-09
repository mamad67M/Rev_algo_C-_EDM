using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriParSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbcase;
            // saisie du nombre de case de vecteur:
            Console.Write("nb case =  ");
            nbcase = int.Parse(Console.ReadLine());
            // declaration du vecteur
            int[] vec = new int[nbcase];
            for (int i = 0; i < nbcase; i++)
            {
                Console.Write("le nombre n°:"+(i+1)+" = ");
                vec[i] = int.Parse(Console.ReadLine());
            }
           
            // affichage du vecteur avant le tri
            Console.WriteLine("Affichage du vecteur avant le tri: ");
            for (int i = 0; i < nbcase; i++)
            {
                Console.Write(vec[i]+" ");
            }
            Console.WriteLine();
            // le tri
            //for (int i = 0; i < nbcase-1; i++)
            //{
            //    // memorisation de la case contenant la plus petite valeur
            //    int numcase = i;
            //    for (int j =i+1 ; j < nbcase; j++)
            //    {
            //        if (vec[j]<vec[numcase])
            //        {
            //            numcase = j;
            //        }
            //    }
            //    // echange car onvien de trouver la plus petite 
            //    int sav;
            //    sav = vec[numcase];
            //    vec[numcase] = vec[i];
            //    vec[i] = sav;

            //    // affichage après le tri
            //    Console.WriteLine();
            //    for (int k = 0; k < nbcase; k++)
            //    {
            //        Console.Write(vec[k] + " ");
            //    }
            //}

            // le tri
            Console.WriteLine("affichage après le tri");
            for (int i = 0; i < nbcase-1; i++)
            {
                // memorisation de la case contenant la plus petite valeur
                int numcase = i;
                for (int j = i+1; j < nbcase; j++)
                {

                    if (vec[j]<vec[numcase])
                    {
                        numcase = j;
                    }

                    int sav;
                    sav = vec[i];
                    vec[i] = vec[numcase];
                    vec[numcase] = sav;
                    // affichage après le tri
                    Console.WriteLine();
                  
                    for (int k = 0; k < nbcase; k++)
                    {
                        Console.Write(vec[k] + " ");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
