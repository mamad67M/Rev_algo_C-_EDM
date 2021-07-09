using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChercherNombre
{
    class Program
    {
       /**
        * la fonction saisie
        */
        public static int Saisie(string message, int inf, int sup)
        {

            int nombre ;
            do
            {
                Console.Write(message +" entre "+ inf + " et " + sup +":  ");
                nombre = int.Parse(Console.ReadLine());
            } while (nombre < 0 || nombre > 100);
            return nombre;
        }
        static void Main(string[] args)
        {
            int valeur, essai,  compteur = 1;
            int bornInf = 0;
            int bornSup = 100;

            valeur =  Saisie("Entrez une valeur à chercher",bornInf, bornSup);

            Console.Clear();

            essai =  Saisie("Entrez un essai ", bornInf, bornSup);

            while (essai != valeur)
            {
                //Console.Write(" saisissez un essai: ");
                //essai = int.Parse(Console.ReadLine());
                if (essai > valeur)
                {
                   Console.WriteLine(" trop grand: ");
                }
                else 
                {
                   Console.WriteLine(" trop petit: ");

                }

                essai = Saisie("Entrez un essai ", bornInf, bornSup);

                compteur++;
            }

            Console.WriteLine("Bravo ! vous avez trouver en: "+ compteur + " fois");

            Console.ReadLine();
        }
    }
}
