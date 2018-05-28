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
    public partial class formLogIn : Form
    {
        public Bioscoop Bios = new Bioscoop("Bios", "Eindhoven");

        public formLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtGebruiker.Text != null && txtWW.Text != null)
            {
                if (rbLid.Checked)
                {
                    Lid l = Bios.LogInLid(txtGebruiker.Text, txtWW.Text);
                    formLeden lid = new formLeden(Bios, l);
                    lid.Show();
                }
                else if (rbMedewerker.Checked)
                {
                    Medewerker m = Bios.LogInMedewerker(Convert.ToInt32(txtGebruiker.Text), txtWW.Text);
                    formMedewerker medewerker = new formMedewerker(m);
                    medewerker.Show();
                }
            }
        }
    }
}
