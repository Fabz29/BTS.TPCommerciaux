using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPCommerciaux;

namespace TestUnitaire
{
    [TestClass]
    public class AjouterNoteFraisServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ServiceCommercial sc; 
            Commercial c1; 
            sc = new ServiceCommercial("Commercial"); 
            c1 = new Commercial("Dupond", "Jean", 'A', 8); 
            sc.ajouterCommercial(c1);
            sc.ajouterNoteFrais(c1, new DateTime(2013, 11, 15), 250); // ajoute un frais de transport 
            sc.ajouterNoteFrais(c1, new DateTime(2013, 11, 21), 35.0); // ajoute une note de repas 
            sc.ajouterNoteFrais(c1, new DateTime(2013,11 , 25), 46.0, 2); // ajoute une nuitée 
            
            foreach(NoteFrais f in c1.getLesNotesFrais)
            {
                if (f is NoteTransport)
                {
                    Assert.AreEqual(50, f.getMontant);
                }
                else if (f is NoteRepas)
                {
                    Assert.AreEqual(25, f.getMontant);
                }
                else if (f is NoteNuitee)
                {
                    Assert.AreEqual(46, f.getMontant);
                }
            }
        }
    }
}
