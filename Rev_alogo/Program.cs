using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rev_alogo
{
    class Program
    {
        static void Main(string[] args)
        {
            float montant;
            float remise = 0;
            Console.Write("Saisissez un montant: ");
            montant = float.Parse(Console.ReadLine());

            if (montant >=40) { remise = 10; }
            else
            {
                if (montant>=20)
                {
                    remise = 5;
                }
            }
            // calcule de la remise 
            montant = montant*(1 -  remise/ 100);
            Console.WriteLine("le montnat est "+montant+"€" + " avec une remise de "+ remise+"%");
            Console.ReadKey();
        }
    }
}
