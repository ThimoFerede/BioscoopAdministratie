using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioscoopAdministration;
using System.Collections.Generic;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class BioscoopTests
    {
        [TestMethod]
        public void TestConstructorEnMaakStandaardBioscoop()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            Bioscoop bioscoop = new Bioscoop(naam, locatie);

            bioscoop.MaakStandaardBioscoop();

            Assert.AreEqual(5, bioscoop.Zalen.Count);
            Assert.AreEqual(40, bioscoop.Films.Count);
            Assert.AreEqual(350, bioscoop.Personen.Count);
        }

        [TestMethod]
        public void TestVoegFilmToe()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            string titel = "The lion king";
            int jaar = 1994;
            int speelduur = 89;
            string taal = "Engels";
            int leeftijdscategorie = 6;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Animatie);
            lijstGenres.Add(Film.Genre.Familiefilm);

            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            Film f = new Film(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres);
            bioscoop.VoegFilmToe(f);

            Assert.AreEqual(1, bioscoop.Films.Count);
        }

        [TestMethod]
        public void TestVerwijderFilm()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            string titel = "The lion king";
            int jaar = 1994;
            int speelduur = 89;
            string taal = "Engels";
            int leeftijdscategorie = 6;
            List<Film.Genre> lijstGenres = new List<Film.Genre>();
            lijstGenres.Add(Film.Genre.Animatie);
            lijstGenres.Add(Film.Genre.Familiefilm);

            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            Film f = new Film(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres);
            bioscoop.MaakStandaardBioscoop();
            int count = bioscoop.Films.Count;
            bioscoop.VoegFilmToe(f);
            bioscoop.VerwijderFilm(f);
            bioscoop.VerwijderFilm(f);

            Assert.AreEqual(count, bioscoop.Films.Count);
        }

        [TestMethod]
        public void TestBouwZaal()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            int zaalnummer = 1;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._2D;
            int aantal_rijen = 5;
            int aantal_stoelen_rij = 20;
            int aantal_VIP_rijen = 1;
            int aantal_VIPstoel_rij = 10;

            Zaal z = new Zaal(zaalnummer, filmkwaliteit, aantal_rijen, aantal_stoelen_rij, aantal_VIP_rijen, aantal_VIPstoel_rij);
            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            bioscoop.BouwZaal(z);

            Assert.AreEqual(1, bioscoop.Zalen.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(NumberAlreadyTakenException))] 
        public void TestBouwZaalSameNumber()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            int zaalnummer = 1;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._2D;
            int aantal_rijen = 5;
            int aantal_stoelen_rij = 20;
            int aantal_VIP_rijen = 1;
            int aantal_VIPstoel_rij = 10;

            Zaal z = new Zaal(zaalnummer, filmkwaliteit, aantal_rijen, aantal_stoelen_rij, aantal_VIP_rijen, aantal_VIPstoel_rij);
            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            bioscoop.BouwZaal(z);
            bioscoop.BouwZaal(z);
        }

        [TestMethod]
        public void TestVernietigZaal()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            int zaalnummer = 10;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._2D;
            int aantal_rijen = 5;
            int aantal_stoelen_rij = 20;
            int aantal_VIP_rijen = 1;
            int aantal_VIPstoel_rij = 10;
        
            Zaal z = new Zaal(zaalnummer, filmkwaliteit, aantal_rijen, aantal_stoelen_rij, aantal_VIP_rijen, aantal_VIPstoel_rij);
            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            bioscoop.MaakStandaardBioscoop();
            bioscoop.BouwZaal(z);
            bioscoop.VernietigZaal(z);

            Assert.AreEqual(5, bioscoop.Zalen.Count);
        }

        [TestMethod]
        public void TestVoegPersoonToe()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";
            
            //Medewerker
            string naamM = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            int Id = 5656;
            string wachtwoord = "Test Wachtwoord";
            
            //Lid
            string naamL = "Test Persoon";
            string adresL = "Test Adres";
            string woonplaatsL = "Test Woonplaats";
            DateTime geboortedatumL = new DateTime(1, 1, 1);
            string gebruikersnaamL = "Test Gebruikersnaam";
            string wachtwoordL = "Test Wachtwoord";
            
            Lid lid = new Lid(naamL, adresL, woonplaatsL, geboortedatumL, gebruikersnaamL, wachtwoordL);
            Medewerker medewerker = new Medewerker(naamM, adres, woonplaats, geboortedatum, Id, wachtwoord);            
            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            bioscoop.VoegPersoonToe(lid);
            bioscoop.VoegPersoonToe(medewerker);

            Assert.AreEqual(2, bioscoop.Personen.Count);
        }

        [TestMethod]
        public void TestVerwijderPersoon()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            //Medewerker
            string naamM = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            int Id = 5656;
            string wachtwoord = "Test Wachtwoord";

            //Lid
            string naamL = "Test Persoon";
            string adresL = "Test Adres";
            string woonplaatsL = "Test Woonplaats";
            DateTime geboortedatumL = new DateTime(1, 1, 1);
            string gebruikersnaamL = "Test Gebruikersnaam";
            string wachtwoordL = "Test Wachtwoord";

            Lid lid = new Lid(naamL, adresL, woonplaatsL, geboortedatumL, gebruikersnaamL, wachtwoordL);
            Medewerker medewerker = new Medewerker(naamM, adres, woonplaats, geboortedatum, Id, wachtwoord);
            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            bioscoop.VoegPersoonToe(lid);
            bioscoop.VoegPersoonToe(medewerker);
            bioscoop.VerwijderPersoon(lid);

            Assert.AreEqual(1, bioscoop.Personen.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(NumberAlreadyTakenException))]
        public void TestVoegPersoonToeSameNumberMedewerker()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            //Medewerker
            string naamM = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            int Id = 5656;
            string wachtwoord = "Test Wachtwoord";
            
            Medewerker medewerker = new Medewerker(naamM, adres, woonplaats, geboortedatum, Id, wachtwoord);
            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            bioscoop.VoegPersoonToe(medewerker);
            bioscoop.VoegPersoonToe(medewerker);
        }

        [TestMethod]
        public void TestLogInLid()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            //Lid
            string naamL = "Test Persoon";
            string adresL = "Test Adres";
            string woonplaatsL = "Test Woonplaats";
            DateTime geboortedatumL = new DateTime(1, 1, 1);
            string gebruikersnaamL = "Test Gebruikersnaam";
            string wachtwoordL = "Test Wachtwoord";

            Lid lid = new Lid(naamL, adresL, woonplaatsL, geboortedatumL, gebruikersnaamL, wachtwoordL);
            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            bioscoop.MaakStandaardBioscoop();
            bioscoop.VoegPersoonToe(lid);
            Lid loginLid = bioscoop.LogInLid(gebruikersnaamL, wachtwoordL);

            Assert.AreEqual(lid, loginLid);
        }

        [TestMethod]
        public void TestLogInMedewerker()
        {
            string naam = "Bioscoop";
            string locatie = "Eindhoven";

            //Medewerker
            string naamM = "Test Persoon";
            string adres = "Test Adres";
            string woonplaats = "Test Woonplaats";
            DateTime geboortedatum = new DateTime(1, 1, 1);
            int Id = 5656;
            string wachtwoord = "Test Wachtwoord";

            Medewerker medewerker = new Medewerker(naamM, adres, woonplaats, geboortedatum, Id, wachtwoord);
            Bioscoop bioscoop = new Bioscoop(naam, locatie);
            bioscoop.MaakStandaardBioscoop();
            bioscoop.VoegPersoonToe(medewerker);
            Medewerker loginMedewerker = bioscoop.LogInMedewerker(Id, wachtwoord);

            Assert.AreEqual(medewerker, loginMedewerker);
        }
    }
}
