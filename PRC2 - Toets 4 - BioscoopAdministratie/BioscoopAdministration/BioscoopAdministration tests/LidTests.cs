using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioscoopAdministration;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class LidTests
    {
        [TestMethod]
        public void TestConstrutor()
        {
            //Maak parameters
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            string gebruikersnaam = "Test Gebruikersnaam";
            string wachtwoord = "Test Wachtwoord";

            //Maak lid
            Lid lid = new Lid(naam, adres, woonplaats, geboortedatum, gebruikersnaam, wachtwoord);

            //Test properties
            Assert.AreEqual(naam, lid.Naam);
            Assert.AreEqual(adres, lid.Adres);
            Assert.AreEqual(woonplaats, lid.Woonplaats);
            Assert.AreEqual(geboortedatum, lid.Geboortedatum);
            Assert.AreEqual(gebruikersnaam, lid.Gebruikersnaam);
        }

        [TestMethod]
        public void TestToString()
        {
            //Maak parameters
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            string gebruikersnaam = "Test Gebruikersnaam";
            string wachtwoord = "Test Wachtwoord";

            //Maak lid
            Lid lid = new Lid(naam, adres, woonplaats, geboortedatum, gebruikersnaam, wachtwoord);

            //Test properties
            Assert.AreEqual(naam, lid.ToString());
        }

        [TestMethod]
        public void TestWachtwoordControle()
        {
            //Maak parameters
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            string gebruikersnaam = "Test Gebruikersnaam";
            string wachtwoord = "Correct Wachtwoord";

            //Maak lid
            Lid lid = new Lid(naam, adres, woonplaats, geboortedatum, gebruikersnaam, wachtwoord);

            //Test wachtwoord controle
            Assert.IsFalse(lid.WachtwoordCorrect("Incorrect Wachtwoord"));
            Assert.IsTrue(lid.WachtwoordCorrect("Correct Wachtwoord"));
        }
    }
}
