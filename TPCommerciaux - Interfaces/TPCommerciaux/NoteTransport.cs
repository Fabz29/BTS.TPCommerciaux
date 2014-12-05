using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public class NoteTransport : NoteFrais
    {
        private int nbKm;
        public NoteTransport(DateTime uneDate, IVoyageurCommercial unCommercial, int unNbKm)
            :base (uneDate, unCommercial)
        {
            this.nbKm = unNbKm;
            setMontant();
        }

        public override double calculMontantARembourser()
        {
            double total = 0.0;

            if (getLeCommercial.PuissanceVoiture <= 5)
            {
                total = nbKm * 0.1;
            }
            else if (getLeCommercial.PuissanceVoiture > 5 && getLeCommercial.PuissanceVoiture <= 10)
            {
                total = nbKm * 0.2;
            }
            else if (getLeCommercial.PuissanceVoiture > 10)
            {
                total = nbKm * 0.3;
            }

            return total;
        }
        public override string ToString()
        {
            string etatRemboursement;

            if (getEstRembourse)
            {
                etatRemboursement = "remboursé";
            }
            else
            {
                etatRemboursement = "Non remboursé";
            }

            return string.Format("Transport -numéro : {0} - Date : {1} - montant à rembourser {2} euros - {3}", getNumero, getDateFrais, getMontant, etatRemboursement);
        }
    }
}
