using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Films;
using System.Collections.Generic;

namespace UnitTestFilm
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
        }
    }
}
