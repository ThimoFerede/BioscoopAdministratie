using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration
{
    public partial class formLeden : Form
    {
        public Lid lid;
        public Bioscoop Bios;

        public formLeden(Bioscoop b, Lid l)
        {
            InitializeComponent();
            Bios = b;
            lid = l;
            ShowInfo();
        }
        
        private void formLeden_Load(object sender, EventArgs e)
        {

        }

        private void ShowInfo()
        {
            txtNaam.Text = lid.Naam;
            txtAdres.Text = lid.Adres;
            txtWoonplaats.Text = lid.Woonplaats;
            lblGeboortedatum.Text = lid.Geboortedatum.ToString();
            txtGebruikersnaam.Text = lid.Gebruikersnaam;

            foreach (Bestelling b in lid.Bestellingen)
            {
                lbGeschiedenis.Items.Add(b);
            }
            foreach (Uitlening u in lid.Uitleningen)
            {
                lbGeschiedenis.Items.Add(u);
            }

            foreach (Film f in Bios.Films)
            {
                lbGeschiedenis.Items.Add(f);
            }
        }

        private void btnBestelBV_Click(object sender, EventArgs e)
        {
            if(lbFilms.SelectedItem is Bioscoopvertoning)
            {
                Bioscoopvertoning selectedBV = (Bioscoopvertoning)lbFilms.SelectedItem;
                Stoel selectedStoel = (Stoel)lbStoel.SelectedItem;
                Bestelling bestelling = new Bestelling(lid, selectedBV, selectedStoel);
                MessageBox.Show("Betaal €" + bestelling.Price);
                ShowInfo();
            }
            else
            {
                MessageBox.Show("Deze film draait momenteel niet in de bioscoop.");
            }
        }

        private void btnLeenuit_Click(object sender, EventArgs e)
        {
            if (lbFilms.SelectedItem is DigitaleKopie)
            {
                DigitaleKopie selectedDK = (DigitaleKopie)lbFilms.SelectedItem;
                Uitlening uitlening = new Uitlening(DateTime.Now, DateTime.Now.AddDays(2), selectedDK, lid);
                MessageBox.Show("Betaal €" + uitlening.Price);
                ShowInfo();
            }
            else
            {
                MessageBox.Show("Van deze film is nog geen ditigale kopie beschikbaar.");
            }
        }

        private void ShowStoel()
        {
            if(lbFilms.SelectedItem is Bioscoopvertoning)
            {
                Bioscoopvertoning bv = (Bioscoopvertoning)lbFilms.SelectedItem;
                foreach(Stoel stoel in bv.BioscoopZaal.Stoelen)
                {
                    foreach(Bestelling b in bv.Bestellingen)
                    {
                        if(stoel != b.Stoel)
                        {
                            lbStoel.Items.Add(stoel);
                        }
                    }
                }
            }
        }

        private void lbFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStoel();
        }
        
        private void btnLogUit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
