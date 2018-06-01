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
    public partial class BouwZaalDialog : Form
    {
        Bioscoop bioscoop;

        public BouwZaalDialog(Bioscoop b)
        {
            InitializeComponent();
            bioscoop = b;
            cbFilmkwaliteit.DataSource = Enum.GetValues(typeof(Bioscoopvertoning.Filmkwaliteit));
        }

        private void btnBouwZaal_Click(object sender, EventArgs e)
        {
            int Zaalnummer = (int)nupZaalnummer.Value;
            Bioscoopvertoning.Filmkwaliteit kwaliteit = (Bioscoopvertoning.Filmkwaliteit)cbFilmkwaliteit.SelectedItem;
            int aantalRijen = (int)nupAantalRijen.Value;
            int aantalStoelenRij = (int)nupAantalStoelenRij.Value;
            int aantalVIPRijen = (int)nupAantalVIPRijen.Value;
            int aantalVIPStoelenRij = (int)nupAantalVIPStoelenRij.Value;
            try
            {
                Zaal zaal = new Zaal(Zaalnummer, kwaliteit, aantalRijen, aantalStoelenRij, aantalVIPRijen, aantalVIPStoelenRij);
                bioscoop.BouwZaal(zaal);
                this.Close();
            }
            catch(NumberAlreadyTakenException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
