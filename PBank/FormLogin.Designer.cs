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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wrongpass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.haslo = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.logowanie = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Timer(this.components);
            this.randomBsGo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.DarkCyan;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Candara Light", 20.25F);
            this.login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login.Location = new System.Drawing.Point(461, 166);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(285, 40);
            this.login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara Light", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(351, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara Light", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(351, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "HASŁO";
            // 
            // wrongpass
            // 
            this.wrongpass.AutoSize = true;
            this.wrongpass.BackColor = System.Drawing.Color.Transparent;
            this.wrongpass.Font = new System.Drawing.Font("Candara Light", 15.75F);
            this.wrongpass.ForeColor = System.Drawing.Color.Maroon;
            this.wrongpass.Location = new System.Drawing.Point(456, 131);
            this.wrongpass.Name = "wrongpass";
            this.wrongpass.Size = new System.Drawing.Size(290, 26);
            this.wrongpass.TabIndex = 5;
            this.wrongpass.Text = "Nieprawidłowe dane logowania";
            this.wrongpass.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 36F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 59);
            this.label4.TabIndex = 7;
            this.label4.Text = "APLIKACJA BANKOWA";
            // 
            // haslo
            // 
            this.haslo.BackColor = System.Drawing.Color.DarkCyan;
            this.haslo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.haslo.Font = new System.Drawing.Font("Candara Light", 20.25F);
            this.haslo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.haslo.Location = new System.Drawing.Point(461, 221);
            this.haslo.Name = "haslo";
            this.haslo.PasswordChar = '*';
            this.haslo.Size = new System.Drawing.Size(285, 40);
            this.haslo.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara Light", 48F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(585, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 78);
            this.label3.TabIndex = 9;
            this.label3.Text = "PBanK";
            // 
            // logowanie
            // 
            this.logowanie.AutoSize = true;
            this.logowanie.BackColor = System.Drawing.Color.DarkCyan;
            this.logowanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logowanie.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logowanie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logowanie.Location = new System.Drawing.Point(540, 285);
            this.logowanie.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.logowanie.MinimumSize = new System.Drawing.Size(115, 41);
            this.logowanie.Name = "logowanie";
            this.logowanie.Size = new System.Drawing.Size(115, 41);
            this.logowanie.TabIndex = 10;
            this.logowanie.Text = "ZALOGUJ";
            this.logowanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logowanie.Click += new System.EventHandler(this.logowanie_Click);
            this.logowanie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logowanie_MouseDown);
            this.logowanie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.logowanie_MouseUp);
            // 
            // timerText
            // 
            this.timerText.Enabled = true;
            this.timerText.Interval = 20;
            this.timerText.Tick += new System.EventHandler(this.timerText_Tick);
            // 
            // randomBsGo
            // 
            this.randomBsGo.AutoSize = true;
            this.randomBsGo.BackColor = System.Drawing.Color.Transparent;
            this.randomBsGo.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.randomBsGo.ForeColor = System.Drawing.Color.DarkCyan;
            this.randomBsGo.Location = new System.Drawing.Point(765, 420);
            this.randomBsGo.Name = "randomBsGo";
            this.randomBsGo.Size = new System.Drawing.Size(64, 26);
            this.randomBsGo.TabIndex = 11;
            this.randomBsGo.Text = "label5";
            // 
            // FormLogin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.randomBsGo);
            this.Controls.Add(this.logowanie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wrongpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Aplikacja bankowa PBanK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wrongpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox haslo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label logowanie;
        private System.Windows.Forms.Timer timerText;
        private System.Windows.Forms.Label randomBsGo;
    }
}

