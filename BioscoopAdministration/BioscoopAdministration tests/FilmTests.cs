using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BioscoopAdministration;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class FilmTests
    {
        [TestMethod]
        public void TestFilmConstructorCorrect()
        {
            string titel = "The lion king";
            int jaar = 1994;
            int speelduur = 89;
            string taal = "Engels";
            int leeftijdscategorie = 6;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Animatie);
            lijstGenres.Add(Film.Genre.Familiefilm);

            Film f = new Film(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres);

            Assert.AreEqual(titel, f.Titel);
            Assert.AreEqual(jaar, f.Jaar);
            Assert.AreEqual(speelduur, f.Speelduur);
            Assert.AreEqual(taal, f.Taal);
            Assert.AreEqual(leeftijdscategorie, f.Leeftijdscategorie);
            Assert.AreEqual(lijstGenres, f.Genres);
        }

        [TestMethod]
        public void TestFilmConstructorEmptyList()
        {
            string titel = "The lion king";
            int jaar = 1994;
            int speelduur = 89;
            string taal = "Engels";
            int leeftijdscategorie = 6;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();

            Film f = new Film(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres);

            Assert.AreEqual(titel, f.Titel);
            Assert.AreEqual(jaar, f.Jaar);
            Assert.AreEqual(speelduur, f.Speelduur);
            Assert.AreEqual(taal, f.Taal);
            Assert.AreEqual(leeftijdscategorie, f.Leeftijdscategorie);
            Assert.AreEqual(lijstGenres, f.Genres);
        }

        [TestMethod]
        public void TestFilmToString()
        {
            string titel = "The lion king";
            int jaar = 1994;
            int speelduur = 89;
            string taal = "Engels";
            int leeftijdscategorie = 6;
            List<Film.Genre> lijstGenres = null;

            Film f = new Film(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres);

            Assert.AreEqual(titel, f.Titel);
            Assert.AreEqual(jaar, f.Jaar);
            Assert.AreEqual(speelduur, f.Speelduur);
            Assert.AreEqual(taal, f.Taal);
            Assert.AreEqual(leeftijdscategorie, f.Leeftijdscategorie);
            Assert.AreEqual(0, f.Genres.Count);
        }
    }
}
