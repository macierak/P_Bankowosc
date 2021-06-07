
namespace PBank {
    partial class FormAwans {
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
            this.Pensja1 = new System.Windows.Forms.Label();
            this.Pensja2 = new System.Windows.Forms.TextBox();
            this.label_nowapensja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Osoba
            // 
            this.Osoba.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Osoba.ForeColor = System.Drawing.Color.DarkCyan;
            this.Osoba.FormattingEnabled = true;
            this.Osoba.ItemHeight = 26;
            this.Osoba.Location = new System.Drawing.Point(25, 27);
            this.Osoba.Name = "Osoba";
            this.Osoba.Size = new System.Drawing.Size(534, 394);
            this.Osoba.TabIndex = 0;
            this.Osoba.Click += new System.EventHandler(this.Osoba_Click);
            // 
            // Pensja1
            // 
            this.Pensja1.AutoSize = true;
            this.Pensja1.Location = new System.Drawing.Point(480, 75);
            this.Pensja1.Name = "Pensja1";
            this.Pensja1.Size = new System.Drawing.Size(0, 13);
            this.Pensja1.TabIndex = 2;
            this.Pensja1.Visible = false;
            // 
            // Pensja2
            // 
            this.Pensja2.BackColor = System.Drawing.Color.DarkCyan;
            this.Pensja2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pensja2.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pensja2.ForeColor = System.Drawing.Color.White;
            this.Pensja2.Location = new System.Drawing.Point(578, 125);
            this.Pensja2.Name = "Pensja2";
            this.Pensja2.Size = new System.Drawing.Size(180, 33);
            this.Pensja2.TabIndex = 3;
            this.Pensja2.Click += new System.EventHandler(this.Pensja2_Click);
            // 
            // label_nowapensja
            // 
            this.label_nowapensja.AutoSize = true;
            this.label_nowapensja.BackColor = System.Drawing.Color.Transparent;
            this.label_nowapensja.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nowapensja.ForeColor = System.Drawing.Color.DarkCyan;
            this.label_nowapensja.Location = new System.Drawing.Point(572, 75);
            this.label_nowapensja.Name = "label_nowapensja";
            this.label_nowapensja.Size = new System.Drawing.Size(94, 33);
            this.label_nowapensja.TabIndex = 6;
            this.label_nowapensja.Text = "Pensja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::PBank.Properties.Resources.arrow_up;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(596, 177);
            this.label1.MinimumSize = new System.Drawing.Size(150, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 80);
            this.label1.TabIndex = 7;
            this.label1.Text = "\r\nAwansuj";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.FormAwans_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // FormAwans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nowapensja);
            this.Controls.Add(this.Pensja2);
            this.Controls.Add(this.Pensja1);
            this.Controls.Add(this.Osoba);
            this.Name = "FormAwans";
            this.Text = "Awans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Osoba;
        private System.Windows.Forms.Label Pensja1;
        private System.Windows.Forms.TextBox Pensja2;
        private System.Windows.Forms.Label label_nowapensja;
        private System.Windows.Forms.Label label1;
    }
}