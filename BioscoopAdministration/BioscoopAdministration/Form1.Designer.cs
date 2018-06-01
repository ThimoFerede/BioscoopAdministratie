namespace BioscoopAdministration
{
    partial class formLogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.gbLogIn = new System.Windows.Forms.GroupBox();
            this.rbLid = new System.Windows.Forms.RadioButton();
            this.rbMedewerker = new System.Windows.Forms.RadioButton();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.btnBestelB = new System.Windows.Forms.Button();
            this.gbLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wachtwoord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gebruikersnaam/Id:";
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.Location = new System.Drawing.Point(110, 61);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(232, 20);
            this.txtGebruiker.TabIndex = 4;
            // 
            // txtWW
            // 
            this.txtWW.Location = new System.Drawing.Point(110, 93);
            this.txtWW.Name = "txtWW";
            this.txtWW.Size = new System.Drawing.Size(232, 20);
            this.txtWW.TabIndex = 5;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(6, 122);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(336, 23);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // gbLogIn
            // 
            this.gbLogIn.Controls.Add(this.txtGebruiker);
            this.gbLogIn.Controls.Add(this.btnLogIn);
            this.gbLogIn.Controls.Add(this.rbLid);
            this.gbLogIn.Controls.Add(this.txtWW);
            this.gbLogIn.Controls.Add(this.rbMedewerker);
            this.gbLogIn.Controls.Add(this.label1);
            this.gbLogIn.Controls.Add(this.label2);
            this.gbLogIn.Location = new System.Drawing.Point(12, 12);
            this.gbLogIn.Name = "gbLogIn";
            this.gbLogIn.Size = new System.Drawing.Size(348, 159);
            this.gbLogIn.TabIndex = 7;
            this.gbLogIn.TabStop = false;
            this.gbLogIn.Text = "Log in";
            // 
            // rbLid
            // 
            this.rbLid.AutoSize = true;
            this.rbLid.Location = new System.Drawing.Point(6, 29);
            this.rbLid.Name = "rbLid";
            this.rbLid.Size = new System.Drawing.Size(92, 17);
            this.rbLid.TabIndex = 0;
            this.rbLid.TabStop = true;
            this.rbLid.Text = "Ik ben een lid.";
            this.rbLid.UseVisualStyleBackColor = true;
            // 
            // rbMedewerker
            // 
            this.rbMedewerker.AutoSize = true;
            this.rbMedewerker.Location = new System.Drawing.Point(202, 29);
            this.rbMedewerker.Name = "rbMedewerker";
            this.rbMedewerker.Size = new System.Drawing.Size(140, 17);
            this.rbMedewerker.TabIndex = 1;
            this.rbMedewerker.TabStop = true;
            this.rbMedewerker.Text = "Ik ben een medewerker.";
            this.rbMedewerker.UseVisualStyleBackColor = true;
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(12, 177);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(129, 23);
            this.btnRegistreer.TabIndex = 8;
            this.btnRegistreer.Text = "Registreer als lid";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            // 
            // btnBestelB
            // 
            this.btnBestelB.Location = new System.Drawing.Point(147, 177);
            this.btnBestelB.Name = "btnBestelB";
            this.btnBestelB.Size = new System.Drawing.Size(213, 23);
            this.btnBestelB.TabIndex = 9;
            this.btnBestelB.Text = "Bestel bioscoopbestelling als bezoeker";
            this.btnBestelB.UseVisualStyleBackColor = true;
            this.btnBestelB.Click += new System.EventHandler(this.btnBestelB_Click);
            // 
            // formLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 213);
            this.Controls.Add(this.btnBestelB);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.gbLogIn);
            this.Name = "formLogIn";
            this.Text = "Log in";
            this.gbLogIn.ResumeLayout(false);
            this.gbLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.GroupBox gbLogIn;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.Button btnBestelB;
        private System.Windows.Forms.RadioButton rbLid;
        private System.Windows.Forms.RadioButton rbMedewerker;
    }
}

