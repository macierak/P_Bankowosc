namespace PBank {
    partial class FormWyswietlDane {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.klienci = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownicy = new System.Windows.Forms.ToolStripMenuItem();
            this.exPracownicy = new System.Windows.Forms.ToolStripMenuItem();
            this.exKlienci = new System.Windows.Forms.ToolStripMenuItem();
            this.dane = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dane)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klienci,
            this.pracownicy,
            this.exPracownicy,
            this.exKlienci});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(52, 20);
            this.menu.Text = "Tabele";
            // 
            // klienci
            // 
            this.klienci.Name = "klienci";
            this.klienci.Size = new System.Drawing.Size(180, 22);
            this.klienci.Text = "Klienci";
            this.klienci.Click += new System.EventHandler(this.klienci_Click);
            // 
            // pracownicy
            // 
            this.pracownicy.Name = "pracownicy";
            this.pracownicy.Size = new System.Drawing.Size(180, 22);
            this.pracownicy.Text = "Pracownicy";
            this.pracownicy.Click += new System.EventHandler(this.pracownicy_Click);
            // 
            // exPracownicy
            // 
            this.exPracownicy.Name = "exPracownicy";
            this.exPracownicy.Size = new System.Drawing.Size(180, 22);
            this.exPracownicy.Text = "Ex-Pracownicy";
            this.exPracownicy.Click += new System.EventHandler(this.exPracownicy_Click);
            // 
            // exKlienci
            // 
            this.exKlienci.Name = "exKlienci";
            this.exKlienci.Size = new System.Drawing.Size(180, 22);
            this.exKlienci.Text = "Ex-Klienci";
            this.exKlienci.Click += new System.EventHandler(this.exKlienci_Click);
            // 
            // dane
            // 
            this.dane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dane.Location = new System.Drawing.Point(13, 41);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(773, 393);
            this.dane.TabIndex = 1;
            // 
            // FormWyswietlDane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormWyswietlDane";
            this.Text = "FormWyswietlDane";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem klienci;
        private System.Windows.Forms.ToolStripMenuItem pracownicy;
        private System.Windows.Forms.ToolStripMenuItem exPracownicy;
        private System.Windows.Forms.ToolStripMenuItem exKlienci;
        private System.Windows.Forms.DataGridView dane;
    }
}