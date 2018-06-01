using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioscoopAdministration;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class UitleningTests
    {
        private static string naam = "Test Persoon";
        private static string adres = "Test Adres";
        private static string woonplaats = "Test Woonplaats";
        private static DateTime geboortedatum = new DateTime(1, 1, 1);
        private static string gebruikersnaam = "Test Gebruikersnaam";
        private static string wachtwoord = "Test Wachtwoord";
        private static Lid lid = new Lid(naam, adres, woonplaats, geboortedatum, gebruikersnaam, wachtwoord);

        private static DateTime startDatum = new DateTime(1, 1, 1);
        private static DateTime eindDatum = new DateTime(1, 2, 5);

        private static DigitaleKopie digitaleKopie = new DigitaleKopie
           (
           "Film",
           2018,
           140,
           "Engels",
           16,
           new System.Collections.Generic.List<Film.Genre>(),
           1234,
           12.50);

        [TestMethod]
        public void TestConstructor()
        {
            //Maak uitlening
            Uitlening uitlening = new Uitlening(startDatum, eindDatum, digitaleKopie, lid);

            //Test properties
            Assert.AreEqual(lid, uitlening.Lid);
            Assert.AreEqual(startDatum, uitlening.Startdatum);
            Assert.AreEqual(eindDatum, uitlening.Einddatum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorMetNullLid()
        {
            //Maak parameters
            Lid lid = null;

            DateTime startDatum = new DateTime(1, 1, 1);
            DateTime eindDatum = new DateTime(1, 2, 5);

            //Maak uitlening
            Uitlening uitlening = new Uitlening(startDatum, eindDatum, digitaleKopie, lid);
        }

        [TestMethod]
        public void TestUitleningLidLink()
        {
            //Maak parameters
            string naam = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            string gebruikersnaam = "Test Gebruikersnaam";
            string wachtwoord = "Test Wachtwoord";
            Lid lid = new Lid(naam, adres, woonplaats, geboortedatum, gebruikersnaam, wachtwoord);

            DateTime startDatum = new DateTime(1, 1, 1);
            DateTime eindDatum = new DateTime(1, 2, 5);

            //Maak uitlening
            Uitlening uitlening = new Uitlening(startDatum, eindDatum, digitaleKopie, lid);

            //Test link (de uitlening is bereikbaar vanuit het lid en andersom)
            Assert.IsTrue(lid.Uitleningen.Contains(uitlening));
            Assert.IsTrue(uitlening.Lid == lid);
        }
    }
}
