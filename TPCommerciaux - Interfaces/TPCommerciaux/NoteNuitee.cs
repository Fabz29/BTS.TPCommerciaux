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

        public NoteNuitee(DateTime uneDate, IVoyageurCommercial unCommercial, double unMonantNuitee, int UneRegion)
            :base(uneDate, unCommercial)
        {
            this.montantNuitee = unMonantNuitee;
            this.region = UneRegion;
            setMontant();
        }

        public override double calculMontantARembourser()
        {
            double total = 0;

            if (montantNuitee > 50)
            {
                switch(getLeCommercial.Categorie)
                {
                    case 'A':
                        total = 65;
                        break;
                    case 'B':
                        total = 55;
                        break;
                    case'C':
                        total = 50;
                        break;
                }
            }
            else
            {
                total = montantNuitee;
            }

            switch (region)
            {
                case 1:
                    total *= 0.90;
                    break;
                case 2:
                    total *= 1;
                    break;
                case 3:
                    total *= 1.15;
                    break;
                default:
                    Console.WriteLine("Erreur la région indiqué n'existe pas");
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
