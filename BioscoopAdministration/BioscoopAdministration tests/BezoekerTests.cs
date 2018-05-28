using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioscoopAdministration;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class BezoekerTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            //Maak parameters
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);

            //Maak bezoeker
            Bezoeker bezoeker = new Bezoeker(naam, adres, woonplaats, geboortedatum);

            //Test properties
            Assert.AreEqual(naam, bezoeker.Naam);
            Assert.AreEqual(adres, bezoeker.Adres);
            Assert.AreEqual(woonplaats, bezoeker.Woonplaats);
            Assert.AreEqual(geboortedatum, bezoeker.Geboortedatum);
        }
    }
}
