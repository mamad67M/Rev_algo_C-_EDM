using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prix_while
{
    class Program
    {
      
        /**
         * le saisie d'un prix
         * */
        public static char saisie( string message, char rep1 , char rep2)
        {
            char rep;
            do
            {
                Console.Write(message+" ("+rep1+"/"+rep2+"): ");
                rep = Char.Parse(Console.ReadLine());
            } while (rep != rep1 && rep != rep2);

            return rep;
        }
        static void Main(string[] args)
        {
            int prix, sum =0; char reponse;
            char rep1 = 'o';
            char rep2= 'n';
            string message = "avez vous un prix à saisir ? ";

            reponse = saisie(message, rep1, rep2);

            while (reponse == rep1)
            {
                Console.Write("saisissez un prix: ");
                prix = int.Parse(Console.ReadLine());
                sum += prix;
                
                reponse = saisie(message, rep1, rep2);
            }

            Console.WriteLine("la sum est: "+sum);
            Console.ReadKey();

        }
    }
}
