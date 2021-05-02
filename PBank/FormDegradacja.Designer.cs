
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
            this.components = new System.ComponentModel.Container();
            this.Degraduj = new System.Windows.Forms.Button();
            this.Osoba = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Degraduj
            // 
            this.Degraduj.Location = new System.Drawing.Point(360, 225);
            this.Degraduj.Name = "Degraduj";
            this.Degraduj.Size = new System.Drawing.Size(150, 75);
            this.Degraduj.TabIndex = 1;
            this.Degraduj.Text = "Degraduj!";
            this.Degraduj.UseVisualStyleBackColor = true;
            this.Degraduj.Click += new System.EventHandler(this.Degraduj_Click);
            // 
            // Osoba
            // 
            this.Osoba.FormattingEnabled = true;
            this.Osoba.Location = new System.Drawing.Point(75, 45);
            this.Osoba.Name = "Osoba";
            this.Osoba.Size = new System.Drawing.Size(255, 264);
            this.Osoba.TabIndex = 2;
            this.Osoba.SelectedIndexChanged += new System.EventHandler(this.Osoba_SelectedIndexChanged);
            // 
            // FormDegradacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Osoba);
            this.Controls.Add(this.Degraduj);
            this.Name = "FormDegradacja";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Degraduj;
        private System.Windows.Forms.ListBox Osoba;
    }
}