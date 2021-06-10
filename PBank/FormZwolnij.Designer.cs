namespace PBank {
    partial class FormZwolnij {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZwolnij));
            this.Osoba = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Zwolnienie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Osoba
            // 
            this.Osoba.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Osoba.ForeColor = System.Drawing.Color.DarkCyan;
            this.Osoba.FormattingEnabled = true;
            this.Osoba.ItemHeight = 26;
            this.Osoba.Location = new System.Drawing.Point(32, 92);
            this.Osoba.Name = "Osoba";
            this.Osoba.Size = new System.Drawing.Size(416, 316);
            this.Osoba.TabIndex = 0;
            this.Osoba.Click += new System.EventHandler(this.Osoba_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 59);
            this.label4.TabIndex = 8;
            this.label4.Text = "ZWOLNIENIE";
            // 
            // Zwolnienie
            // 
            this.Zwolnienie.AutoSize = true;
            this.Zwolnienie.BackColor = System.Drawing.Color.DarkCyan;
            this.Zwolnienie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Zwolnienie.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zwolnienie.ForeColor = System.Drawing.Color.White;
            this.Zwolnienie.Image = ((System.Drawing.Image)(resources.GetObject("Zwolnienie.Image")));
            this.Zwolnienie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Zwolnienie.Location = new System.Drawing.Point(551, 171);
            this.Zwolnienie.MaximumSize = new System.Drawing.Size(150, 100);
            this.Zwolnienie.MinimumSize = new System.Drawing.Size(150, 100);
            this.Zwolnienie.Name = "Zwolnienie";
            this.Zwolnienie.Size = new System.Drawing.Size(150, 100);
            this.Zwolnienie.TabIndex = 12;
            this.Zwolnienie.Text = "Zwolnij\r\n";
            this.Zwolnienie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Zwolnienie.Click += new System.EventHandler(this.zwolnij_Click);
            // 
            // FormZwolnij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zwolnienie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Osoba);
            this.Name = "FormZwolnij";
            this.Text = "Zwolnienie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Osoba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Zwolnienie;
    }
}