
namespace PBank {
    partial class FormUsunKlient {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsunKlient));
            this.label11 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.Usun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Candara Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(21, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 59);
            this.label11.TabIndex = 22;
            this.label11.Text = "USUŃ KLIENTA";
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lista.ForeColor = System.Drawing.Color.DarkCyan;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 26;
            this.lista.Location = new System.Drawing.Point(31, 86);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(482, 342);
            this.lista.TabIndex = 23;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // Usun
            // 
            this.Usun.AutoSize = true;
            this.Usun.BackColor = System.Drawing.Color.DarkCyan;
            this.Usun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Usun.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Usun.ForeColor = System.Drawing.Color.White;
            this.Usun.Image = ((System.Drawing.Image)(resources.GetObject("Usun.Image")));
            this.Usun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Usun.Location = new System.Drawing.Point(566, 187);
            this.Usun.MaximumSize = new System.Drawing.Size(150, 100);
            this.Usun.MinimumSize = new System.Drawing.Size(150, 100);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(150, 100);
            this.Usun.TabIndex = 24;
            this.Usun.Text = "Usuń\r\n";
            this.Usun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // FormUsunKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label11);
            this.Name = "FormUsunKlient";
            this.Text = "Usuń klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label Usun;
    }
}