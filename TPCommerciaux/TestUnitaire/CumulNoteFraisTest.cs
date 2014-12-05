using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPCommerciaux;

namespace TestUnitaire
{
    [TestClass]
    public class CumulNoteFraisTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Commercial c;
            ServiceCommercial sc;
            sc = new ServiceCommercial("Commercial");
            c = new Commercial("Dupond", "Jean", 'A', 25);
            sc.ajouterCommercial(c);
            NoteFrais f, f1, f2;
            f = new NoteTransport(new DateTime(2014, 11, 12), c, 150);
            f1 = new NoteRepas(new DateTime(2014, 11, 17), c, 12.2);
            f2 = new NoteNuitee(new DateTime(2014, 11, 15), c, 240.0, 1);
            Assert.AreEqual(115.7, c.cumulNoteFraisAnnee(2014));
        }
    }
}
