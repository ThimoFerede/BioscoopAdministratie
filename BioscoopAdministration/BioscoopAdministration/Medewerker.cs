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
    public partial class formMedewerker : Form
    {
        Medewerker medewerker;
        Bioscoop bioscoop;
        public formMedewerker(Medewerker m, Bioscoop b)
        {
            InitializeComponent();
            medewerker = m;
            bioscoop = b;
            refreshData();
        }

        private void btnVoegMedewerkerToe_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVoegFilmToe_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        public void refreshData()
        {
            foreach(Film f in bioscoop.Films)
            {
                lbFilms.Items.Add(f.Titel);
            }
            foreach (Bioscoopvertoning b in bioscoop.Vertoningen)
            {
                lbBioscoopvertoningen.Items.Add(b);
            }
            foreach (DigitaleKopie d in bioscoop.DigitaleKopieen)
            {
                lbDigitaleKopieen.Items.Add(d);
            }
        }
    }
}
