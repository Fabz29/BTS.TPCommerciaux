using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    [System.Serializable]
    public class ServiceCommercial : IEnumerable
    {
        List<IVoyageurCommercial> lesCommerciaux;

        public ServiceCommercial ()
        {
            this.lesCommerciaux = new List<IVoyageurCommercial>();                        
        }

        public void ajouterCommercial(IVoyageurCommercial unC)
        {
            this.lesCommerciaux.Add(unC);
        }

        public void ajouterNoteFrais(IVoyageurCommercial unC, DateTime uneDate, int unNbKm)
        {
            NoteFrais f = new NoteTransport(uneDate, unC, unNbKm);
            unC.ajouterNoteFrais(f);
        }

        public void ajouterNoteFrais(IVoyageurCommercial unC, DateTime uneDate, double unMontant)
        {
            unC.ajouterNoteFrais(new NoteRepas(uneDate, unC, unMontant));
        }

        public void ajouterNoteFrais(IVoyageurCommercial unC, DateTime uneDate, double unMontant, int uneRegion)
        {
            unC.ajouterNoteFrais(new NoteNuitee(uneDate, unC, unMontant, uneRegion));
        }

        public int nbFraisNonRemboursés()
        {
            int total = 0;

            foreach (IVoyageurCommercial c in lesCommerciaux)
            {
                foreach (NoteFrais n in c.getLesNotesFrais)
                {
                    if (n.getEstRembourse == false)
                    {
                        total++;
                    }
                }
            }

            return total;
        }

        public int nbCommerciaux()
        {
            return lesCommerciaux.Count;
        }

        public IVoyageurCommercial getCommercial(int i)
        {
            return lesCommerciaux[i];
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            EnumereCommerciaux en = new EnumereCommerciaux(this);
            return en;
        }
    }
}
