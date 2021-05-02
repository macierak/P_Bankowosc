
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
            this.Awansuj = new System.Windows.Forms.Button();
            this.Pensja1 = new System.Windows.Forms.Label();
            this.Pensja2 = new System.Windows.Forms.TextBox();
            this.BrakPensji = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Osoba
            // 
            this.Osoba.FormattingEnabled = true;
            this.Osoba.Location = new System.Drawing.Point(105, 75);
            this.Osoba.Name = "Osoba";
            this.Osoba.Size = new System.Drawing.Size(315, 186);
            this.Osoba.TabIndex = 0;
            this.Osoba.Click += new System.EventHandler(this.Osoba_Click);
            // 
            // Awansuj
            // 
            this.Awansuj.Location = new System.Drawing.Point(435, 150);
            this.Awansuj.Name = "Awansuj";
            this.Awansuj.Size = new System.Drawing.Size(165, 105);
            this.Awansuj.TabIndex = 1;
            this.Awansuj.Text = "Awansuj!";
            this.Awansuj.UseVisualStyleBackColor = true;
            this.Awansuj.Click += new System.EventHandler(this.FormAwans_Click);
            // 
            // Pensja1
            // 
            this.Pensja1.AutoSize = true;
            this.Pensja1.Location = new System.Drawing.Point(435, 75);
            this.Pensja1.Name = "Pensja1";
            this.Pensja1.Size = new System.Drawing.Size(0, 13);
            this.Pensja1.TabIndex = 2;
            // 
            // Pensja2
            // 
            this.Pensja2.Location = new System.Drawing.Point(450, 120);
            this.Pensja2.Name = "Pensja2";
            this.Pensja2.Size = new System.Drawing.Size(210, 20);
            this.Pensja2.TabIndex = 3;
            // 
            // BrakPensji
            // 
            this.BrakPensji.AutoSize = true;
            this.BrakPensji.Location = new System.Drawing.Point(645, 150);
            this.BrakPensji.Name = "BrakPensji";
            this.BrakPensji.Size = new System.Drawing.Size(136, 13);
            this.BrakPensji.TabIndex = 4;
            this.BrakPensji.Text = "Podaj nową wartość pensji!";
            this.BrakPensji.Visible = false;
            // 
            // FormAwans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrakPensji);
            this.Controls.Add(this.Pensja2);
            this.Controls.Add(this.Pensja1);
            this.Controls.Add(this.Awansuj);
            this.Controls.Add(this.Osoba);
            this.Name = "FormAwans";
            this.Text = "FormAwans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Osoba;
        private System.Windows.Forms.Button Awansuj;
        private System.Windows.Forms.Label Pensja1;
        private System.Windows.Forms.TextBox Pensja2;
        private System.Windows.Forms.Label BrakPensji;
    }
}