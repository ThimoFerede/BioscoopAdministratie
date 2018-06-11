using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BioscoopAdministration;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class BioscoopvertoningTests
    {
        [TestMethod]
        public void TestBioscoopvertoningConstructorCorrect()
        {
            string titel = "Avengers: Infinity war";
            int jaar = 2018;
            int speelduur = 149;
            string taal = "Engels";
            int leeftijdscategorie = 12;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Actiefilm);
            lijstGenres.Add(Film.Genre.Avontuurfilm);
            lijstGenres.Add(Film.Genre.Sciencefiction);
            DateTime begintijd = DateTime.Now;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._Imax_3D;
            Zaal zaal = new Zaal(1, Bioscoopvertoning.Filmkwaliteit._Imax_3D, 20, 30, 2, 20);

            Bioscoopvertoning b = new Bioscoopvertoning(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres, begintijd, filmkwaliteit, zaal, 12);

            Assert.AreEqual(titel, b.Titel);
            Assert.AreEqual(jaar, b.Jaar);
            Assert.AreEqual(speelduur, b.Speelduur);
            Assert.AreEqual(taal, b.Taal);
            Assert.AreEqual(leeftijdscategorie, b.Leeftijdscategorie);
            Assert.AreEqual(lijstGenres, b.Genres);
            Assert.AreEqual(begintijd, b.Begintijd);
            Assert.AreEqual(begintijd.AddMinutes(speelduur), b.Eindtijd);
            Assert.AreEqual(filmkwaliteit, b.Film_kwaliteit);
            Assert.AreEqual(zaal, b.BioscoopZaal);
        }

        [TestMethod]
        public void TestBioscoopvertoningBestellingToevoegenCorrect()
        {
            string titel = "Avengers: Infinity war";
            int jaar = 2018;
            int speelduur = 149;
            string taal = "Engels";
            int leeftijdscategorie = 12;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Actiefilm);
            lijstGenres.Add(Film.Genre.Avontuurfilm);
            lijstGenres.Add(Film.Genre.Sciencefiction);
            DateTime begintijd = DateTime.Now;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._Imax_3D;
            Zaal zaal = new Zaal(1, Bioscoopvertoning.Filmkwaliteit._Imax_3D, 20, 30, 2, 20);

            Bioscoopvertoning b = new Bioscoopvertoning(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres, begintijd, filmkwaliteit, zaal, 12);
            Bezoeker bz = new Bezoeker("Joost", "Boomlaan 36", "Verweg", DateTime.Now);
            Bestelling bes = new Bestelling(bz, b, zaal.Stoelen[0]);

            Assert.AreEqual(1, b.Bestellingen.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestBioscoopvertoningBestellingToevoegenIncorrect()
        {
            string titel = "Avengers: Infinity war";
            int jaar = 2018;
            int speelduur = 149;
            string taal = "Engels";
            int leeftijdscategorie = 12;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Actiefilm);
            lijstGenres.Add(Film.Genre.Avontuurfilm);
            lijstGenres.Add(Film.Genre.Sciencefiction);
            DateTime begintijd = DateTime.Now;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._Imax_3D;
            Zaal zaal = new Zaal(1, Bioscoopvertoning.Filmkwaliteit._Imax_3D, 20, 30, 2, 20);

            Bioscoopvertoning b = new Bioscoopvertoning(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres, begintijd, filmkwaliteit, zaal, 12);
            Bestelling bes = null;
            b.VoegBestellingToe(bes);
        }
    }
}
