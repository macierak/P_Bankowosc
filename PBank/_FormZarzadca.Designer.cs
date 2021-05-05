
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
            this.search = new System.Windows.Forms.Button();
            this.awans = new System.Windows.Forms.Button();
            this.degraduj = new System.Windows.Forms.Button();
            this.zmianaplacy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(60, 105);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(105, 90);
            this.search.TabIndex = 0;
            this.search.Text = "wyszukaj";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // awans
            // 
            this.awans.Location = new System.Drawing.Point(225, 105);
            this.awans.Name = "awans";
            this.awans.Size = new System.Drawing.Size(90, 90);
            this.awans.TabIndex = 1;
            this.awans.Text = "Awansuj";
            this.awans.UseVisualStyleBackColor = true;
            this.awans.Click += new System.EventHandler(this.awans_Click);
            // 
            // degraduj
            // 
            this.degraduj.Location = new System.Drawing.Point(375, 105);
            this.degraduj.Name = "degraduj";
            this.degraduj.Size = new System.Drawing.Size(90, 90);
            this.degraduj.TabIndex = 2;
            this.degraduj.Text = "Degraduj";
            this.degraduj.UseVisualStyleBackColor = true;
            this.degraduj.Click += new System.EventHandler(this.degradacja_Click);
            // 
            // zmianaplacy
            // 
            this.zmianaplacy.Location = new System.Drawing.Point(510, 105);
            this.zmianaplacy.Name = "zmianaplacy";
            this.zmianaplacy.Size = new System.Drawing.Size(90, 90);
            this.zmianaplacy.TabIndex = 3;
            this.zmianaplacy.Text = "Zmień płacę";
            this.zmianaplacy.UseVisualStyleBackColor = true;
            this.zmianaplacy.Click += new System.EventHandler(this.paychange_Click);
            // 
            // _FormZarzadca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zmianaplacy);
            this.Controls.Add(this.degraduj);
            this.Controls.Add(this.awans);
            this.Controls.Add(this.search);
            this.Name = "_FormZarzadca";
            this.Text = "_FormZarzadca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormZarzadca_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button awans;
        private System.Windows.Forms.Button degraduj;
        private System.Windows.Forms.Button zmianaplacy;
    }
}