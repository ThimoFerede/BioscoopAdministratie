namespace BioscoopAdministration
{
    partial class formBezoeker
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
            this.lblBioscoopvertoning = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtWoonplaats = new System.Windows.Forms.TextBox();
            this.btnBestel = new System.Windows.Forms.Button();
            this.gbPersoonlijk = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStoelen = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.gbPersoonlijk.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBioscoopvertoning
            // 
            this.lblBioscoopvertoning.FormattingEnabled = true;
            this.lblBioscoopvertoning.Location = new System.Drawing.Point(12, 27);
            this.lblBioscoopvertoning.Name = "lblBioscoopvertoning";
            this.lblBioscoopvertoning.Size = new System.Drawing.Size(171, 225);
            this.lblBioscoopvertoning.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bioscoopvertoningen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Naam:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Woonplaats:";
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
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(94, 23);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 6;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(94, 49);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 7;
            // 
            // txtWoonplaats
            // 
            this.txtWoonplaats.Location = new System.Drawing.Point(94, 74);
            this.txtWoonplaats.Name = "txtWoonplaats";
            this.txtWoonplaats.Size = new System.Drawing.Size(100, 20);
            this.txtWoonplaats.TabIndex = 8;
            // 
            // btnBestel
            // 
            this.btnBestel.Location = new System.Drawing.Point(9, 211);
            this.btnBestel.Name = "btnBestel";
            this.btnBestel.Size = new System.Drawing.Size(185, 23);
            this.btnBestel.TabIndex = 1;
            this.btnBestel.Text = "Bestel bioscoopvertoning";
            this.btnBestel.UseVisualStyleBackColor = true;
            // 
            // gbPersoonlijk
            // 
            this.gbPersoonlijk.Controls.Add(this.lblBedrag);
            this.gbPersoonlijk.Controls.Add(this.label6);
            this.gbPersoonlijk.Controls.Add(this.dateTimePicker1);
            this.gbPersoonlijk.Controls.Add(this.btnBestel);
            this.gbPersoonlijk.Controls.Add(this.txtWoonplaats);
            this.gbPersoonlijk.Controls.Add(this.txtAdres);
            this.gbPersoonlijk.Controls.Add(this.txtNaam);
            this.gbPersoonlijk.Controls.Add(this.label4);
            this.gbPersoonlijk.Controls.Add(this.label3);
            this.gbPersoonlijk.Controls.Add(this.label2);
            this.gbPersoonlijk.Controls.Add(this.label7);
            this.gbPersoonlijk.Location = new System.Drawing.Point(322, 12);
            this.gbPersoonlijk.Name = "gbPersoonlijk";
            this.gbPersoonlijk.Size = new System.Drawing.Size(222, 240);
            this.gbPersoonlijk.TabIndex = 2;
            this.gbPersoonlijk.TabStop = false;
            this.gbPersoonlijk.Text = "Persoonlijke gegevens:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stoelen:";
            // 
            // lblStoelen
            // 
            this.lblStoelen.FormattingEnabled = true;
            this.lblStoelen.Location = new System.Drawing.Point(189, 27);
            this.lblStoelen.Name = "lblStoelen";
            this.lblStoelen.Size = new System.Drawing.Size(120, 225);
            this.lblStoelen.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bedrag:";
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(91, 158);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(0, 13);
            this.lblBedrag.TabIndex = 14;
            // 
            // formBezoeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 261);
            this.Controls.Add(this.lblStoelen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbPersoonlijk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBioscoopvertoning);
            this.Name = "formBezoeker";
            this.Text = "Bestel bioscoopvertoning";
            this.gbPersoonlijk.ResumeLayout(false);
            this.gbPersoonlijk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblBioscoopvertoning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtWoonplaats;
        private System.Windows.Forms.Button btnBestel;
        private System.Windows.Forms.GroupBox gbPersoonlijk;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lblStoelen;
    }
}