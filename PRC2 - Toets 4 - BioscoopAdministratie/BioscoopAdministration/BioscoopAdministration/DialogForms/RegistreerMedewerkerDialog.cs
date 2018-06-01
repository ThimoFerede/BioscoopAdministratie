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
    public partial class RegistreerMedewerkerDialog : Form
    {
        Bioscoop bioscoop;
        public RegistreerMedewerkerDialog(Bioscoop b)
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
                int Id = (int)nudId.Value;
                string Wachtwoord = txtWachtwoord.Text;
                try
                {
                    Medewerker NieuweMedewerker = new Medewerker(Naam, Adres, Woonplaats, Geboortedatum, Id, Wachtwoord);
                    bioscoop.VoegPersoonToe(NieuweMedewerker);
                    this.Close();
                }
                catch (NumberAlreadyTakenException ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
