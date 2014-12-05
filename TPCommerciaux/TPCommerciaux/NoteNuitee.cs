using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public class NoteNuitee : NoteFrais
    {
        private double montantNuitee;
        private int region;

        public NoteNuitee(DateTime uneDate, Commercial unCommercial, double unMonantNuitee, int UneRegion)
            :base(uneDate, unCommercial)
        {
            this.montantNuitee = unMonantNuitee;
            this.region = UneRegion;
            setMontant();
        }

        public override double calculMontantARembourser()
        {
            double total = 0;
            double coeff = 0;

            switch (region)
            {
                case 1:
                    coeff = 0.90;
                    break;
                case 2:
                    coeff = 1;
                    break;
                case 3:
                    coeff = 1.15;
                    break;
                default:
                    Console.WriteLine("Erreur la région indiqué n'existe pas");
                    break;
            }    

            switch (getLeCommercial.Categorie)
            {
                case 'A':
                    if ((montantNuitee - 65 * coeff) <= 0)
                    {
                        total = montantNuitee;
                    }
                    else
                    {
                        total = 65 * coeff;
                    }
                    break;
                case 'B':
                    if ((montantNuitee - 55 * coeff) <= 0)
                    {
                        total = montantNuitee;
                    }
                    else
                    {
                        total = 55 * coeff;
                    }
                    break;
                case 'C':
                    if ((montantNuitee - 50 * coeff) <= 0)
                    {
                        total = montantNuitee;
                    }
                    else
                    {
                        total = 50 * coeff;
                    }
                    break;
                default:
                    total = 0;
                    break;
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

            return string.Format("Nuitée -numéro : {0} - Date : {1} - montant à rembourser {2} euros - {3}", getNumero, getDateFrais, getMontant, etatRemboursement);
        }
    }
}
