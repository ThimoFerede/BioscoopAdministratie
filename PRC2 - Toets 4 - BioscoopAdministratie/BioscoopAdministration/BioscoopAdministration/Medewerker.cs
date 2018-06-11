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
using BioscoopAdministration.DialogForms;
using System.IO;
using System.Runtime.Serialization;

namespace BioscoopAdministration
{
    public partial class formMedewerker : Form
    {
        Medewerker medewerker;
        Bioscoop bioscoop;
        List<object> SelectedItems;
        object selectedItem;
        public formMedewerker(Medewerker m, Bioscoop b)
        {
            InitializeComponent();
            SelectedItems = new List<object>();
            medewerker = m;
            bioscoop = b;
            refreshData();
        }

        private void btnVoegMedewerkerToe_Click(object sender, EventArgs e)
        {
            RegistreerMedewerkerDialog medewerkerDialog = new RegistreerMedewerkerDialog(bioscoop);
            medewerkerDialog.Show();
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
            lbBioscoopvertoningen.Items.Clear();
            lbDigitaleKopieen.Items.Clear();
            lbLeden.Items.Clear();
            lbMedewerkers.Items.Clear();
            lbBezoekers.Items.Clear();
            lbZalen.Items.Clear();
            foreach (Bioscoopvertoning b in bioscoop.Vertoningen)
            {
                lbBioscoopvertoningen.Items.Add(b);
            }
            foreach (DigitaleKopie d in bioscoop.DigitaleKopieen)
            {
                lbDigitaleKopieen.Items.Add(d);
            }
            foreach(Persoon p in bioscoop.Personen)
            {
                if (p is Medewerker) lbMedewerkers.Items.Add(p as Medewerker);
                else if (p is Bezoeker) lbBezoekers.Items.Add(p as Bezoeker);
                else if (p is Lid) lbLeden.Items.Add(p as Lid);
            }
            foreach(Zaal z in bioscoop.Zalen)
            {
                lbZalen.Items.Add(z);
            }
        }

        private void ShowInfo()
        {
            InfoLB.Items.Clear();
            InfoLBL.Text = "Selecteer een item voor informatie";
            InfoLB.Enabled = false;
            if (selectedItem != null)
            {
                if (selectedItem is IInfo)
                {
                    IInfo info = selectedItem as IInfo;
                    InfoLBL.Text = info.InfoString;
                    if(info.InfoLijstNaam.Length > 0)
                    {
                        InfoLB.Items.Add(info.InfoLijstNaam);
                        foreach (object o in info.InfoLijst)
                        {
                            InfoLB.Items.Add(o);
                        }
                        InfoLB.Enabled = true;
                    }
                }
            }
        }

