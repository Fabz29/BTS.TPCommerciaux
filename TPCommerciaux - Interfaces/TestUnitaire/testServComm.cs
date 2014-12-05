using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPCommerciaux;

namespace TestUnitaire
{
    [TestClass]
    public class testServComm
    {
        [TestMethod]
        public void NbNitesFraisNOnRembourseesTest()
        {
            ServiceCommercial sc = new ServiceCommercial("Commercial");
            IVoyageurCommercial c = new Commercial("Dupont", "Albert", 'A', 25);
            sc.ajouterCommercial(c);
            IVoyageurCommercial c1 = new Commercial("Duval", "Paul", 'B', 10);
            sc.ajouterCommercial(c1);
            NoteFrais f = new NoteFrais(new DateTime(2014, 10, 23), c);
            f.setEstRembourse();
            NoteFrais f1 = new NoteFrais(new DateTime(2014, 10, 24), c);
            NoteFrais f2 = new NoteFrais(new DateTime(2014, 10, 24), c1);
            f2.setEstRembourse();
            Assert.AreEqual(1, sc.nbFraisNonRemboursés());
        }
    }
}
