namespace BioscoopAdministration.DialogForms
{
    partial class MaakDigitaleKopieDialog
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
            this.MaakDigitaleKopieBTTN = new System.Windows.Forms.Button();
            this.PrijsNUD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.VerwijderGenreBTTN = new System.Windows.Forms.Button();
            this.VoegGenreToeBTTN = new System.Windows.Forms.Button();
            this.GenreCBB = new System.Windows.Forms.ComboBox();
            this.GenreLB = new System.Windows.Forms.ListBox();
            this.LeeftijdNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TaalTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SpeelduurNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.JaarNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToegangscodeNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrijsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeeftijdNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeelduurNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JaarNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToegangscodeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // MaakDigitaleKopieBTTN
            // 
            this.MaakDigitaleKopieBTTN.Location = new System.Drawing.Point(124, 289);
            this.MaakDigitaleKopieBTTN.Name = "MaakDigitaleKopieBTTN";
            this.MaakDigitaleKopieBTTN.Size = new System.Drawing.Size(148, 23);
            this.MaakDigitaleKopieBTTN.TabIndex = 45;
            this.MaakDigitaleKopieBTTN.Text = "Maak digitale kopie";
            this.MaakDigitaleKopieBTTN.UseVisualStyleBackColor = true;
            this.MaakDigitaleKopieBTTN.Click += new System.EventHandler(this.MaakDigitaleKopieBTTN_Click);
            // 
            // PrijsNUD
            // 
            this.PrijsNUD.DecimalPlaces = 2;
            this.PrijsNUD.Location = new System.Drawing.Point(124, 263);
            this.PrijsNUD.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PrijsNUD.Name = "PrijsNUD";
            this.PrijsNUD.Size = new System.Drawing.Size(89, 20);
            this.PrijsNUD.TabIndex = 44;
            this.PrijsNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Prijs per dag:";
            // 
            // VerwijderGenreBTTN
            // 
            this.VerwijderGenreBTTN.Location = new System.Drawing.Point(12, 208);
            this.VerwijderGenreBTTN.Name = "VerwijderGenreBTTN";
            this.VerwijderGenreBTTN.Size = new System.Drawing.Size(106, 23);
            this.VerwijderGenreBTTN.TabIndex = 36;
            this.VerwijderGenreBTTN.Text = "Verwijder";
            this.VerwijderGenreBTTN.UseVisualStyleBackColor = true;
            this.VerwijderGenreBTTN.Click += new System.EventHandler(this.VerwijderGenreBTTN_Click);
            // 
            // VoegGenreToeBTTN
            // 
            this.VoegGenreToeBTTN.Location = new System.Drawing.Point(12, 163);
            this.VoegGenreToeBTTN.Name = "VoegGenreToeBTTN";
            this.VoegGenreToeBTTN.Size = new System.Drawing.Size(106, 23);
            this.VoegGenreToeBTTN.TabIndex = 35;
            this.VoegGenreToeBTTN.Text = "Voeg toe";
            this.VoegGenreToeBTTN.UseVisualStyleBackColor = true;
            this.VoegGenreToeBTTN.Click += new System.EventHandler(this.VoegGenreToeBTTN_Click);
            // 
            // GenreCBB
            // 
            this.GenreCBB.FormattingEnabled = true;
            this.GenreCBB.Location = new System.Drawing.Point(12, 136);
            this.GenreCBB.Name = "GenreCBB";
            this.GenreCBB.Size = new System.Drawing.Size(106, 21);
            this.GenreCBB.TabIndex = 34;
            // 
            // GenreLB
            // 
            this.GenreLB.FormattingEnabled = true;
            this.GenreLB.Location = new System.Drawing.Point(124, 136);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.Size = new System.Drawing.Size(148, 95);
            this.GenreLB.TabIndex = 33;
            // 
            // LeeftijdNUD
            // 
            this.LeeftijdNUD.Location = new System.Drawing.Point(124, 110);
            this.LeeftijdNUD.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.LeeftijdNUD.Name = "LeeftijdNUD";
            this.LeeftijdNUD.Size = new System.Drawing.Size(89, 20);
            this.LeeftijdNUD.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "leeftijdscategorie:";
            // 
            // TaalTB
            // 
            this.TaalTB.Location = new System.Drawing.Point(124, 84);
            this.TaalTB.Name = "TaalTB";
            this.TaalTB.Size = new System.Drawing.Size(148, 20);
            this.TaalTB.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Taal:";
            // 
            // SpeelduurNUD
            // 
            this.SpeelduurNUD.Location = new System.Drawing.Point(124, 58);
            this.SpeelduurNUD.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.SpeelduurNUD.Name = "SpeelduurNUD";
            this.SpeelduurNUD.Size = new System.Drawing.Size(89, 20);
            this.SpeelduurNUD.TabIndex = 28;
            this.SpeelduurNUD.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Speelduur (min):";
            // 
            // JaarNUD
            // 
            this.JaarNUD.Location = new System.Drawing.Point(124, 32);
            this.JaarNUD.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.JaarNUD.Minimum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.JaarNUD.Name = "JaarNUD";
            this.JaarNUD.Size = new System.Drawing.Size(89, 20);
            this.JaarNUD.TabIndex = 26;
            this.JaarNUD.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Jaar:";
            // 
            // TitleTB
            // 
            this.TitleTB.Location = new System.Drawing.Point(124, 6);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(148, 20);
            this.TitleTB.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Titel:";
            // 
            // ToegangscodeNUD
            // 
            this.ToegangscodeNUD.Location = new System.Drawing.Point(124, 237);
            this.ToegangscodeNUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ToegangscodeNUD.Name = "ToegangscodeNUD";
            this.ToegangscodeNUD.Size = new System.Drawing.Size(89, 20);
            this.ToegangscodeNUD.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Toegangscode:";
            // 
            // MaakDigitaleKopieDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.ToegangscodeNUD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaakDigitaleKopieBTTN);
            this.Controls.Add(this.PrijsNUD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.VerwijderGenreBTTN);
            this.Controls.Add(this.VoegGenreToeBTTN);
            this.Controls.Add(this.GenreCBB);
            this.Controls.Add(this.GenreLB);
            this.Controls.Add(this.LeeftijdNUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaalTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpeelduurNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JaarNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTB);
            this.Controls.Add(this.label1);
            this.Name = "MaakDigitaleKopieDialog";
            this.Text = "MaakDigitaleKopieDialog";
            ((System.ComponentModel.ISupportInitialize)(this.PrijsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeeftijdNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeelduurNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JaarNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToegangscodeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MaakDigitaleKopieBTTN;
        private System.Windows.Forms.NumericUpDown PrijsNUD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button VerwijderGenreBTTN;
        private System.Windows.Forms.Button VoegGenreToeBTTN;
        private System.Windows.Forms.ComboBox GenreCBB;
        private System.Windows.Forms.ListBox GenreLB;
        private System.Windows.Forms.NumericUpDown LeeftijdNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TaalTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SpeelduurNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown JaarNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ToegangscodeNUD;
        private System.Windows.Forms.Label label7;
    }
}