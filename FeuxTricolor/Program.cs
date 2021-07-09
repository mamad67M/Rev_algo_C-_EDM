using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeuxTricolor
{
    class Program
    {
        static void Main(string[] args)
        {
            Char feu;
           

            do
            {
                Console.WriteLine("saisissez une couleur ");
                feu = Char.Parse(Console.ReadLine());
                //if (couleur == 'R')
                //{
                //    Console.WriteLine("S'arreter");
                //}
                //else if (couleur == 'O')
                //{
                //    Console.WriteLine("Ralentir");
                //}
                //else { Console.WriteLine("Passer"); }

                switch (feu)
                {
                    case 'R':
                        Console.WriteLine("S'arreter");
                        break;
                    case 'O':
                        Console.WriteLine("Ralentir");
                        break;
                    case 'V':
                        Console.WriteLine("Passer");
                        break;
                    default:
                        Console.WriteLine("Cas non traiter");
                        break;
                }
            } while (feu != 'R' && feu != 'V' && feu != 'O');




            Console.ReadKey();
        }
    }
}
