
namespace PBank {
    partial class FormZatrudnij {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.zatrudnij = new System.Windows.Forms.Button();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.pesel = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.pensja = new System.Windows.Forms.TextBox();
            this.przelozony = new System.Windows.Forms.TextBox();
            this.nr_komputera = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.stanowisko = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // zatrudnij
            // 
            this.zatrudnij.Location = new System.Drawing.Point(90, 285);
            this.zatrudnij.Name = "zatrudnij";
            this.zatrudnij.Size = new System.Drawing.Size(615, 60);
            this.zatrudnij.TabIndex = 0;
            this.zatrudnij.Text = "button1";
            this.zatrudnij.UseVisualStyleBackColor = true;
            this.zatrudnij.Click += new System.EventHandler(this.zatrudnij_Click);
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(45, 45);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(120, 20);
            this.imie.TabIndex = 1;
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(210, 45);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(135, 20);
            this.nazwisko.TabIndex = 2;
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(390, 45);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(120, 20);
            this.pesel.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(225, 195);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(135, 20);
            this.login.TabIndex = 8;
            // 
            // pensja
            // 
            this.pensja.Location = new System.Drawing.Point(480, 105);
            this.pensja.Name = "pensja";
            this.pensja.Size = new System.Drawing.Size(120, 20);
            this.pensja.TabIndex = 7;
            // 
            // przelozony
            // 
            this.przelozony.Location = new System.Drawing.Point(300, 105);
            this.przelozony.Name = "przelozony";
            this.przelozony.Size = new System.Drawing.Size(135, 20);
            this.przelozony.TabIndex = 6;
            // 
            // nr_komputera
            // 
            this.nr_komputera.Location = new System.Drawing.Point(135, 105);
            this.nr_komputera.Name = "nr_komputera";
            this.nr_komputera.Size = new System.Drawing.Size(120, 20);
            this.nr_komputera.TabIndex = 5;
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(420, 195);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(135, 20);
            this.haslo.TabIndex = 9;
            // 
            // stanowisko
            // 
            this.stanowisko.FormattingEnabled = true;
            this.stanowisko.Items.AddRange(new object[] {
            "Asystent",
            "Konsultant",
            "Zarzadca Oddzialu"});
            this.stanowisko.Location = new System.Drawing.Point(570, 30);
            this.stanowisko.Name = "stanowisko";
            this.stanowisko.Size = new System.Drawing.Size(120, 56);
            this.stanowisko.TabIndex = 10;
            // 
            // FormZatrudnij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stanowisko);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pensja);
            this.Controls.Add(this.przelozony);
            this.Controls.Add(this.nr_komputera);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.zatrudnij);
            this.Name = "FormZatrudnij";
            this.Text = "FormZatrudnij";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zatrudnij;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pensja;
        private System.Windows.Forms.TextBox przelozony;
        private System.Windows.Forms.TextBox nr_komputera;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.ListBox stanowisko;
    }
}