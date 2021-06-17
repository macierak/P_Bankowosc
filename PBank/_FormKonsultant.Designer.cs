
namespace PBank {
    partial class _FormKonsultant {
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
            this.Remove = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pesel_label = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.TextBox();
            this.blad = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Remove
            // 
            this.Remove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Remove.AutoSize = true;
            this.Remove.BackColor = System.Drawing.Color.DarkCyan;
            this.Remove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.Image = global::PBank.Properties.Resources.minus;
            this.Remove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Remove.Location = new System.Drawing.Point(563, 273);
            this.Remove.MaximumSize = new System.Drawing.Size(150, 100);
            this.Remove.MinimumSize = new System.Drawing.Size(150, 100);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(150, 100);
            this.Remove.TabIndex = 9;
            this.Remove.Text = "Usuń\r\nklienta";
            this.Remove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            this.Remove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Remove_MouseDown);
            this.Remove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Remove_MouseUp);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.Color.DarkCyan;
            this.add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Image = global::PBank.Properties.Resources.plus;
            this.add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add.Location = new System.Drawing.Point(563, 128);
            this.add.MaximumSize = new System.Drawing.Size(150, 100);
            this.add.MinimumSize = new System.Drawing.Size(150, 100);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 100);
            this.add.TabIndex = 10;
            this.add.Text = "Dodaj nowego\r\nklienta";
            this.add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add.Click += new System.EventHandler(this.add_Click);
            this.add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.add_MouseDown);
            this.add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.add_MouseUp);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.DarkCyan;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Image = global::PBank.Properties.Resources.arrow_up;
            this.log.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log.Location = new System.Drawing.Point(294, 196);
            this.log.MaximumSize = new System.Drawing.Size(150, 100);
            this.log.MinimumSize = new System.Drawing.Size(150, 100);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(150, 100);
            this.log.TabIndex = 11;
            this.log.Text = "Zaloguj\r\nklienta";
            this.log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.log.Click += new System.EventHandler(this.log_Click);
            this.log.MouseDown += new System.Windows.Forms.MouseEventHandler(this.log_MouseDown);
            this.log.MouseUp += new System.Windows.Forms.MouseEventHandler(this.log_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(25, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 59);
            this.label3.TabIndex = 12;
            this.label3.Text = "PANEL KONSULTANTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(592, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 78);
            this.label4.TabIndex = 13;
            this.label4.Text = "PBanK";
            // 
            // pesel_label
            // 
            this.pesel_label.AutoSize = true;
            this.pesel_label.BackColor = System.Drawing.Color.Transparent;
            this.pesel_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pesel_label.ForeColor = System.Drawing.Color.DarkCyan;
            this.pesel_label.Location = new System.Drawing.Point(31, 273);
            this.pesel_label.Name = "pesel_label";
            this.pesel_label.Size = new System.Drawing.Size(45, 19);
            this.pesel_label.TabIndex = 15;
            this.pesel_label.Text = "Pesel";
            // 
            // pesel
            // 
            this.pesel.BackColor = System.Drawing.Color.DarkCyan;
            this.pesel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pesel.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pesel.ForeColor = System.Drawing.Color.White;
            this.pesel.Location = new System.Drawing.Point(35, 295);
            this.pesel.MinimumSize = new System.Drawing.Size(200, 30);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(200, 33);
            this.pesel.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(31, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nazwisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(31, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Imię";
            // 
            // nazwisko
            // 
            this.nazwisko.BackColor = System.Drawing.Color.DarkCyan;
            this.nazwisko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nazwisko.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko.ForeColor = System.Drawing.Color.White;
            this.nazwisko.Location = new System.Drawing.Point(35, 223);
            this.nazwisko.MinimumSize = new System.Drawing.Size(200, 30);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(200, 33);
            this.nazwisko.TabIndex = 18;
            // 
            // imie
            // 
            this.imie.BackColor = System.Drawing.Color.DarkCyan;
            this.imie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imie.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.ForeColor = System.Drawing.Color.White;
            this.imie.Location = new System.Drawing.Point(35, 150);
            this.imie.MinimumSize = new System.Drawing.Size(200, 30);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(200, 33);
            this.imie.TabIndex = 17;
            // 
            // blad
            // 
            this.blad.AutoSize = true;
            this.blad.BackColor = System.Drawing.Color.Transparent;
            this.blad.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blad.ForeColor = System.Drawing.Color.Maroon;
            this.blad.Location = new System.Drawing.Point(30, 347);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(210, 26);
            this.blad.TabIndex = 21;
            this.blad.Text = "Nie ma takiego klienta!";
            this.blad.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _FormKonsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.pesel_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Remove);
            this.Name = "_FormKonsultant";
            this.Text = "_FormKonsultant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormKonsultant_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Remove;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pesel_label;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.Label blad;
        private System.Windows.Forms.Timer timer1;
    }
}