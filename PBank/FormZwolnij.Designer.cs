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
            this.Osoba = new System.Windows.Forms.ListBox();
            this.zwolnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Osoba
            // 
            this.Osoba.FormattingEnabled = true;
            this.Osoba.Location = new System.Drawing.Point(113, 75);
            this.Osoba.Name = "Osoba";
            this.Osoba.Size = new System.Drawing.Size(205, 199);
            this.Osoba.TabIndex = 0;
            this.Osoba.Click += new System.EventHandler(this.Osoba_SelectedIndexChanged);
            // 
            // zwolnij
            // 
            this.zwolnij.Location = new System.Drawing.Point(417, 162);
            this.zwolnij.Name = "zwolnij";
            this.zwolnij.Size = new System.Drawing.Size(217, 40);
            this.zwolnij.TabIndex = 1;
            this.zwolnij.Text = "Zwolnij";
            this.zwolnij.UseVisualStyleBackColor = true;
            this.zwolnij.Click += new System.EventHandler(this.zwolnij_Click);
            // 
            // FormZwolnij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zwolnij);
            this.Controls.Add(this.Osoba);
            this.Name = "FormZwolnij";
            this.Text = "FormZwolnij";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Osoba;
        private System.Windows.Forms.Button zwolnij;
    }
}