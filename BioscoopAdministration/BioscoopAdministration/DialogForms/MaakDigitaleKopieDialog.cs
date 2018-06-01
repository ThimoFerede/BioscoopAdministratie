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
    public partial class MaakDigitaleKopieDialog : Form
    {
        Bioscoop bioscoop;
        public MaakDigitaleKopieDialog(Bioscoop b)
        {
            InitializeComponent();
            bioscoop = b;
            GenreCBB.DataSource = Enum.GetValues(typeof(Film.Genre));
        }

        private void MaakDigitaleKopieBTTN_Click(object sender, EventArgs e)
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

            string Titel = TitleTB.Text;
            int Jaar = (int)JaarNUD.Value;
            int Speelduur = (int)SpeelduurNUD.Value;
            string Taal = TaalTB.Text;
            int Leeftijd = (int)LeeftijdNUD.Value;
            List<Film.Genre> Genres = new List<Film.Genre>();
            foreach (object o in GenreLB.Items)
            {
                if (o is Film.Genre)
                {
                    Genres.Add((Film.Genre)o);
                }
            }
            int Toegangscode = (int)ToegangscodeNUD.Value;
            double Prijs = (double)PrijsNUD.Value;

            DigitaleKopie digitaleKopie = new DigitaleKopie(
                Titel,
                Jaar,
                Speelduur,
                Taal,
                Leeftijd,
                Genres,
                Toegangscode,
                Prijs
                );

            bioscoop.VoegFilmToe(digitaleKopie);
            this.Close();
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
    }
}
