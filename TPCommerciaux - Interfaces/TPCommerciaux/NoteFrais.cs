using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public class NoteFrais : IComparable
    {
        static int nrOfInstances = 1;
        private int numero;
        private DateTime dateFrais;
        private double montant;
        private bool estRembourse;
        private IVoyageurCommercial leCommercial;

        public NoteFrais(DateTime uneDate, IVoyageurCommercial unCommercial)
        {
            this.numero = nrOfInstances;
            nrOfInstances++;
            this.dateFrais = uneDate;
            this.montant = 0;
            this.estRembourse = false;
            this.leCommercial = unCommercial;
            this.leCommercial.ajouterNoteFrais(this);
        }

        public NoteFrais(DateTime uneDate, int unMontant, bool pRembourse, IVoyageurCommercial unCommercial)
        {
            this.numero = nrOfInstances;
            nrOfInstances++;
            this.dateFrais = uneDate;
            this.montant = unMontant;
            this.estRembourse = pRembourse;
            this.leCommercial = unCommercial;
            this.leCommercial.ajouterNoteFrais(this);
        }

        public int getNumero
        {
            get { return numero; }
        }

        public DateTime getDateFrais
        {
            get { return dateFrais; }
        }

        public double getMontant
        {
            get { return montant; }
            // set { montant = value; }
        }

        public void setMontant()
        {
            this.montant = calculMontantARembourser();
        }

        public IVoyageurCommercial getLeCommercial
        {
            get { return leCommercial; }
            // set { leCommercial = value; }
        }

        public bool getEstRembourse
        {
            get { return estRembourse; }
        }
        public void setEstRembourse()
        {
            this.estRembourse = true; 
        }

        public override string ToString()
        {
            string etatRemboursement;

            if (estRembourse)
            {
                etatRemboursement = "remboursé";
            }
            else
            {
               etatRemboursement = "Non remboursé";
            }

            return string.Format("Numéro : {0} - Date : {1} - montant à rembourser {2} euros - {3}", numero, dateFrais, montant, etatRemboursement);
        }

        public virtual double calculMontantARembourser()
        {
            return 0;
        }

        int IComparable.CompareTo(object obj)
        {
            NoteFrais maNoteF = (NoteFrais)obj;
            return dateFrais.CompareTo(maNoteF.dateFrais);
        }
    }
}
