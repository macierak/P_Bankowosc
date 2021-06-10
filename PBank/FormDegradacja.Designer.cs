
namespace PBank {
    partial class FormDegradacja {
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
            this.Osoba = new System.Windows.Forms.ListBox();
            this.tekst_pensja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nowapensja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Osoba
            // 
            this.Osoba.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Osoba.ForeColor = System.Drawing.Color.DarkCyan;
            this.Osoba.FormattingEnabled = true;
            this.Osoba.ItemHeight = 26;
            this.Osoba.Location = new System.Drawing.Point(28, 102);
            this.Osoba.Name = "Osoba";
            this.Osoba.Size = new System.Drawing.Size(520, 316);
            this.Osoba.TabIndex = 2;
            this.Osoba.SelectedIndexChanged += new System.EventHandler(this.Osoba_SelectedIndexChanged);
            // 
            // tekst_pensja
            // 
            this.tekst_pensja.BackColor = System.Drawing.Color.DarkCyan;
            this.tekst_pensja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tekst_pensja.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tekst_pensja.ForeColor = System.Drawing.Color.White;
            this.tekst_pensja.Location = new System.Drawing.Point(593, 92);
            this.tekst_pensja.Name = "tekst_pensja";
            this.tekst_pensja.Size = new System.Drawing.Size(170, 33);
            this.tekst_pensja.TabIndex = 3;
            this.tekst_pensja.Click += new System.EventHandler(this.tekst_pensja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::PBank.Properties.Resources.arrow_down;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(603, 157);
            this.label1.MinimumSize = new System.Drawing.Size(150, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "\r\nDegraduj";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Degraduj_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // label_nowapensja
            // 
            this.label_nowapensja.AutoSize = true;
            this.label_nowapensja.BackColor = System.Drawing.Color.Transparent;
            this.label_nowapensja.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nowapensja.ForeColor = System.Drawing.Color.DarkCyan;
            this.label_nowapensja.Location = new System.Drawing.Point(587, 47);
            this.label_nowapensja.Name = "label_nowapensja";
            this.label_nowapensja.Size = new System.Drawing.Size(94, 33);
            this.label_nowapensja.TabIndex = 7;
            this.label_nowapensja.Text = "Pensja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 59);
            this.label4.TabIndex = 9;
            this.label4.Text = "DEGRADACJA";
            // 
            // FormDegradacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_nowapensja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tekst_pensja);
            this.Controls.Add(this.Osoba);
            this.Name = "FormDegradacja";
            this.Text = "Degradacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Osoba;
        private System.Windows.Forms.TextBox tekst_pensja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nowapensja;
        private System.Windows.Forms.Label label4;
    }
}