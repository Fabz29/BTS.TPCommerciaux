using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public class Commercial
    {
        private string nom;
        private string prenom;
        private char categorie;
        private int puissanceVoiture;
        private ServiceCommercial service;
        List<NoteFrais> lesNotesFrais;

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
    }
}
