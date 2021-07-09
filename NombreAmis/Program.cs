using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreAmis
{

    class Program
    {
        /**
       * la fonction saisie
       */
        public static char Saisie(string message, char n1, char n2)
        {

            char reponse;
            do
            {
                Console.Write(message, n1, n2);
                reponse = char.Parse(Console.ReadLine());
            } while (reponse == 'o');
            return reponse;
        }

        /**
        * fonction qui retourne la somme d'un nombre
        */
        public static int sommeChiffre(int nombre)
        {
            int somme = 0;
            while (nombre != 0)
            {
                somme += nombre % 10;
                nombre /= 10;
            }
            return somme;
        }

        /**
       * fonction amie
       */
        public static bool Amis(int n1, int n2)
        {
            return (sommeChiffre(n1) == sommeChiffre(n2));
           
        }

        static void Main(string[] args)
        {
            int a, b;
            char reponse, r1 = 'y', r2 = 'n';
            string message = "Avez vous 2 nombres à comparer? ";
            do
            {
                Console.Write("saisissez le premier nombre: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("saisissez le second nombre: ");
                b = int.Parse(Console.ReadLine());
                if (Amis(a, b))
                {
                    Console.WriteLine("les nombres " + a + " et " + b + " sont amis: ");
                }
                else { Console.WriteLine("les nombres " + a + " et " + b + " ne sont pas amis: "); }

             reponse =  Saisie(message, r1, r2);
            } while (reponse == 'y');
           
            Console.ReadKey();
        }
    }
}
