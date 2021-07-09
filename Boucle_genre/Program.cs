using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_genre
{
    class Program
    {
        public static char Saisie(string message, char car1, char car2)
        {

            char genre;
            do
            {
                Console.Write(message + " (" + car1 + "/" + car2 + "): ");
                genre = char.Parse(Console.ReadLine());
            } while (genre != car1 && genre != car2);
            return genre;
        }
        static void Main(string[] args)
        {
            char sex, c1 = 'H', c2 = 'F';
            string message = "saisissez votre sex: ";
            sex = Saisie(message, c1, c2);

            Console.WriteLine();

            if (sex == c1)
            {
                Console.WriteLine("Bonjour Monsieur");
            }
            else
            {
                Console.WriteLine("Bonjour Madame");
            }

            Console.ReadKey();
        }
    }
}
