
namespace PBank {
    partial class _FormZarzadca {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Degradacja = new System.Windows.Forms.Label();
            this.Awans = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.Paychange = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(391, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "PANEL ZARZĄDCY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(600, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 78);
            this.label2.TabIndex = 8;
            this.label2.Text = "PBanK";
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
            this.Degradacja.Location = new System.Drawing.Point(375, 285);
            this.Degradacja.MaximumSize = new System.Drawing.Size(150, 100);
            this.Degradacja.MinimumSize = new System.Drawing.Size(150, 100);
            this.Degradacja.Name = "Degradacja";
            this.Degradacja.Size = new System.Drawing.Size(150, 100);
            this.Degradacja.TabIndex = 13;
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
            this.Awans.Location = new System.Drawing.Point(165, 285);
            this.Awans.MaximumSize = new System.Drawing.Size(150, 100);
            this.Awans.MinimumSize = new System.Drawing.Size(150, 100);
            this.Awans.Name = "Awans";
            this.Awans.Size = new System.Drawing.Size(150, 100);
            this.Awans.TabIndex = 12;
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
            this.Search.TabIndex = 11;
            this.Search.Text = "Wyszukaj w bazie";
            this.Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Search_MouseDown);
            this.Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Search_MouseUp);
            // 
            // Paychange
            // 
            this.Paychange.AutoSize = true;
            this.Paychange.BackColor = System.Drawing.Color.DarkCyan;
            this.Paychange.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Paychange.ForeColor = System.Drawing.Color.White;
            this.Paychange.Image = global::PBank.Properties.Resources.change;
            this.Paychange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Paychange.Location = new System.Drawing.Point(270, 150);
            this.Paychange.MaximumSize = new System.Drawing.Size(150, 100);
            this.Paychange.MinimumSize = new System.Drawing.Size(150, 100);
            this.Paychange.Name = "Paychange";
            this.Paychange.Size = new System.Drawing.Size(150, 100);
            this.Paychange.TabIndex = 14;
            this.Paychange.Text = "Zmień płacę\r\n";
            this.Paychange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Paychange.Click += new System.EventHandler(this.Paychange_Click);
            this.Paychange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paychange_MouseDown);
            this.Paychange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paychange_MouseUp);
            // 
            // _FormZarzadca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Paychange);
            this.Controls.Add(this.Degradacja);
            this.Controls.Add(this.Awans);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_FormZarzadca";
            this.Text = "_FormZarzadca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormZarzadca_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Degradacja;
        private System.Windows.Forms.Label Awans;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label Paychange;
    }
}