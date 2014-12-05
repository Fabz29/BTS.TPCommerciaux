using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPCommerciaux;

namespace TestUnitaire
{
    [TestClass]
    public class AjouterNoteFraisTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Commercial c;
            c = new Commercial("Dupond", "Jean", 'A', 25);
            NoteFrais f, f1;
            f = new NoteFrais(new DateTime(2014, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2014, 11, 15), c);
            Assert.AreEqual(2, c.getLesNotesFrais.Count);
        }
    }
}
