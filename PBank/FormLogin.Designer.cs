namespace PBank {
    partial class FormLogin {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.logowanie = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wrongpass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.haslo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logowanie
            // 
            this.logowanie.Location = new System.Drawing.Point(408, 214);
            this.logowanie.Name = "logowanie";
            this.logowanie.Size = new System.Drawing.Size(309, 67);
            this.logowanie.TabIndex = 0;
            this.logowanie.Text = "button1";
            this.logowanie.UseVisualStyleBackColor = true;
            this.logowanie.Click += new System.EventHandler(this.logowanie_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(479, 127);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(237, 20);
            this.login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // wrongpass
            // 
            this.wrongpass.AutoSize = true;
            this.wrongpass.ForeColor = System.Drawing.Color.Maroon;
            this.wrongpass.Location = new System.Drawing.Point(476, 184);
            this.wrongpass.Name = "wrongpass";
            this.wrongpass.Size = new System.Drawing.Size(156, 13);
            this.wrongpass.TabIndex = 5;
            this.wrongpass.Text = "Nieprawidłowe dane logowania";
            this.wrongpass.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBank.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(58, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(479, 161);
            this.haslo.Name = "haslo";
            this.haslo.PasswordChar = '*';
            this.haslo.Size = new System.Drawing.Size(238, 20);
            this.haslo.TabIndex = 8;
            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(797, 457);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wrongpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.logowanie);
            this.Name = "FormLogin";
            this.Text = "Aplikacja bankowa PBanK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button logowanie;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wrongpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox haslo;
    }
}

