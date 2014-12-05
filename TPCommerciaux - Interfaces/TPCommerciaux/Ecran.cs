using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCommerciaux;

namespace TPCommerciaux
{
    class Ecran
    {
        private static void affiche(IVoyageurCommercial voyageurCommercial)
        {
            Console.WriteLine(voyageurCommercial.ToString());
        }

        public static void affiche(ServiceCommercial sc)
        {
            //for(int i = 0; i <sc.nbCommerciaux();i++)
            //    affiche(sc.getCommercial(i));
            foreach (Commercial c in sc)
            {
                affiche(c);
            }
        }
    }
}
