using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Film
    {
        public string Titel { get; private set; }
        public int Jaar { get; private set; }
        public int Speelduur { get; private set; }
        public string Taal { get; private set; }
        public int Leeftijdscategorie { get; private set; }

        public List<Genre> Genres { get; private set; }
        
        
        public Film(string titel, int jaar, int speelduur, string taal, int leeftijdscategorie, List<Genre> lijstGenres)
        {
            Titel = titel;
            Jaar = jaar;
            Speelduur = speelduur;
            Taal = taal;
            Leeftijdscategorie = leeftijdscategorie;
            if(lijstGenres == null)
            {
                Genres = new List<Genre>();
            }
            else
            {
                Genres = lijstGenres;
            }
        }
        
        public enum Genre
        {
            Animatie,
            Actiefilm,
            Avontuurfilm,
            Drama,
            Familiefilm,
            Fantasyfilm,
            Horrorfilm,
            Komedie,
            Melodrama,
            Misdaadfilm,
            Musicalfilm,
            Muziekfilm,
            Mystery,
            Oorlogsfilm,
            Pyschologische_thriller,
            Rampenfilm,
            Roadmovie,
            Romantische_film,
            Romantische_komedie,
            Sciencefiction,
            Sportfilm,
            Thriller,
            Western
        };
    }
}
