using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public class Service
    {
        private string libelle;
        List<Commercial> lesCommercials;

        public Service (string pUnNom)
        {
            this.libelle = pUnNom;
            this.lesCommercials = new List<Commercial>();
                        
        }

        public void ajouterCommercial(Commercial unC)
        {
            lesCommercials.Add(unC);
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
