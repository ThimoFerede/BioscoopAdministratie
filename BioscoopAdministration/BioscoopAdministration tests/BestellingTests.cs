using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioscoopAdministration;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class BestellingTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            //Maak parameters
            int BestellingsID = 0;
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            Bezoeker bezoeker = new Bezoeker(naam, adres, woonplaats, geboortedatum);

            //Maak bestelling
            Bestelling bestelling = new Bestelling(BestellingsID, bezoeker);

            //Test properties
            Assert.AreEqual(BestellingsID, bestelling.BestellingsID);
            Assert.AreEqual(bezoeker, bestelling.Bezoeker);
        }

        [TestMethod]
        public void TestBestellingBezoekerLink()
        {
            //Maak parameters
            int BestellingsID = 0;
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            Bezoeker bezoeker = new Bezoeker(naam, adres, woonplaats, geboortedatum);

            //Maak bestelling
            Bestelling bestelling = new Bestelling(BestellingsID, bezoeker);

            //Test link (de bestelling is bereikbaar vanuit de bezoeker en andersom)
            Assert.AreEqual(bestelling, bezoeker.Bestelling);
            Assert.AreEqual(bezoeker, bestelling.Bezoeker);
        }
    }
}
