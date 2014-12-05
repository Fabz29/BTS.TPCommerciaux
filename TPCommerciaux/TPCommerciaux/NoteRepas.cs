using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public class NoteRepas : NoteFrais
    {
        private double repasMidi;

        public NoteRepas(DateTime uneDate, Commercial unCommercial, double unRepasMidi)
            :base (uneDate, unCommercial)
        {
            this.repasMidi = unRepasMidi;
            setMontant();
        }

        public override double calculMontantARembourser()
        {
            double total = 0;

            if (repasMidi > 20)
            {
                if (getLeCommercial.Categorie == 'A')
                {
                    total = 25;
                }
                else if (getLeCommercial.Categorie == 'B')
                {
                    total = 22;
                }
                else if (getLeCommercial.Categorie == 'C')
                {
                    total = 20;
                }
            }
            else
            {
                total = repasMidi;
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

            return string.Format("Repas -numéro : {0} - Date : {1} - montant à rembourser {2} euros - {3}", getNumero, getDateFrais, getMontant, etatRemboursement);
        }
    }
}
