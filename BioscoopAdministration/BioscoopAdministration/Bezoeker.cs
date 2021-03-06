﻿using System;
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
    public partial class formBezoeker : Form
    {
        private Bioscoop Bioscoop;
        public formBezoeker(Bioscoop bioscoop)
        {
            InitializeComponent();
            this.Bioscoop = bioscoop;
            UpdateGuiInfo();
        }

        private void btnBestel_Click(object sender, EventArgs e)
        {
            //Check for errors
            if (string.IsNullOrEmpty(txtNaam.Text)) { MessageBox.Show("Vul een naam in"); txtNaam.Focus(); return; }
            if (string.IsNullOrEmpty(txtAdres.Text)) { MessageBox.Show("Vul een adres in"); txtAdres.Focus(); return; }
            if (string.IsNullOrEmpty(txtWoonplaats.Text)) { MessageBox.Show("Vul een woonplaats in"); txtWoonplaats.Focus(); return; }
            if (lblBioscoopvertoning.SelectedItem == null) { MessageBox.Show("Selecteer een vertoning"); lblBioscoopvertoning.Focus(); return; }
            if(lblStoelen.SelectedItem == null) { MessageBox.Show("Selecteer een stoel"); lblStoelen.Focus(); return; }
            double age = DateTime.Now.Subtract(geboortedatumDTP.Value).TotalDays / 365;
            double minAge = (lblBioscoopvertoning.SelectedItem as Bioscoopvertoning).Leeftijdscategorie;
            if (minAge > age) {MessageBox.Show("Je bent nog te jong voor deze film"); return;}
            if (!txtEmail.Text.Contains('@')) { MessageBox.Show("Incorrect emailadres"); txtEmail.Focus(); return; }

            string naam = txtNaam.Text;
            string adres = txtAdres.Text;
            string woonplaats = txtWoonplaats.Text;
            DateTime geboortedatum = geboortedatumDTP.Value;
            Bezoeker bezoeker = new Bezoeker(naam, adres, woonplaats, geboortedatum);
            Bioscoop.VoegPersoonToe(bezoeker);

            Bestelling bestelling = new Bestelling(bezoeker, lblBioscoopvertoning.SelectedItem as Bioscoopvertoning, lblStoelen.SelectedItem as Stoel);

            MessageBox.Show("Betaal: €" + bestelling.Price);
            this.Close();
        }

        private void UpdateGuiInfo()
        {
            lblBioscoopvertoning.Items.Clear();
            lblStoelen.Items.Clear();
            foreach(Bioscoopvertoning vertoning in Bioscoop.Vertoningen)
            {
                lblBioscoopvertoning.Items.Add(vertoning);
            }
        }

        private void formBezoeker_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void lblBioscoopvertoning_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStoelen.Items.Clear();
            if(lblBioscoopvertoning.SelectedItem is Bioscoopvertoning)
            {
                foreach (Stoel s in (lblBioscoopvertoning.SelectedItem as Bioscoopvertoning).BioscoopZaal.Stoelen)
                {
                    lblStoelen.Items.Add(s);
                }
            }
        }
    }
}
