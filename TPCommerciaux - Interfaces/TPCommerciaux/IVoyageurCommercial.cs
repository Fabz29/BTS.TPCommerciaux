using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public interface IVoyageurCommercial
    {
        void ajouterNoteFrais(NoteFrais f);
        List<NoteFrais> getLesNotesFrais { get; }
        string Nom { get; }
        string Prenom { get; }
        char Categorie { get; }
        int PuissanceVoiture { get; }
        ServiceCommercial UnService { get; }
        string ToString();
        void trierNotes();
    }
}
