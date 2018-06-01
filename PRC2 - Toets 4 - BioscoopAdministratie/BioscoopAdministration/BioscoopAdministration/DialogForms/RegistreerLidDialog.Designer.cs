namespace BioscoopAdministration
{
    partial class formRegistreer
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
            this.gbPersoonlijk = new System.Windows.Forms.GroupBox();
            this.chbVoorwaarde = new System.Windows.Forms.CheckBox();
            this.dtpGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWoonplaats = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersoonlijk.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersoonlijk
            // 
            this.gbPersoonlijk.Controls.Add(this.chbVoorwaarde);
            this.gbPersoonlijk.Controls.Add(this.dtpGeboortedatum);
            this.gbPersoonlijk.Controls.Add(this.btnRegistreer);
            this.gbPersoonlijk.Controls.Add(this.txtWachtwoord);
            this.gbPersoonlijk.Controls.Add(this.txtGebruikersnaam);
            this.gbPersoonlijk.Controls.Add(this.txtWoonplaats);
            this.gbPersoonlijk.Controls.Add(this.txtAdres);
            this.gbPersoonlijk.Controls.Add(this.txtNaam);
            this.gbPersoonlijk.Controls.Add(this.label6);
            this.gbPersoonlijk.Controls.Add(this.label5);
            this.gbPersoonlijk.Controls.Add(this.label4);
            this.gbPersoonlijk.Controls.Add(this.label3);
            this.gbPersoonlijk.Controls.Add(this.label2);
            this.gbPersoonlijk.Controls.Add(this.label1);
            this.gbPersoonlijk.Location = new System.Drawing.Point(12, 12);
            this.gbPersoonlijk.Name = "gbPersoonlijk";
            this.gbPersoonlijk.Size = new System.Drawing.Size(338, 248);
            this.gbPersoonlijk.TabIndex = 1;
            this.gbPersoonlijk.TabStop = false;
            this.gbPersoonlijk.Text = "Persoonlijke gegevens:";
            // 
            // chbVoorwaarde
            // 
            this.chbVoorwaarde.AutoSize = true;
            this.chbVoorwaarde.Location = new System.Drawing.Point(9, 190);
            this.chbVoorwaarde.Name = "chbVoorwaarde";
            this.chbVoorwaarde.Size = new System.Drawing.Size(244, 17);
            this.chbVoorwaarde.TabIndex = 14;
            this.chbVoorwaarde.Text = "Ik ga akkoord met de algemene voorwaarden.";
            this.chbVoorwaarde.UseVisualStyleBackColor = true;
            this.chbVoorwaarde.CheckedChanged += new System.EventHandler(this.chbVoorwaarde_CheckedChanged);
            // 
            // dtpGeboortedatum
            // 
            this.dtpGeboortedatum.Location = new System.Drawing.Point(123, 100);
            this.dtpGeboortedatum.Name = "dtpGeboortedatum";
            this.dtpGeboortedatum.Size = new System.Drawing.Size(200, 20);
            this.dtpGeboortedatum.TabIndex = 11;
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(9, 213);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(314, 23);
            this.btnRegistreer.TabIndex = 1;
            this.btnRegistreer.Text = "Registreer als lid";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(123, 164);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(200, 20);
            this.txtWachtwoord.TabIndex = 10;
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(123, 134);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(200, 20);
            this.txtGebruikersnaam.TabIndex = 9;
            // 
            // txtWoonplaats
            // 
            this.txtWoonplaats.Location = new System.Drawing.Point(123, 74);
            this.txtWoonplaats.Name = "txtWoonplaats";
            this.txtWoonplaats.Size = new System.Drawing.Size(200, 20);
            this.txtWoonplaats.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(123, 49);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 20);
            this.txtAdres.TabIndex = 7;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(123, 23);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 20);
            this.txtNaam.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wachtwoord:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gebruikersnaam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geboortedatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Woonplaats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // formRegistreer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 275);
            this.Controls.Add(this.gbPersoonlijk);
            this.Name = "formRegistreer";
            this.Text = "Registeer ";
            this.gbPersoonlijk.ResumeLayout(false);
            this.gbPersoonlijk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersoonlijk;
        private System.Windows.Forms.CheckBox chbVoorwaarde;
        private System.Windows.Forms.DateTimePicker dtpGeboortedatum;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtWoonplaats;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}