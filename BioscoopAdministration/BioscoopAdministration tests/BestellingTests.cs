using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioscoopAdministration;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class BestellingTests
    {
        private static string naam = "Test Persoon";
        private static string adres = "Test Adres";
        private static string woonplaats = "Test Woonplaats";
        private static DateTime geboortedatum = new DateTime(1, 1, 1);
        private static Bezoeker bezoeker = new Bezoeker(naam, adres, woonplaats, geboortedatum);

        private static Zaal zaal = new Zaal(1, Bioscoopvertoning.Filmkwaliteit._3D, 20, 15, 2, 10);
        private static Bioscoopvertoning bioscoopvertoning = new Bioscoopvertoning
            (
            "Film",
            2018,
            140,
            "Engels",
            16,
            new System.Collections.Generic.List<Film.Genre>(),
            DateTime.Now,
            Bioscoopvertoning.Filmkwaliteit._3D,
            zaal,
            12.50);
        [TestMethod]
        public void TestConstructor()
        {
            //Maak bestelling
            Bestelling bestelling = new Bestelling(bezoeker, bioscoopvertoning, zaal.Stoelen[0]);

            //Test properties
            Assert.AreEqual(bezoeker, bestelling.Klant);
            Assert.AreEqual(bioscoopvertoning, bestelling.Bioscoopvertoning);
            Assert.AreEqual(zaal, bestelling.Bioscoopvertoning.BioscoopZaal);
            Assert.AreEqual(zaal.Stoelen[0], bestelling.Stoel);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorMetNullParameters()
        {
            //Maak bestelling
            Bestelling bestelling = new Bestelling(null, null, null);
        }

        [TestMethod]
        public void TestBestellingBezoekerLink()
        {
            //Maak bestelling
            Bestelling bestelling = new Bestelling(bezoeker, bioscoopvertoning, zaal.Stoelen[0]);

            //Test link (de bestelling is bereikbaar vanuit de bezoeker en andersom)
            Assert.AreEqual(bestelling, bezoeker.Bestelling);
            Assert.AreEqual(bezoeker, bestelling.Klant);
        }

        [TestMethod]
        public void TestBestellingLidLink()
        {
            Lid lid = new Lid(naam, adres, woonplaats, geboortedatum, "Gebruikersnaam", "Wachtwoord");

            //Maak bestelling
            Bestelling bestelling = new Bestelling(lid, bioscoopvertoning, zaal.Stoelen[0]);

            //Test link (de bestelling is bereikbaar vanuit het lid en andersom)
            Assert.IsTrue(lid.Bestellingen.Contains(bestelling));
            Assert.AreEqual(lid, bestelling.Klant);
        }

        [TestMethod]
        public void TestPriceCalculation()
        {
            //Maak bestelling
            Bestelling bestelling = new Bestelling(bezoeker, bioscoopvertoning, new Stoel(1,1,true));

            //Test prijs (orginele prijs + 4 euro vipstoel)
            Assert.AreEqual(16.50, bestelling.Price);
        }
    }
}
