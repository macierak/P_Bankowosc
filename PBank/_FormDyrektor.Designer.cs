
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
            this.search = new System.Windows.Forms.Button();
            this.awans = new System.Windows.Forms.Button();
            this.degradacja = new System.Windows.Forms.Button();
            this.paychange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(75, 135);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 90);
            this.search.TabIndex = 0;
            this.search.Text = "wyszukaj w bazie";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // awans
            // 
            this.awans.Location = new System.Drawing.Point(270, 135);
            this.awans.Name = "awans";
            this.awans.Size = new System.Drawing.Size(120, 90);
            this.awans.TabIndex = 1;
            this.awans.Text = "Awansuj";
            this.awans.UseVisualStyleBackColor = true;
            this.awans.Click += new System.EventHandler(this.awans_Click);
            // 
            // degradacja
            // 
            this.degradacja.Location = new System.Drawing.Point(420, 135);
            this.degradacja.Name = "degradacja";
            this.degradacja.Size = new System.Drawing.Size(105, 90);
            this.degradacja.TabIndex = 2;
            this.degradacja.Text = "Degraduj";
            this.degradacja.UseVisualStyleBackColor = true;
            this.degradacja.Click += new System.EventHandler(this.degradacja_Click);
            // 
            // paychange
            // 
            this.paychange.Location = new System.Drawing.Point(540, 135);
            this.paychange.Name = "paychange";
            this.paychange.Size = new System.Drawing.Size(105, 90);
            this.paychange.TabIndex = 3;
            this.paychange.Text = "Zmień płacę";
            this.paychange.UseVisualStyleBackColor = true;
            this.paychange.Click += new System.EventHandler(this.paychange_Click);
            // 
            // _FormDyrektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paychange);
            this.Controls.Add(this.degradacja);
            this.Controls.Add(this.awans);
            this.Controls.Add(this.search);
            this.Name = "_FormDyrektor";
            this.Text = "_FormDyrektor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormDyrektor_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button awans;
        private System.Windows.Forms.Button degradacja;
        private System.Windows.Forms.Button paychange;
    }
}