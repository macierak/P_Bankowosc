
namespace PBank {
    partial class _FormKlient {
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
            this.wplata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nr_dowodu = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.konto = new System.Windows.Forms.Label();
            this.wyplata = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kwota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wplata
            // 
            this.wplata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wplata.AutoSize = true;
            this.wplata.BackColor = System.Drawing.Color.DarkCyan;
            this.wplata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wplata.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wplata.ForeColor = System.Drawing.Color.White;
            this.wplata.Image = global::PBank.Properties.Resources.plus;
            this.wplata.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.wplata.Location = new System.Drawing.Point(186, 304);
            this.wplata.MaximumSize = new System.Drawing.Size(150, 100);
            this.wplata.MinimumSize = new System.Drawing.Size(150, 100);
            this.wplata.Name = "wplata";
            this.wplata.Size = new System.Drawing.Size(150, 100);
            this.wplata.TabIndex = 11;
            this.wplata.Text = "Wpłać\r\n";
            this.wplata.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.wplata.Click += new System.EventHandler(this.wplata_Click);
            this.wplata.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wplata_MouseDown);
            this.wplata.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wplata_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(591, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 78);
            this.label4.TabIndex = 14;
            this.label4.Text = "PBanK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 59);
            this.label3.TabIndex = 15;
            this.label3.Text = "PANEL KLIENTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(437, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Numer dowodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(520, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pesel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(102, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(24, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Imię i nazwisko";
            // 
            // nr_dowodu
            // 
            this.nr_dowodu.AutoSize = true;
            this.nr_dowodu.BackColor = System.Drawing.Color.Transparent;
            this.nr_dowodu.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nr_dowodu.ForeColor = System.Drawing.Color.DarkCyan;
            this.nr_dowodu.Location = new System.Drawing.Point(575, 108);
            this.nr_dowodu.Name = "nr_dowodu";
            this.nr_dowodu.Size = new System.Drawing.Size(64, 26);
            this.nr_dowodu.TabIndex = 21;
            this.nr_dowodu.Text = "label3";
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.BackColor = System.Drawing.Color.Transparent;
            this.adres.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adres.ForeColor = System.Drawing.Color.DarkCyan;
            this.adres.Location = new System.Drawing.Point(158, 149);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(62, 26);
            this.adres.TabIndex = 20;
            this.adres.Text = "label2";
            // 
            // pesel
            // 
            this.pesel.AutoSize = true;
            this.pesel.BackColor = System.Drawing.Color.Transparent;
            this.pesel.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pesel.ForeColor = System.Drawing.Color.DarkCyan;
            this.pesel.Location = new System.Drawing.Point(575, 149);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(62, 26);
            this.pesel.TabIndex = 19;
            this.pesel.Text = "label2";
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.BackColor = System.Drawing.Color.Transparent;
            this.imie.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.ForeColor = System.Drawing.Color.DarkCyan;
            this.imie.Location = new System.Drawing.Point(158, 108);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(62, 26);
            this.imie.TabIndex = 18;
            this.imie.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(48, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Stan konta";
            // 
            // konto
            // 
            this.konto.AutoSize = true;
            this.konto.BackColor = System.Drawing.Color.Transparent;
            this.konto.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konto.ForeColor = System.Drawing.Color.DarkCyan;
            this.konto.Location = new System.Drawing.Point(157, 205);
            this.konto.Name = "konto";
            this.konto.Size = new System.Drawing.Size(81, 33);
            this.konto.TabIndex = 26;
            this.konto.Text = "label2";
            // 
            // wyplata
            // 
            this.wyplata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wyplata.AutoSize = true;
            this.wyplata.BackColor = System.Drawing.Color.DarkCyan;
            this.wyplata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wyplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wyplata.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyplata.ForeColor = System.Drawing.Color.White;
            this.wyplata.Image = global::PBank.Properties.Resources.plus;
            this.wyplata.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.wyplata.Location = new System.Drawing.Point(441, 304);
            this.wyplata.MaximumSize = new System.Drawing.Size(150, 100);
            this.wyplata.MinimumSize = new System.Drawing.Size(150, 100);
            this.wyplata.Name = "wyplata";
            this.wyplata.Size = new System.Drawing.Size(150, 100);
            this.wyplata.TabIndex = 28;
            this.wyplata.Text = "Wypłać\r\n";
            this.wyplata.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.wyplata.Click += new System.EventHandler(this.wyplata_Click);
            this.wyplata.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyplata_MouseDown);
            this.wyplata.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wyplata_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(503, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 26);
            this.label8.TabIndex = 29;
            this.label8.Text = "Kwota";
            // 
            // kwota
            // 
            this.kwota.BackColor = System.Drawing.Color.DarkCyan;
            this.kwota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kwota.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kwota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kwota.Location = new System.Drawing.Point(580, 197);
            this.kwota.Name = "kwota";
            this.kwota.Size = new System.Drawing.Size(162, 40);
            this.kwota.TabIndex = 30;
            // 
            // _FormKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kwota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wyplata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.konto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nr_dowodu);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wplata);
            this.Name = "_FormKlient";
            this.Text = "_FormKlient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormKlient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label wplata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nr_dowodu;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Label pesel;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label konto;
        private System.Windows.Forms.Label wyplata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kwota;
    }
}