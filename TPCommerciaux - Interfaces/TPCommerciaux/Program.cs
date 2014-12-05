using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommerciaux
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d = new DateTime(2009, 10, 21);
            //DateTime d1 = new DateTime(2010, 10, 21);
            //DateTime d2 = new DateTime(2011, 10, 21);
            //IVoyageurCommercial c;
            //c = new Commercial("Dupont", "Jean", 'B', 7);
            //NoteFrais f = new NoteTransport(d2, c, 100);
            //NoteFrais f1 = new NoteRepas(d1, c, 15.5);
            //NoteFrais f2 = new NoteNuitee(d, c, 75, 3);
            //NoteFrais f3 = new NoteNuitee(d, c, 89, 2);
            //NoteFrais f4 = new NoteNuitee(d2, c, 70, 1);
            //// affichage
            //List<NoteFrais> lesNotes = c.getLesNotesFrais;

            //foreach (NoteFrais nf in lesNotes)
            //{
            //    Console.WriteLine(nf.ToString());
            //}

            //// tri 
            //c.trierNotes();
            //// afficahge après le tri
            //lesNotes = c.getLesNotesFrais;
            //Console.WriteLine("-------------------");
            //Console.WriteLine("AFFICHAGE APRES TRI");
            //Console.WriteLine("-------------------");
            //foreach (NoteFrais nf in lesNotes)
            //{
            //    Console.WriteLine(nf.ToString());
            //}


            //Commercial c1, c2, c3;
            //ServiceCommercial sc;
            //sc = new ServiceCommercial();
            //c1 = new Commercial("Dupond", "Jean", 'B', 7);
            //c2 = new Commercial("Durand", "Dominique", 'C', 11);
            //c3 = new Commercial("Chamir", "Jéremy", 'A', 15);
            //sc.ajouterCommercial(c1);
            //sc.ajouterCommercial(c2);
            //sc.ajouterCommercial(c3);
            //Ecran.affiche(sc);

            DateTime d = new DateTime(2009, 10, 21);
            Commercial c = new Commercial("Dupont", "Jean", 'B', 7, d, "0132457898");
            foreach (object o in c)
            {
                Console.WriteLine(o.ToString());
            }

            Console.ReadLine();
        }
    }
}
