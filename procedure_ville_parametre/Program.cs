using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procedure_ville_parametre
{
    class Program
    {
      /**
       * methode de suppression d'une valeur
       */
        public static int supVect(string[] vec, string v)
        {
            // parcourt pour chercher la ville à supprimer
            int k = 0;
            while (k<vec.Length-1 && v != vec[k])
            {
                k++;
            }
            // controle de sortie de boucle
            if(vec[k] == v)
            {
                // suppression de la case contenant la valeur
                for (int j =k ; j  <vec.Length-1; j =k++)
                {
                    vec[j] = vec[j + 1];
                }
                // retour à la nouvelle taille
                return vec.Length - 1;
            }
            return vec.Length;
        }
        
        
        static void Main(string[] args)
        {
            int nbville;
            string villeChercher;
            Console.Write("nombre de ville: ");
            nbville = int.Parse(Console.ReadLine());
            // Tableau de ville
            string[] villes = new string[nbville];
            for (int i = 0; i < nbville; i++)
            {
               Console.Write(" ville n° "+(i+1)+" = ");
                villes[i] = Console.ReadLine();
            }
            // saisi de la ville à chercher
            Console.Write("nom de ville à supprimer: ");
            villeChercher = Console.ReadLine();
            nbville = supVect(villes, villeChercher);
            for (int i = 0; i < nbville; i++)
            {
                Console.WriteLine("la ville n°"+(i+1)+ " = "+ villes[i]);
            }
           
            Console.ReadKey();
        }
    }
}
