using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Strcture
{
    class Program
    {
        struct Etudiant
        {
            public string nom;
            public int moy;
        }
        static void Main(string[] args)
        {
            int nbEtu, sum = 0;
            Console.Write("saisissez le nombre d'étudiant: ");
            nbEtu = int.Parse(Console.ReadLine());
            Etudiant[] etu = new Etudiant[nbEtu];
            for (int i = 0; i < nbEtu; i++)
            {
                Console.Write("le nom de étudiant n° "+(i+1)+" = ");
                etu[i].nom = Console.ReadLine();
                Console.Write("la moy de étudiant n° " + (i + 1) + " = ");
                etu[i].moy = int.Parse(Console.ReadLine());
                sum += etu[i].moy;
            }
            // calcula de la moyenne de la classe
            int moyClass = sum / nbEtu;
            Console.WriteLine("les etudiants dont la note est superieur à "+moyClass+" sont: ");
            for (int i = 0; i < nbEtu; i++)
            {
                if (etu[i].moy> moyClass)
                {
                    Console.WriteLine(etu[i].nom);
                }
            }
            Console.ReadKey();
        }
    }
}
