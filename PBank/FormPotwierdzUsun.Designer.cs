
namespace PBank {
    partial class FormPotwierdzUsun {
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
            this.label1 = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.nr_dowodu = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czy na pewno chesz usunąć klienta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.BackColor = System.Drawing.Color.Transparent;
            this.imie.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.ForeColor = System.Drawing.Color.DarkCyan;
            this.imie.Location = new System.Drawing.Point(148, 55);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(62, 26);
            this.imie.TabIndex = 1;
            this.imie.Text = "label2";
            // 
            // pesel
            // 
            this.pesel.AutoSize = true;
            this.pesel.BackColor = System.Drawing.Color.Transparent;
            this.pesel.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pesel.ForeColor = System.Drawing.Color.DarkCyan;
            this.pesel.Location = new System.Drawing.Point(570, 55);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(62, 26);
            this.pesel.TabIndex = 3;
            this.pesel.Text = "label2";
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.BackColor = System.Drawing.Color.Transparent;
            this.adres.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adres.ForeColor = System.Drawing.Color.DarkCyan;
            this.adres.Location = new System.Drawing.Point(148, 96);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(62, 26);
            this.adres.TabIndex = 4;
            this.adres.Text = "label2";
            // 
            // nr_dowodu
            // 
            this.nr_dowodu.AutoSize = true;
            this.nr_dowodu.BackColor = System.Drawing.Color.Transparent;
            this.nr_dowodu.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nr_dowodu.ForeColor = System.Drawing.Color.DarkCyan;
            this.nr_dowodu.Location = new System.Drawing.Point(570, 96);
            this.nr_dowodu.Name = "nr_dowodu";
            this.nr_dowodu.Size = new System.Drawing.Size(64, 26);
            this.nr_dowodu.TabIndex = 5;
            this.nr_dowodu.Text = "label3";
            // 
            // yes
            // 
            this.yes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yes.AutoSize = true;
            this.yes.BackColor = System.Drawing.Color.DarkCyan;
            this.yes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yes.ForeColor = System.Drawing.Color.White;
            this.yes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.yes.Location = new System.Drawing.Point(217, 170);
            this.yes.MinimumSize = new System.Drawing.Size(100, 60);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(100, 60);
            this.yes.TabIndex = 12;
            this.yes.Text = "TAK";
            this.yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.no.AutoSize = true;
            this.no.BackColor = System.Drawing.Color.DarkCyan;
            this.no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.no.ForeColor = System.Drawing.Color.White;
            this.no.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.no.Location = new System.Drawing.Point(376, 170);
            this.no.MinimumSize = new System.Drawing.Size(100, 60);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(100, 60);
            this.no.TabIndex = 13;
            this.no.Text = "NIE";
            this.no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Imię i nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(92, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(510, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pesel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(427, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Numer dowodu";
            // 
            // FormPotwierdzUsun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 239);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.nr_dowodu);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.label1);
            this.Name = "FormPotwierdzUsun";
            this.Text = "Potwierdź";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.Label pesel;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Label nr_dowodu;
        private System.Windows.Forms.Label yes;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}