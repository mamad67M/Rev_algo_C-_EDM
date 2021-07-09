using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suite_numerique
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeur, ancValeur;
            char rep;
            bool croissant = true;
            Console.Write("saisissez une valeur: ");
            ancValeur = int.Parse(Console.ReadLine());
            Console.Write(" avez vous une valeur à saisir o/n ");
            rep = char.Parse(Console.ReadLine());
            while (rep == 'o')
            {
                Console.Write("saisissez une valeur: ");
                valeur = int.Parse(Console.ReadLine());
                if (valeur <ancValeur)
                {
                    croissant = false;
                    ancValeur = valeur;
                }

                Console.Write("autres valeur: ");
                rep= char.Parse(Console.ReadLine());
            }
            if (croissant) { Console.WriteLine("la suite est croissante "); }
            else Console.WriteLine("la suite est décroissante ");
            Console.ReadKey();
        }
    }
}
