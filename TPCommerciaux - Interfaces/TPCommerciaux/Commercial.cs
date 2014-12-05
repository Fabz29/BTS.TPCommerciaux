using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public class Commercial : IVoyageurCommercial, ISalarie, IEnumerable
    {
        private string nom;
        private string prenom;
        private char categorie;
        private int puissanceVoiture;
        private string numSecu;
        private DateTime dateEmbauche;
        private ServiceCommercial service;
        private List<NoteFrais> lesNotesFrais;

        public Commercial(string unNom, string unPrenom, char uneCategorie, int unePuissance)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            this.categorie = uneCategorie;
            this.puissanceVoiture = unePuissance;
            this.lesNotesFrais = new List<NoteFrais>();
        }

        public Commercial (string unNom, string unPrenom, char uneCategorie, int unePuissance, ServiceCommercial unService)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            this.categorie = uneCategorie;
            this.puissanceVoiture = unePuissance;
            this.lesNotesFrais = new List<NoteFrais>();
            this.service.ajouterCommercial(this);
        }

        public Commercial(string n, string p, DateTime de, string numSe)
        {
            this.nom = n;
            this.prenom = p;
            this.dateEmbauche = de;
            this.numSecu = numSe;
            this.lesNotesFrais = new List<NoteFrais>();
        }

        public Commercial(string unNom, string unPrenom, char uneCategorie, int unePuissance, DateTime uneDate, string numSe)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            this.categorie = uneCategorie;
            this.puissanceVoiture = unePuissance;
            this.dateEmbauche = uneDate;
            this.numSecu = numSe;
            this.lesNotesFrais = new List<NoteFrais>();
        }

        public string Nom
        {
          get { return nom; }
          // set { nom = value; }
        }

        public string Prenom
        {
          get { return prenom; }
          // set { prenom = value; }
        }

        public char Categorie
        {
          get { return categorie; }
          // set { categorie = value; }
        }

        public int PuissanceVoiture
        {
          get { return puissanceVoiture; }
          // set { puissanceVoiture = value; }
        }

        public string NumSecu
        {
            get { return numSecu; }
        }

        public int Anciennete
        {
            get { return DateTime.Now.Year - dateEmbauche.Year; }
        }

        public ServiceCommercial UnService
        {
          get { return service; }
          // set { service = value; }
        }

        public void ajouterNoteFrais(NoteFrais f)
        {
            lesNotesFrais.Add(f);
        }

        public List<NoteFrais> getLesNotesFrais
        {
            get { return lesNotesFrais; }
        }

        public override string ToString()
        {
            return string.Format("Nom : {0}; Prénom : {1}; Puissance Voiture : {2}; Catégorie : {3}", nom, prenom, puissanceVoiture, categorie);
        }

        public double cumulNoteFraisAnnee(int annee)
        {
            double total = 0;

            foreach(NoteFrais n in lesNotesFrais)
            {
                if (n.getDateFrais.Year == annee)
                {
                    total += n.getMontant;
                }
            }

            return total;
        }

        public void trierNotes()
        {
            lesNotesFrais.Sort();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            EnumereChampsCommercial en = new EnumereChampsCommercial(this);
            return en;
        }
    }
}
