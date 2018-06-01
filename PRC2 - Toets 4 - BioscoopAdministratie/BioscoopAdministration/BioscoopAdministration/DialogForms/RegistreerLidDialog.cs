using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioscoopAdministration
{
    public partial class formRegistreer : Form
    {
        Bioscoop bioscoop;
        public formRegistreer(Bioscoop b)
        {
            InitializeComponent();
            bioscoop = b;
            btnRegistreer.Enabled = false;
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaam.Text))
            {
                MessageBox.Show("Vul een naam in");
                txtNaam.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAdres.Text))
            {
                MessageBox.Show("Vul een adres in");
                txtAdres.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWoonplaats.Text))
            {
                MessageBox.Show("Vul een woonplaats in");
                txtWoonplaats.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtGebruikersnaam.Text))
            {
                MessageBox.Show("Vul een gebruikersnaam in");
                txtGebruikersnaam.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWachtwoord.Text))
            {
                MessageBox.Show("Vul een wachtwoord in");
                txtWachtwoord.Focus();
                return;
            }
            if (chbVoorwaarde.Checked)
            {
                string Naam = txtNaam.Text;
                string Adres = txtAdres.Text;
                string Woonplaats = txtWoonplaats.Text;
                DateTime Geboortedatum = dtpGeboortedatum.Value;
                string Gebruikersnaam = txtGebruikersnaam.Text;
                string Wachtwoord = txtWachtwoord.Text;
                Lid NieuwLid = new Lid(Naam, Adres, Woonplaats, Geboortedatum, Gebruikersnaam, Wachtwoord);
                bioscoop.VoegPersoonToe(NieuwLid);
                this.Close();
            }
        }

        private void chbVoorwaarde_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVoorwaarde.Checked)
            {
                btnRegistreer.Enabled = true;
            }
            else btnRegistreer.Enabled = false;
        }
    }
}
