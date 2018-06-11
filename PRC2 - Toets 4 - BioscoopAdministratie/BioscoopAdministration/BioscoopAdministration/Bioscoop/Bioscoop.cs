using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace BioscoopAdministration
{
    [Serializable]
    public class Bioscoop
    {
        public List<Persoon> Personen { get; private set; }
        public List<Film> Films { get; private set; }
        public List<Bioscoopvertoning> Vertoningen
        {
            get
            {
                List<Bioscoopvertoning> vertoningen = new List<Bioscoopvertoning>();
                foreach(Film f in Films)
                {
                    if(f is Bioscoopvertoning)
                    {
                        vertoningen.Add(f as Bioscoopvertoning);
                    }
                }
                return vertoningen;
            }
        }
        public List<DigitaleKopie> DigitaleKopieen
        {
            get
            {
                List<DigitaleKopie> kopieen = new List<DigitaleKopie>();
                foreach (Film f in Films)
                {
                    if (f is DigitaleKopie)
                    {
                        kopieen.Add(f as DigitaleKopie);
                    }
                }
                return kopieen;
            }
        }
        public List<Zaal> Zalen { get; private set; }

        private string Naam;
        private string Locatie;

        public Bioscoop(string naam, string locatie)
        {
            Naam = naam;
            Locatie = locatie;
            Personen = new List<Persoon>();
            Films = new List<Film>();
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
                VoegFilmToe(new Bioscoopvertoning(film, DateTime.Now.AddHours(i), (Bioscoopvertoning.Filmkwaliteit)(i % 4), Zalen[i % 5], i));
                VoegFilmToe(new DigitaleKopie(film, i*123, i));
            }

            //Maak personen
            for (int i = 0; i < 50; i++)
            {
                VoegPersoonToe(new Medewerker("Medewerker", "Straat 15", "Plaats", new DateTime(1, 1, 1), i, "1234"));
            }

            for(int i = 0; i < 100; i++)
            {
                Lid NieuwLid = new Lid("Lid", "Straat 15", "Plaats", new DateTime(1, 1, 1), "Gebruikersnaam", "1234");
                for(int j = 0; j < i % 3; j++)
                {
                    Bestelling NieuweBestelling = new Bestelling(NieuwLid, Vertoningen[(i * j) % 20], Vertoningen[(i * j) % 20].BioscoopZaal.Stoelen[i % Vertoningen[(i * j) % 20].BioscoopZaal.Stoelen.Count]);
                    Uitlening NieuweUitlening = new Uitlening(DateTime.Now.AddDays(j), DateTime.Now.AddDays(j + 3), DigitaleKopieen[i%20], NieuwLid);
                }
                VoegPersoonToe(NieuwLid);
            }

            for(int i = 0; i < 200; i++)
            {
                Bezoeker NieuweBezoeker = new Bezoeker("Bezoeker", "Straat 15", "Plaats", new DateTime(1, 1, 1));
                Bestelling NieuweBestelling = new Bestelling(NieuweBezoeker, Vertoningen[i % 20], Vertoningen[i % 20].BioscoopZaal.Stoelen[i % Vertoningen[i % 20].BioscoopZaal.Stoelen.Count]);
                VoegPersoonToe(NieuweBezoeker);
            }
        }

        public void VoegFilmToe(Film film)
        {
            Films.Add(film);
        }

        public void VerwijderFilm(Film film)
        {
            Films.Remove(film);
        }

        public void BouwZaal(Zaal zaal)
        {
            foreach(Zaal z in Zalen)
            {
                if(z.Zaalnummer == zaal.Zaalnummer)
                {
                    throw new NumberAlreadyTakenException("Er is al een zaal met dit nummer");
                }
            }
            Zalen.Add(zaal);
        }

        public void VernietigZaal(Zaal zaal)
        {
            Zalen.Remove(zaal);
        }

        /// <summary>
        /// Voegt een persoon toe aan de lijst
        /// </summary>
        /// <param name="persoon"></param>
        public void VoegPersoonToe(Persoon persoon)
        {
            if (persoon == null) throw new ArgumentNullException("persoon", "persoon mag niet null zijn");
            foreach(Persoon p in Personen)
            {
                if(p is Medewerker && persoon is Medewerker)
                {
                    Medewerker bestaandeMedewerker = p as Medewerker;
                    Medewerker nieuweMedewerker = persoon as Medewerker;
                    if(bestaandeMedewerker.MedewerkerID == nieuweMedewerker.MedewerkerID)
                    {
                        throw new NumberAlreadyTakenException("Andere medewerker heeft hetzelfde Id");
                    }
                }
            }
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

        public Lid LogInLid(string gebruikersnaam, string wachtwoord)
        {
            foreach (Persoon p in Personen)
            {
                if(p is Lid)
                {
                    Lid l = p as Lid;
                    if(l.Gebruikersnaam == gebruikersnaam)
                    {
                        if (l.WachtwoordCorrect(wachtwoord))
                        {
                            return l;
                        }
                    }
                }
            }
            return null;
        }

        public Medewerker LogInMedewerker(int gebruikersnaam, string wachtwoord)
        {
            foreach (Persoon p in Personen)
            {
                if (p is Medewerker)
                {
                    Medewerker m = p as Medewerker;
                    if (m.MedewerkerID == gebruikersnaam)
                    {
                        if (m.WachtwoordCorrect(wachtwoord))
                        {
                            return m;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Saves all personen to a file with the given file name using serialisation.
        /// </summary>
        /// <param name="fileName">The file to write to.</param>
        public void Save(string fileName)
        {
            using (Stream writer = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writer, this);
                writer.Close();
            }
        }

        /// <summary>
        /// Laad een bioscoop uit een textbestand
        /// All personen currently in the administration are removed.
        /// </summary>
        /// <param name="fileName">The file to read from.</param>
        public Bioscoop Load(string fileName)
        {
            using (Stream writer = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Object obj = formatter.Deserialize(writer);
                writer.Close();
                if (obj is Bioscoop)
                {
                    return obj as Bioscoop;
                }
                else return null;
            }
        }
    }
}
