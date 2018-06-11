using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BioscoopAdministration;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class DigitaleKopieTests
    {
        [TestMethod]
        public void TestDigitalKopieConstructorCorrect()
        {
            string titel = "Ex Machina";
            int jaar = 2014;
            int speelduur = 108;
            string taal = "Engels";
            int leeftijdscategorie = 16;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Drama);
            lijstGenres.Add(Film.Genre.Mystery);
            lijstGenres.Add(Film.Genre.Sciencefiction);
            int toegangscode = 8370;

            DigitaleKopie dk = new DigitaleKopie(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres, toegangscode, 3);

            Assert.AreEqual(titel, dk.Titel);
            Assert.AreEqual(jaar, dk.Jaar);
            Assert.AreEqual(speelduur, dk.Speelduur);
            Assert.AreEqual(taal, dk.Taal);
            Assert.AreEqual(leeftijdscategorie, dk.Leeftijdscategorie);
            Assert.AreEqual(lijstGenres, dk.Genres);
            Assert.AreEqual(toegangscode, dk.Toegangscode);
        }

        [TestMethod]
        public void TestDigitalKopieUitleningToevoegenCorrect()
        {
            string titel = "Ex Machina";
            int jaar = 2014;
            int speelduur = 108;
            string taal = "Engels";
            int leeftijdscategorie = 16;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Drama);
            lijstGenres.Add(Film.Genre.Mystery);
            lijstGenres.Add(Film.Genre.Sciencefiction);
            int toegangscode = 8370;

            DigitaleKopie dk = new DigitaleKopie(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres, toegangscode, 3);
            Lid l = new Lid("Piet", "weg", "Geldrop", DateTime.Now, "piet", "P8I9");
            Uitlening u = new Uitlening(DateTime.Now, DateTime.Now, dk, l);

            Assert.AreEqual(1, dk.Uitleningen.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestDigitalKopieUitleningToevoegenIncorrect()
        {
            string titel = "Ex Machina";
            int jaar = 2014;
            int speelduur = 108;
            string taal = "Engels";
            int leeftijdscategorie = 16;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Drama);
            lijstGenres.Add(Film.Genre.Mystery);
            lijstGenres.Add(Film.Genre.Sciencefiction);
            int toegangscode = 8370;

            DigitaleKopie dk = new DigitaleKopie(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres, toegangscode, 3);
            Uitlening u = null;

            dk.VoegUitleningToe(u);
        }
    }
}
