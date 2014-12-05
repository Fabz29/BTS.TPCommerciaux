using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    [System.Serializable]
    public class ServiceCommercial
    {
        private string libelle;
        List<Commercial> lesCommercials;

        public ServiceCommercial (string pUnNom)
        {
            this.libelle = pUnNom;
            this.lesCommercials = new List<Commercial>();                        
        }

        public void ajouterCommercial(Commercial unC)
        {
            this.lesCommercials.Add(unC);
        }

        public void ajouterNoteFrais(Commercial unC, DateTime uneDate, int unNbKm)
        {          
            unC.ajouterNoteFrais(new NoteTransport(uneDate, unC, unNbKm));
        }

        public void ajouterNoteFrais(Commercial unC, DateTime uneDate, double unMontant)
        {
            unC.ajouterNoteFrais(new NoteRepas(uneDate, unC, unMontant));
        }

        public void ajouterNoteFrais(Commercial unC, DateTime uneDate, double unMontant, int uneRegion)
        {
            unC.ajouterNoteFrais(new NoteNuitee(uneDate, unC, unMontant, uneRegion));
        }

        public int nbFraisNonRemboursés()
        {
            int total = 0;

            foreach(Commercial c in lesCommercials)
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
    }
}
