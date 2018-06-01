using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioscoopAdministration.DialogForms;

namespace BioscoopAdministration
{
    public partial class formLogIn : Form
    {
        public Bioscoop Bios;

        public formLogIn()
        {
            InitializeComponent();
            Bios = new Bioscoop("Bios", "Eindhoven");
            Bios.MaakStandaardBioscoop();
        }

        public formLogIn(Bioscoop b)
        {
            InitializeComponent();
            Bios = b;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtGebruiker.Text != null && txtWW.Text != null)
            {
                if (rbLid.Checked)
                {
                    Lid l = Bios.LogInLid(txtGebruiker.Text, txtWW.Text);
                    if (l != null)
                    {
                        formLeden lid = new formLeden(Bios, l);
                        lid.Show();
                    }
                    else MessageBox.Show("Inloggegevens onjuist");
                }
                else if (rbMedewerker.Checked)
                {
                    try
                    {
                        Medewerker m = Bios.LogInMedewerker(Convert.ToInt32(txtGebruiker.Text), txtWW.Text);
                        if (m != null)
                        {
                            formMedewerker medewerker = new formMedewerker(m, Bios);
                            medewerker.Show();
                        }
                        else MessageBox.Show("Inloggegevens onjuist");
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Inloggegevens onjuist");
                    }
                }
            }
        }

        private void btnBestelB_Click(object sender, EventArgs e)
        {
            formBezoeker formBezoeker = new formBezoeker(Bios);
            formBezoeker.Show();
        }

        private void formLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            formRegistreer form = new formRegistreer(Bios);
            form.Show();
        }
    }
}
