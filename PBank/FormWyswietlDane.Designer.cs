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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pracownicy,
            this.klienci,
            this.exPracownicy,
            this.exKlienci});
            this.menu.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu.ForeColor = System.Drawing.Color.DarkCyan;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(92, 33);
            this.menu.Text = "Tabele";
            // 
            // klienci
            // 
            this.klienci.BackColor = System.Drawing.Color.DarkCyan;
            this.klienci.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klienci.ForeColor = System.Drawing.Color.White;
            this.klienci.Name = "klienci";
            this.klienci.Size = new System.Drawing.Size(233, 34);
            this.klienci.Text = "Klienci";
            this.klienci.Click += new System.EventHandler(this.klienci_Click);
            // 
            // pracownicy
            // 
            this.pracownicy.BackColor = System.Drawing.Color.DarkCyan;
            this.pracownicy.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownicy.ForeColor = System.Drawing.Color.White;
            this.pracownicy.Name = "pracownicy";
            this.pracownicy.Size = new System.Drawing.Size(233, 34);
            this.pracownicy.Text = "Pracownicy";
            this.pracownicy.Click += new System.EventHandler(this.pracownicy_Click);
            // 
            // exPracownicy
            // 
            this.exPracownicy.BackColor = System.Drawing.Color.DarkCyan;
            this.exPracownicy.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exPracownicy.ForeColor = System.Drawing.Color.White;
            this.exPracownicy.Name = "exPracownicy";
            this.exPracownicy.Size = new System.Drawing.Size(233, 34);
            this.exPracownicy.Text = "Ex-Pracownicy";
            this.exPracownicy.Click += new System.EventHandler(this.exPracownicy_Click);
            // 
            // exKlienci
            // 
            this.exKlienci.BackColor = System.Drawing.Color.DarkCyan;
            this.exKlienci.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exKlienci.ForeColor = System.Drawing.Color.White;
            this.exKlienci.Name = "exKlienci";
            this.exKlienci.Size = new System.Drawing.Size(233, 34);
            this.exKlienci.Text = "Ex-Klienci";
            this.exKlienci.Click += new System.EventHandler(this.exKlienci_Click);
            // 
            // dane
            // 
            this.dane.AllowUserToAddRows = false;
            this.dane.AllowUserToDeleteRows = false;
            this.dane.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dane.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dane.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dane.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dane.Location = new System.Drawing.Point(12, 41);
            this.dane.Name = "dane";
            this.dane.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dane.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dane.Size = new System.Drawing.Size(1151, 543);
            this.dane.TabIndex = 1;
            // 
            // FormWyswietlDane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 596);
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