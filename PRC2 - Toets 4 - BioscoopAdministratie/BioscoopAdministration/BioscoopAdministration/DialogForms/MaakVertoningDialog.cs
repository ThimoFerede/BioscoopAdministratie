using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioscoopAdministration.DialogForms
{
    public partial class MaakVertoningDialog : Form
    {
        Bioscoop bioscoop;
        public MaakVertoningDialog(Bioscoop b)
        {
            InitializeComponent();
            bioscoop = b;
            GenreCBB.DataSource = Enum.GetValues(typeof(Film.Genre));
            KwaliteitCBB.DataSource = Enum.GetValues(typeof(Bioscoopvertoning.Filmkwaliteit));
            foreach(Zaal z in bioscoop.Zalen) { ZaalCBB.Items.Add(z); }
        }

        private void VoegGenreToeBTTN_Click(object sender, EventArgs e)
        {
            GenreLB.Items.Add(GenreCBB.SelectedItem);
        }

        private void VerwijderGenreBTTN_Click(object sender, EventArgs e)
        {
            if (GenreLB.SelectedItem == null)
            {
                MessageBox.Show("Selecteer en genre uit de lijst om te verwijderen");
                return;
            }
            GenreLB.Items.Remove(GenreLB.SelectedItem);
        }

        private void MaakVertoningBTTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTB.Text))
            {
                TitleTB.Focus();
                MessageBox.Show("Geef een titel");
                return;
            }
            if (string.IsNullOrEmpty(TaalTB.Text))
            {
                TaalTB.Focus();
                MessageBox.Show("Geef een taal");
                return;
            }
            if (KwaliteitCBB.SelectedItem == null)
            {
                KwaliteitCBB.Focus();
                MessageBox.Show("Selecteer een kwaliteit");
                return;
            }
            if (ZaalCBB.SelectedItem == null)
            {
                ZaalCBB.Focus();
                MessageBox.Show("Selecteer een zaal");
                return;
            }

            string Titel = TitleTB.Text;
            int Jaar = (int)JaarNUD.Value;
            int Speelduur = (int)SpeelduurNUD.Value;
            string Taal = TaalTB.Text;
            int Leeftijd = (int)LeeftijdNUD.Value;
            List<Film.Genre> Genres = new List<Film.Genre>();
            foreach(object o in GenreLB.Items)
            {
                if(o is Film.Genre)
                {
                    Genres.Add((Film.Genre)o);
                }
            }
            DateTime BeginTijd = BeginTijdDTP.Value;
            Bioscoopvertoning.Filmkwaliteit Kwaliteit = (Bioscoopvertoning.Filmkwaliteit)KwaliteitCBB.SelectedItem;
            Zaal Zaal = (Zaal)ZaalCBB.SelectedItem;
            double Prijs = (double)PrijsNUD.Value;

            Bioscoopvertoning bioscoopvertoning = new Bioscoopvertoning(
                Titel,
                Jaar,
                Speelduur,
                Taal,
                Leeftijd,
                Genres,
                BeginTijd,
                Kwaliteit,
                Zaal,
                Prijs
                );

            bioscoop.VoegFilmToe(bioscoopvertoning);
            this.Close();
        }
    }
}
