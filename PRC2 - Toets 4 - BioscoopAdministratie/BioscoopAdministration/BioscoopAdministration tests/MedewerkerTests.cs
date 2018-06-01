using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioscoopAdministration;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class MedewerkerTests
    {
        [TestMethod]
        public void TestConstrutor()
        {
            //Maak parameters
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            int Id = 5656;
            string wachtwoord = "Test Wachtwoord";

            //Maak medewerker
            Medewerker medewerker = new Medewerker(naam, adres, woonplaats, geboortedatum, Id, wachtwoord);

            //Test properties
            Assert.AreEqual(naam, medewerker.Naam);
            Assert.AreEqual(adres, medewerker.Adres);
            Assert.AreEqual(woonplaats, medewerker.Woonplaats);
            Assert.AreEqual(geboortedatum, medewerker.Geboortedatum);
            Assert.AreEqual(Id, medewerker.MedewerkerID);
        }

        [TestMethod]
        public void TestToString()
        {
            //Maak parameters
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            int Id = 5656;
            string wachtwoord = "Test Wachtwoord";

            //Maak medewerker
            Medewerker medewerker = new Medewerker(naam, adres, woonplaats, geboortedatum, Id, wachtwoord);

            //Test properties
            Assert.AreEqual(naam, medewerker.ToString());
        }

        [TestMethod]
        public void TestWachtwoordControle()
        {
            //Maak parameters
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            int Id = 5656;
            string wachtwoord = "Test Wachtwoord";

            //Maak medewerker
            Medewerker medewerker = new Medewerker(naam, adres, woonplaats, geboortedatum, Id, wachtwoord);

            //Test wachtwoord controle
            Assert.IsFalse(medewerker.WachtwoordCorrect("Incorrect Wachtwoord"));
            Assert.IsTrue(medewerker.WachtwoordCorrect("Correct Wachtwoord"));
        }
    }
}
