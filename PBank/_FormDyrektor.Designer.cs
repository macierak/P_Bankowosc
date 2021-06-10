
namespace PBank {
    partial class _FormDyrektor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormDyrektor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Paychange = new System.Windows.Forms.Label();
            this.Zatrudnienie = new System.Windows.Forms.Label();
            this.Zwolnienie = new System.Windows.Forms.Label();
            this.Degradacja = new System.Windows.Forms.Label();
            this.Awans = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "PANEL DYREKTORA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(585, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 78);
            this.label2.TabIndex = 7;
            this.label2.Text = "PBanK";
            // 
            // Paychange
            // 
            this.Paychange.AutoSize = true;
            this.Paychange.BackColor = System.Drawing.Color.DarkCyan;
            this.Paychange.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Paychange.ForeColor = System.Drawing.Color.White;
            this.Paychange.Image = global::PBank.Properties.Resources.change;
            this.Paychange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Paychange.Location = new System.Drawing.Point(540, 300);
            this.Paychange.MaximumSize = new System.Drawing.Size(150, 100);
            this.Paychange.MinimumSize = new System.Drawing.Size(150, 100);
            this.Paychange.Name = "Paychange";
            this.Paychange.Size = new System.Drawing.Size(150, 100);
            this.Paychange.TabIndex = 13;
            this.Paychange.Text = "Zmień płacę\r\n";
            this.Paychange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Paychange.Click += new System.EventHandler(this.Paychange_Click);
            this.Paychange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paychange_MouseDown);
            this.Paychange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paychange_MouseUp);
            // 
            // Zatrudnienie
            // 
            this.Zatrudnienie.AutoSize = true;
            this.Zatrudnienie.BackColor = System.Drawing.Color.DarkCyan;
            this.Zatrudnienie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Zatrudnienie.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zatrudnienie.ForeColor = System.Drawing.Color.White;
            this.Zatrudnienie.Image = ((System.Drawing.Image)(resources.GetObject("Zatrudnienie.Image")));
            this.Zatrudnienie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Zatrudnienie.Location = new System.Drawing.Point(330, 300);
            this.Zatrudnienie.MaximumSize = new System.Drawing.Size(150, 100);
            this.Zatrudnienie.MinimumSize = new System.Drawing.Size(150, 100);
            this.Zatrudnienie.Name = "Zatrudnienie";
            this.Zatrudnienie.Size = new System.Drawing.Size(150, 100);
            this.Zatrudnienie.TabIndex = 12;
            this.Zatrudnienie.Text = "Zatrudnij\r\n";
            this.Zatrudnienie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Zatrudnienie.Click += new System.EventHandler(this.Zatrudnienie_Click);
            this.Zatrudnienie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Zatrudnienie_MouseDown);
            this.Zatrudnienie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Zatrudnienie_MouseUp);
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
            this.Zwolnienie.Location = new System.Drawing.Point(120, 300);
            this.Zwolnienie.MaximumSize = new System.Drawing.Size(150, 100);
            this.Zwolnienie.MinimumSize = new System.Drawing.Size(150, 100);
            this.Zwolnienie.Name = "Zwolnienie";
            this.Zwolnienie.Size = new System.Drawing.Size(150, 100);
            this.Zwolnienie.TabIndex = 11;
            this.Zwolnienie.Text = "Zwolnij\r\n";
            this.Zwolnienie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Zwolnienie.Click += new System.EventHandler(this.Zwolnienie_Click);
            this.Zwolnienie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Zwolnienie_MouseDown);
            this.Zwolnienie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Zwolnienie_MouseUp);
            // 
            // Degradacja
            // 
            this.Degradacja.AutoSize = true;
            this.Degradacja.BackColor = System.Drawing.Color.DarkCyan;
            this.Degradacja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Degradacja.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Degradacja.ForeColor = System.Drawing.Color.White;
            this.Degradacja.Image = global::PBank.Properties.Resources.arrow_down;
            this.Degradacja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Degradacja.Location = new System.Drawing.Point(480, 150);
            this.Degradacja.MaximumSize = new System.Drawing.Size(150, 100);
            this.Degradacja.MinimumSize = new System.Drawing.Size(150, 100);
            this.Degradacja.Name = "Degradacja";
            this.Degradacja.Size = new System.Drawing.Size(150, 100);
            this.Degradacja.TabIndex = 10;
            this.Degradacja.Text = "Degraduj\r\n";
            this.Degradacja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Degradacja.Click += new System.EventHandler(this.Degradacja_Click);
            this.Degradacja.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Degradacja_MouseDown);
            this.Degradacja.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Degradacja_MouseUp);
            // 
            // Awans
            // 
            this.Awans.AutoSize = true;
            this.Awans.BackColor = System.Drawing.Color.DarkCyan;
            this.Awans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Awans.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Awans.ForeColor = System.Drawing.Color.White;
            this.Awans.Image = global::PBank.Properties.Resources.arrow_up;
            this.Awans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Awans.Location = new System.Drawing.Point(270, 150);
            this.Awans.MaximumSize = new System.Drawing.Size(150, 100);
            this.Awans.MinimumSize = new System.Drawing.Size(150, 100);
            this.Awans.Name = "Awans";
            this.Awans.Size = new System.Drawing.Size(150, 100);
            this.Awans.TabIndex = 9;
            this.Awans.Text = "Awansuj\r\n";
            this.Awans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Awans.Click += new System.EventHandler(this.Awans_Click);
            this.Awans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Awans_MouseDown);
            this.Awans.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Awans_MouseUp);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.DarkCyan;
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Image = global::PBank.Properties.Resources.loupe;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Search.Location = new System.Drawing.Point(60, 150);
            this.Search.MaximumSize = new System.Drawing.Size(150, 100);
            this.Search.MinimumSize = new System.Drawing.Size(150, 100);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(150, 100);
            this.Search.TabIndex = 8;
            this.Search.Text = "Pokaż \r\nw bazie";
            this.Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Search_MouseDown);
            this.Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Search_MouseUp);
            // 
            // _FormDyrektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Paychange);
            this.Controls.Add(this.Zatrudnienie);
            this.Controls.Add(this.Zwolnienie);
            this.Controls.Add(this.Degradacja);
            this.Controls.Add(this.Awans);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_FormDyrektor";
            this.Text = "_FormDyrektor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormDyrektor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label Awans;
        private System.Windows.Forms.Label Degradacja;
        private System.Windows.Forms.Label Zwolnienie;
        private System.Windows.Forms.Label Zatrudnienie;
        private System.Windows.Forms.Label Paychange;
    }
}