using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration
{
    class Bioscoop
    {
        private List<Persoon> Personen;
        private List<Film> Films;
        private List<Bioscoopvertoning> Vertoningen;
        private List<DigitaleKopie> DigitaleKopieen;
        private List<Zaal> Zalen;

        private string Naam;
        private string Locatie;

        public Bioscoop(string naam, string locatie)
        {
            Naam = naam;
            Locatie = locatie;
            Personen = new List<Persoon>();
            Films = new List<Film>();
            Vertoningen = new List<Bioscoopvertoning>();
            DigitaleKopieen = new List<DigitaleKopie>();
            Zalen = new List<Zaal>();
        }

        public void MaakStandaardBioscoop()
        {
            //Maak zalen
            BouwZaal(new Zaal(1, Bioscoopvertoning.Filmkwaliteit._2D, 12, 25, 2, 15));
            BouwZaal(new Zaal(2, Bioscoopvertoning.Filmkwaliteit._3D, 15, 25, 3, 10));
            BouwZaal(new Zaal(3, Bioscoopvertoning.Filmkwaliteit._Imax_3D, 20, 30, 5, 20));
            BouwZaal(new Zaal(4, Bioscoopvertoning.Filmkwaliteit._Imax_3D, 20, 30, 5, 20));
            BouwZaal(new Zaal(5, Bioscoopvertoning.Filmkwaliteit._Imax_2D, 15, 22, 4, 10));

            //Maak films
            for (int i = 0; i < 20; i++)
            {
                Film film = new Film("Film" + i, 2018, 2, "Engels", 16, null);
                VoegFilmToe(new Bioscoopvertoning(film, DateTime.Now.AddHours(i), Bioscoopvertoning.Filmkwaliteit._Imax_3D, Zalen[i % 5]));
                VoegDigitaleKopieToe(new DigitaleKopie(film, i));
            }

            //Maak personen
            for (int i = 0; i < 50; i++)
            {
                VoegPersoonToe(new Medewerker("Medewerker", "Straat 15", "Plaats", new DateTime(1, 1, 1), i, "1234"));
            }

            for(int i = 0; i < 100; i++)
            {
                VoegPersoonToe(new Lid("Lid", "Straat 15", "Plaats", new DateTime(1, 1, 1), "Gebruikersnaam", "1234"));
            }

        }

        public void VoegFilmToe(Film film)
        {
            Films.Add(film);
        }

        public void VerwijderFilm()
        {

        }

        public void BouwZaal(Zaal zaal)
        {
            Zalen.Add(zaal);
        }

        public void VernietigZaal()
        {

        }

        public void VoegVertoningToe()
        {

        }

        public void VerwijderVertoning()
        {

        }

        public void VoegDigitaleKopieToe(DigitaleKopie digitaleKopie)
        {
            DigitaleKopieen.Add(digitaleKopie);
        }

        public void VerwijderDigitaleKopie()
        {

        }
        /// <summary>
        /// Voegt een persoon toe aan de lijst
        /// </summary>
        /// <param name="persoon"></param>
        public void VoegPersoonToe(Persoon persoon)
        {
            if (persoon == null) throw new ArgumentNullException("persoon", "persoon mag niet null zijn");
            Personen.Add(persoon);
        }
        /// <summary>
        /// Verwijdert een persoon uit de lijst
        /// Persoon mag niet null zijn
        /// </summary>
        /// <param name="persoon"></param>
        /// <returns>
        /// Wel of niet verwijderd
        /// </returns>
        public bool VerwijderPersoon(Persoon persoon)
        {
            if (persoon == null) throw new ArgumentNullException("persoon", "persoon mag niet null zijn");
            return Personen.Remove(persoon);
        }
    }
}
