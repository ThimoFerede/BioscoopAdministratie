using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Films;

namespace UnitTestFilm
{
    [TestClass]
    public class ZaalTests
    {
        [TestMethod]
        public void TestZaalConstructorCorrect()
        {
            int zaalnummer = 1;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._2D;
            int aantal_rijen = 5;
            int aantal_stoelen_rij = 20;
            int aantal_VIP_rijen = 1;
            int aantal_VIPstoel_rij = 10;

            Zaal z = new Zaal(zaalnummer, filmkwaliteit, aantal_rijen, aantal_stoelen_rij, aantal_VIP_rijen, aantal_VIPstoel_rij);

            Assert.AreEqual(zaalnummer, z.Zaalnummer);
            Assert.AreEqual(filmkwaliteit, z.FilmKwaliteit);
            Assert.AreEqual(110, z.Stoelen.Count);
        }

        [TestMethod]
        public void TestZaalToString()
        {
            int zaalnummer = 2;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._Imax_3D;
            int aantal_rijen = 20;
            int aantal_stoelen_rij = 40;
            int aantal_VIP_rijen = 3;
            int aantal_VIPstoel_rij = 20;
            string zaalString = "Zaal: 2 - Filmkwaliteit: _Imax_3D";

            Zaal z = new Zaal(zaalnummer, filmkwaliteit, aantal_rijen, aantal_stoelen_rij, aantal_VIP_rijen, aantal_VIPstoel_rij);

            Assert.AreEqual(zaalnummer, z.Zaalnummer);
            Assert.AreEqual(filmkwaliteit, z.FilmKwaliteit);
            Assert.AreEqual(860, z.Stoelen.Count);
            Assert.AreEqual(zaalString, z.ToString());
        }

        [TestMethod]
        public void TestZaalConstructorCorrectStoelen()
        {
            int zaalnummer = 1;
            Bioscoopvertoning.Filmkwaliteit filmkwaliteit = Bioscoopvertoning.Filmkwaliteit._2D;
            int aantal_rijen = 5;
            int aantal_stoelen_rij = 20;
            int aantal_VIP_rijen = 1;
            int aantal_VIPstoel_rij = 10;

            Zaal z = new Zaal(zaalnummer, filmkwaliteit, aantal_rijen, aantal_stoelen_rij, aantal_VIP_rijen, aantal_VIPstoel_rij);

            Assert.AreEqual(zaalnummer, z.Zaalnummer);
            Assert.AreEqual(filmkwaliteit, z.FilmKwaliteit);
            Assert.AreEqual(110, z.Stoelen.Count);
            int countStoel = 0;
            int countVIP = 0;
            foreach(Stoel s in z.Stoelen)
            {
                if (s.VIPplaats)
                {
                    countVIP++;
                }
                else
                {
                    countStoel++;
                }
            }
            Assert.AreEqual(100, countStoel);
            Assert.AreEqual(10, countVIP);
        }
    }
}
