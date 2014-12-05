using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPCommerciaux;

namespace TestUnitaire
{
    [TestClass]
    public class nbNotesFraisNonRembourseesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Commercial c, c1;
            ServiceCommercial sc;
            sc = new ServiceCommercial("Commercial");
            c = new Commercial("Dupond", "Jean", 'A', 25);
            c1 = new Commercial("Duval", "Paul", 'B', 10);
            sc.ajouterCommercial(c);
            sc.ajouterCommercial(c1);
            NoteFrais f, f1, f2, f3, f4;
            f = new NoteFrais(new DateTime(2014, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2014, 11, 15), c);
            f1.setEstRembourse();
            f2 = new NoteFrais(new DateTime(2014, 11, 18), c1);
            f3 = new NoteFrais(new DateTime(2014, 11, 22), c1);
            f3.setEstRembourse();
            f4 = new NoteFrais(new DateTime(2014, 11, 25), c1);
            f4.setEstRembourse();
            Assert.AreEqual(2, sc.nbFraisNonRemboursés());
        }
    }
}
