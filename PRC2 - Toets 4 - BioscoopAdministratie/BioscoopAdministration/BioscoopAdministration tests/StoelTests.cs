using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioscoopAdministration;

namespace BioscoopAdministration_tests
{
    [TestClass]
    public class StoelTests
    {
        [TestMethod]
        public void TestStoelConstructorCorrect()
        {
            int rij = 1;
            int stoelnummer = 1;
            bool vipplaats = false;

            Stoel s = new Stoel(rij, stoelnummer, vipplaats);

            Assert.AreEqual(rij, s.Rij);
            Assert.AreEqual(stoelnummer, s.Stoelnummer);
            Assert.AreEqual(vipplaats, s.VIPplaats);
        }

        [TestMethod]
        public void TestStoelToString()
        {
            int rij = 1;
            int stoelnummer = 1;
            bool vipplaats = false;
            string infoString = "Rij: 1 - Stoelnummer: 1 - VIP plaats: False";

            Stoel s = new Stoel(rij, stoelnummer, vipplaats);

            Assert.AreEqual(infoString, s.ToString());
        }
    }
}