        private void lbBioscoopvertoningen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBioscoopvertoningen.SelectedItem == null) return;
            selectedItem = lbBioscoopvertoningen.SelectedItem;
            SelectedItems.Add(selectedItem);
            ShowInfo();
        }

        private void lbDigitaleKopieen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDigitaleKopieen.SelectedItem == null) return;
            selectedItem = lbDigitaleKopieen.SelectedItem;
            SelectedItems.Add(selectedItem);
            ShowInfo();
        }

        private void lbMedewerkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMedewerkers.SelectedItem == null) return;
            selectedItem = lbMedewerkers.SelectedItem;
            SelectedItems.Add(selectedItem);
            ShowInfo();
        }

        private void lbLeden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLeden.SelectedItem == null) return;
            selectedItem = lbLeden.SelectedItem;
            SelectedItems.Add(selectedItem);
            ShowInfo();
        }

        private void lbBezoekers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBezoekers.SelectedItem == null) return;
            selectedItem = lbBezoekers.SelectedItem;
            ShowInfo();
        }

        private void lbZalen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbZalen.SelectedItem == null) return;
            selectedItem = lbZalen.SelectedItem;
            SelectedItems.Add(selectedItem);
            ShowInfo();
        }

        private void InfoLB_DoubleClick(object sender, EventArgs e)
        {
            if (InfoLB.SelectedItem == null) return;
            selectedItem = InfoLB.SelectedItem;
            SelectedItems.Add(selectedItem);
            ShowInfo();
        }

        private void VorigSelectedItem()
        {
            if(SelectedItems.Count > 1)
            {
                SelectedItems.RemoveAt(SelectedItems.Count - 1);
                selectedItem = SelectedItems[SelectedItems.Count - 1];
                ShowInfo();
            }
        }

        private void btnLogUit_Click(object sender, EventArgs e)
        {
            //to do: loguit functie
        }

        private void btnVoegVertoningtoe_Click(object sender, EventArgs e)
        {
            MaakVertoningDialog vertoningDialog = new MaakVertoningDialog(bioscoop);
            vertoningDialog.Show();
        }

        private void btnVoegBezoekerToe_Click(object sender, EventArgs e)
        {
            formBezoeker formBezoeker = new formBezoeker(bioscoop);
            formBezoeker.Show();
        }

        private void btnVerwijderVertoning_Click(object sender, EventArgs e)
        {
            if(lbBioscoopvertoningen.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een bioscoopvertoning uit de lijst");
                lbBioscoopvertoningen.Focus();
                return;
            }
            if(lbBioscoopvertoningen.SelectedItem is Bioscoopvertoning)
            {
                Bioscoopvertoning vertoning = lbBioscoopvertoningen.SelectedItem as Bioscoopvertoning;
                bioscoop.VerwijderFilm(vertoning);
                refreshData();
            }
        }

        private void btnVerwijderKopie_Click(object sender, EventArgs e)
        {
            if (lbDigitaleKopieen.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een digitale kopie uit de lijst");
                lbDigitaleKopieen.Focus();
                return;
            }
            if (lbDigitaleKopieen.SelectedItem is DigitaleKopie)
            {
                DigitaleKopie kopie = lbDigitaleKopieen.SelectedItem as DigitaleKopie;
                bioscoop.VerwijderFilm(kopie);
                refreshData();
            }
        }

        private void btnVernietigZaal_Click(object sender, EventArgs e)
        {
            if (lbZalen.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een zaal uit de lijst");
                lbZalen.Focus();
                return;
            }
            if (lbZalen.SelectedItem is Zaal)
            {
                Zaal zaal = lbZalen.SelectedItem as Zaal;
                bioscoop.VernietigZaal(zaal);
                refreshData();
            }
        }

        private void btnOntsla_Click(object sender, EventArgs e)
        {
            if (lbMedewerkers.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een medewerker uit de lijst");
                lbMedewerkers.Focus();
                return;
            }
            if (lbMedewerkers.SelectedItem is Medewerker)
            {
                Medewerker medewerker = lbMedewerkers.SelectedItem as Medewerker;
                bioscoop.VerwijderPersoon(medewerker);
                refreshData();
            }
        }

        private void btnVerwijderLid_Click(object sender, EventArgs e)
        {
            if (lbLeden.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een lid uit de lijst");
                lbLeden.Focus();
                return;
            }
            if (lbLeden.SelectedItem is Lid)
            {
                Lid lid = lbLeden.SelectedItem as Lid;
                bioscoop.VerwijderPersoon(lid);
                refreshData();
            }
        }

        private void btnVerwijderBezoeker_Click(object sender, EventArgs e)
        {
            if (lbBezoekers.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een bezoeker uit de lijst");
                lbBezoekers.Focus();
                return;
            }
            if (lbDigitaleKopieen.SelectedItem is Bezoeker)
            {
                Bezoeker bezoeker = lbBezoekers.SelectedItem as Bezoeker;
                bioscoop.VerwijderPersoon(bezoeker);
                refreshData();
            }
        }

        private void btnRegistreerLid_Click(object sender, EventArgs e)
        {
            formRegistreer form = new formRegistreer(bioscoop);
            form.Show();
        }

        private void VorigeBTTN_Click(object sender, EventArgs e)
        {
            VorigSelectedItem();
        }

        private void btnVoegKopieToe_Click(object sender, EventArgs e)
        {
            MaakDigitaleKopieDialog digitaleKopieDialog = new MaakDigitaleKopieDialog(bioscoop);
            digitaleKopieDialog.Show();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

        }

        private void loadMS_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                if (fileInfo.Extension == ".txt")
                {
                    try
                    {
                        Bioscoop NewBioscoop = bioscoop.Load(fileInfo.FullName);
                        if (NewBioscoop != null) bioscoop = NewBioscoop;
                        else
                        {
                            MessageBox.Show("Loading failed");
                        }
                        ShowInfo();
                        refreshData();
                        MessageBox.Show("Loading completed");
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Select a .txt file");
                }
            }
        }

        private void saveMS_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bioscoop.Save(saveFileDialog.FileName);
                    ShowInfo();
                    MessageBox.Show("Saving completed");
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnBouwZaal_Click(object sender, EventArgs e)
        {
            BouwZaalDialog zaalDialog = new BouwZaalDialog(bioscoop);
            zaalDialog.Show();
        }
    }
}
