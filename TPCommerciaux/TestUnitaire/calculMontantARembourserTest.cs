using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPCommerciaux;

namespace TestUnitaire
{
    [TestClass]
    public class calculMontantARembourserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Commercial c = new Commercial("Dupond", "Jean", 'A', 8);

            NoteFrais f = new NoteTransport(new DateTime(2014, 11, 12), c, 250);
            Assert.AreEqual(f.getMontant, 50);

            NoteFrais f1 = new NoteRepas(new DateTime(2014, 11, 15), c, 35);
            NoteFrais f2 = new NoteRepas(new DateTime(2014, 11, 15), c, 15);
            Assert.AreEqual(f1.getMontant, 25);
            Assert.AreEqual(f2.getMontant, 15);

            NoteFrais f4 = new NoteNuitee(new DateTime(2014, 11, 17), c, 46, 2);
            NoteFrais f5 = new NoteNuitee(new DateTime(2014, 11, 17), c, 80, 3);
            Assert.AreEqual(f4.getMontant, 46);
            Assert.AreEqual(f5.getMontant, 74.75);
        }
    }
}
