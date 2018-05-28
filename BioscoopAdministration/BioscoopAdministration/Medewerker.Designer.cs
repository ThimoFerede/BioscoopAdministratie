namespace BioscoopAdministration
{
    partial class formMedewerker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFilms = new System.Windows.Forms.ListBox();
            this.btnRegistreerLid = new System.Windows.Forms.Button();
            this.btnOntsla = new System.Windows.Forms.Button();
            this.btnVerwijderKopie = new System.Windows.Forms.Button();
            this.btnNeemMedewerkerAan = new System.Windows.Forms.Button();
            this.btnVoegKopieToe = new System.Windows.Forms.Button();
            this.btnVoegVertoningtoe = new System.Windows.Forms.Button();
            this.btnVerwijderVertoning = new System.Windows.Forms.Button();
            this.btnBouwZaal = new System.Windows.Forms.Button();
            this.btnVoegFilmToe = new System.Windows.Forms.Button();
            this.btnVernietigZaal = new System.Windows.Forms.Button();
            this.btnVerwijderFilm = new System.Windows.Forms.Button();
            this.btnVerwijderLid = new System.Windows.Forms.Button();
            this.btnVerwijderBezoeker = new System.Windows.Forms.Button();
            this.btnVoegBezoekerToe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBezoekers = new System.Windows.Forms.ListBox();
            this.lbLeden = new System.Windows.Forms.ListBox();
            this.lbMedewerkers = new System.Windows.Forms.ListBox();
            this.lbDigitaleKopieen = new System.Windows.Forms.ListBox();
            this.lbZalen = new System.Windows.Forms.ListBox();
            this.lbBioscoopvertoningen = new System.Windows.Forms.ListBox();
            this.btnLogUit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFilms
            // 
            this.lbFilms.FormattingEnabled = true;
            this.lbFilms.Location = new System.Drawing.Point(192, 35);
            this.lbFilms.Name = "lbFilms";
            this.lbFilms.Size = new System.Drawing.Size(205, 199);
            this.lbFilms.TabIndex = 0;
            // 
            // btnRegistreerLid
            // 
            this.btnRegistreerLid.Location = new System.Drawing.Point(8, 299);
            this.btnRegistreerLid.Name = "btnRegistreerLid";
            this.btnRegistreerLid.Size = new System.Drawing.Size(178, 23);
            this.btnRegistreerLid.TabIndex = 1;
            this.btnRegistreerLid.Text = "Registreer lid";
            this.btnRegistreerLid.UseVisualStyleBackColor = true;
            // 
            // btnOntsla
            // 
            this.btnOntsla.Location = new System.Drawing.Point(8, 270);
            this.btnOntsla.Name = "btnOntsla";
            this.btnOntsla.Size = new System.Drawing.Size(178, 23);
            this.btnOntsla.TabIndex = 2;
            this.btnOntsla.Text = "Ontsla medewerker";
            this.btnOntsla.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderKopie
            // 
            this.btnVerwijderKopie.Location = new System.Drawing.Point(8, 153);
            this.btnVerwijderKopie.Name = "btnVerwijderKopie";
            this.btnVerwijderKopie.Size = new System.Drawing.Size(178, 23);
            this.btnVerwijderKopie.TabIndex = 3;
            this.btnVerwijderKopie.Text = "Verwijder digitale kopie";
            this.btnVerwijderKopie.UseVisualStyleBackColor = true;
            // 
            // btnNeemMedewerkerAan
            // 
            this.btnNeemMedewerkerAan.Location = new System.Drawing.Point(8, 241);
            this.btnNeemMedewerkerAan.Name = "btnNeemMedewerkerAan";
            this.btnNeemMedewerkerAan.Size = new System.Drawing.Size(178, 23);
            this.btnNeemMedewerkerAan.TabIndex = 4;
            this.btnNeemMedewerkerAan.Text = "Neem medewerker aan";
            this.btnNeemMedewerkerAan.UseVisualStyleBackColor = true;
            this.btnNeemMedewerkerAan.Click += new System.EventHandler(this.btnVoegMedewerkerToe_Click);
            // 
            // btnVoegKopieToe
            // 
            this.btnVoegKopieToe.Location = new System.Drawing.Point(8, 124);
            this.btnVoegKopieToe.Name = "btnVoegKopieToe";
            this.btnVoegKopieToe.Size = new System.Drawing.Size(178, 23);
            this.btnVoegKopieToe.TabIndex = 5;
            this.btnVoegKopieToe.Text = "Voeg digitale kopie toe";
            this.btnVoegKopieToe.UseVisualStyleBackColor = true;
            // 
            // btnVoegVertoningtoe
            // 
            this.btnVoegVertoningtoe.Location = new System.Drawing.Point(8, 66);
            this.btnVoegVertoningtoe.Name = "btnVoegVertoningtoe";
            this.btnVoegVertoningtoe.Size = new System.Drawing.Size(178, 23);
            this.btnVoegVertoningtoe.TabIndex = 6;
            this.btnVoegVertoningtoe.Text = "Voeg bioscoopvertoning toe";
            this.btnVoegVertoningtoe.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderVertoning
            // 
            this.btnVerwijderVertoning.Location = new System.Drawing.Point(8, 95);
            this.btnVerwijderVertoning.Name = "btnVerwijderVertoning";
            this.btnVerwijderVertoning.Size = new System.Drawing.Size(178, 23);
            this.btnVerwijderVertoning.TabIndex = 7;
            this.btnVerwijderVertoning.Text = "Verwijder bioscoopvertoning ";
            this.btnVerwijderVertoning.UseVisualStyleBackColor = true;
            // 
            // btnBouwZaal
            // 
            this.btnBouwZaal.Location = new System.Drawing.Point(8, 182);
            this.btnBouwZaal.Name = "btnBouwZaal";
            this.btnBouwZaal.Size = new System.Drawing.Size(178, 23);
            this.btnBouwZaal.TabIndex = 8;
            this.btnBouwZaal.Text = "Bouw zaal";
            this.btnBouwZaal.UseVisualStyleBackColor = true;
            // 
            // btnVoegFilmToe
            // 
            this.btnVoegFilmToe.Location = new System.Drawing.Point(8, 8);
            this.btnVoegFilmToe.Name = "btnVoegFilmToe";
            this.btnVoegFilmToe.Size = new System.Drawing.Size(178, 23);
            this.btnVoegFilmToe.TabIndex = 9;
            this.btnVoegFilmToe.Text = "Voeg film toe";
            this.btnVoegFilmToe.UseVisualStyleBackColor = true;
            // 
            // btnVernietigZaal
            // 
            this.btnVernietigZaal.BackColor = System.Drawing.Color.Red;
            this.btnVernietigZaal.Location = new System.Drawing.Point(8, 211);
            this.btnVernietigZaal.Name = "btnVernietigZaal";
            this.btnVernietigZaal.Size = new System.Drawing.Size(178, 23);
            this.btnVernietigZaal.TabIndex = 10;
            this.btnVernietigZaal.Text = "Vernietig zaal";
            this.btnVernietigZaal.UseVisualStyleBackColor = false;
            // 
            // btnVerwijderFilm
            // 
            this.btnVerwijderFilm.Location = new System.Drawing.Point(8, 37);
            this.btnVerwijderFilm.Name = "btnVerwijderFilm";
            this.btnVerwijderFilm.Size = new System.Drawing.Size(178, 23);
            this.btnVerwijderFilm.TabIndex = 11;
            this.btnVerwijderFilm.Text = "Verwijder film";
            this.btnVerwijderFilm.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderLid
            // 
            this.btnVerwijderLid.Location = new System.Drawing.Point(8, 328);
            this.btnVerwijderLid.Name = "btnVerwijderLid";
            this.btnVerwijderLid.Size = new System.Drawing.Size(178, 23);
            this.btnVerwijderLid.TabIndex = 12;
            this.btnVerwijderLid.Text = "Vermoord lid";
            this.btnVerwijderLid.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderBezoeker
            // 
            this.btnVerwijderBezoeker.Location = new System.Drawing.Point(8, 386);
            this.btnVerwijderBezoeker.Name = "btnVerwijderBezoeker";
            this.btnVerwijderBezoeker.Size = new System.Drawing.Size(178, 23);
            this.btnVerwijderBezoeker.TabIndex = 13;
            this.btnVerwijderBezoeker.Text = "Verwijder bezoeker";
            this.btnVerwijderBezoeker.UseVisualStyleBackColor = true;
            // 
            // btnVoegBezoekerToe
            // 
            this.btnVoegBezoekerToe.Location = new System.Drawing.Point(8, 357);
            this.btnVoegBezoekerToe.Name = "btnVoegBezoekerToe";
            this.btnVoegBezoekerToe.Size = new System.Drawing.Size(178, 23);
            this.btnVoegBezoekerToe.TabIndex = 14;
            this.btnVoegBezoekerToe.Text = "Voeg bezoeker toe";
            this.btnVoegBezoekerToe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bezoekers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Leden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Medewerkers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Zalen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Digitale kopieën:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bioscoopvertoningen:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Films:";
            // 
            // lbBezoekers
            // 
            this.lbBezoekers.FormattingEnabled = true;
            this.lbBezoekers.Location = new System.Drawing.Point(528, 262);
            this.lbBezoekers.Name = "lbBezoekers";
            this.lbBezoekers.Size = new System.Drawing.Size(162, 147);
            this.lbBezoekers.TabIndex = 22;
            // 
            // lbLeden
            // 
            this.lbLeden.FormattingEnabled = true;
            this.lbLeden.Location = new System.Drawing.Point(360, 262);
            this.lbLeden.Name = "lbLeden";
            this.lbLeden.Size = new System.Drawing.Size(162, 147);
            this.lbLeden.TabIndex = 23;
            // 
            // lbMedewerkers
            // 
            this.lbMedewerkers.FormattingEnabled = true;
            this.lbMedewerkers.Location = new System.Drawing.Point(192, 262);
            this.lbMedewerkers.Name = "lbMedewerkers";
            this.lbMedewerkers.Size = new System.Drawing.Size(162, 147);
            this.lbMedewerkers.TabIndex = 24;
            // 
            // lbDigitaleKopieen
            // 
            this.lbDigitaleKopieen.FormattingEnabled = true;
            this.lbDigitaleKopieen.Location = new System.Drawing.Point(608, 35);
            this.lbDigitaleKopieen.Name = "lbDigitaleKopieen";
            this.lbDigitaleKopieen.Size = new System.Drawing.Size(184, 199);
            this.lbDigitaleKopieen.TabIndex = 25;
            // 
            // lbZalen
            // 
            this.lbZalen.FormattingEnabled = true;
            this.lbZalen.Location = new System.Drawing.Point(696, 262);
            this.lbZalen.Name = "lbZalen";
            this.lbZalen.Size = new System.Drawing.Size(96, 147);
            this.lbZalen.TabIndex = 26;
            // 
            // lbBioscoopvertoningen
            // 
            this.lbBioscoopvertoningen.FormattingEnabled = true;
            this.lbBioscoopvertoningen.Location = new System.Drawing.Point(403, 35);
            this.lbBioscoopvertoningen.Name = "lbBioscoopvertoningen";
            this.lbBioscoopvertoningen.Size = new System.Drawing.Size(199, 199);
            this.lbBioscoopvertoningen.TabIndex = 27;
            // 
            // btnLogUit
            // 
            this.btnLogUit.Location = new System.Drawing.Point(717, 6);
            this.btnLogUit.Name = "btnLogUit";
            this.btnLogUit.Size = new System.Drawing.Size(75, 23);
            this.btnLogUit.TabIndex = 28;
            this.btnLogUit.Text = "Log uit";
            this.btnLogUit.UseVisualStyleBackColor = true;
            // 
            // formMedewerker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 415);
            this.Controls.Add(this.btnLogUit);
            this.Controls.Add(this.lbBioscoopvertoningen);
            this.Controls.Add(this.lbZalen);
            this.Controls.Add(this.lbDigitaleKopieen);
            this.Controls.Add(this.lbMedewerkers);
            this.Controls.Add(this.lbLeden);
            this.Controls.Add(this.lbBezoekers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoegBezoekerToe);
            this.Controls.Add(this.btnVerwijderBezoeker);
            this.Controls.Add(this.btnVerwijderLid);
            this.Controls.Add(this.btnVerwijderFilm);
            this.Controls.Add(this.btnVernietigZaal);
            this.Controls.Add(this.btnVoegFilmToe);
            this.Controls.Add(this.btnBouwZaal);
            this.Controls.Add(this.btnVerwijderVertoning);
            this.Controls.Add(this.btnVoegVertoningtoe);
            this.Controls.Add(this.btnVoegKopieToe);
            this.Controls.Add(this.btnNeemMedewerkerAan);
            this.Controls.Add(this.btnVerwijderKopie);
            this.Controls.Add(this.btnOntsla);
            this.Controls.Add(this.btnRegistreerLid);
            this.Controls.Add(this.lbFilms);
            this.Name = "formMedewerker";
            this.Text = "Welkom medewerker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFilms;
        private System.Windows.Forms.Button btnRegistreerLid;
        private System.Windows.Forms.Button btnOntsla;
        private System.Windows.Forms.Button btnVerwijderKopie;
        private System.Windows.Forms.Button btnNeemMedewerkerAan;
        private System.Windows.Forms.Button btnVoegKopieToe;
        private System.Windows.Forms.Button btnVoegVertoningtoe;
        private System.Windows.Forms.Button btnVerwijderVertoning;
        private System.Windows.Forms.Button btnBouwZaal;
        private System.Windows.Forms.Button btnVoegFilmToe;
        private System.Windows.Forms.Button btnVernietigZaal;
        private System.Windows.Forms.Button btnVerwijderFilm;
        private System.Windows.Forms.Button btnVerwijderLid;
        private System.Windows.Forms.Button btnVerwijderBezoeker;
        private System.Windows.Forms.Button btnVoegBezoekerToe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbBezoekers;
        private System.Windows.Forms.ListBox lbLeden;
        private System.Windows.Forms.ListBox lbMedewerkers;
        private System.Windows.Forms.ListBox lbDigitaleKopieen;
        private System.Windows.Forms.ListBox lbZalen;
        private System.Windows.Forms.ListBox lbBioscoopvertoningen;
        private System.Windows.Forms.Button btnLogUit;
    }
}