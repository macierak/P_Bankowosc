
namespace PBank {
    partial class FormZmianaPlacy {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nowPay = new System.Windows.Forms.TextBox();
            this.newPay = new System.Windows.Forms.TextBox();
            this.Osoby = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(390, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktualna płaca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(1035, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nowa płaca";
            // 
            // nowPay
            // 
            this.nowPay.BackColor = System.Drawing.Color.DarkCyan;
            this.nowPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nowPay.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowPay.ForeColor = System.Drawing.Color.White;
            this.nowPay.Location = new System.Drawing.Point(390, 165);
            this.nowPay.Name = "nowPay";
            this.nowPay.ReadOnly = true;
            this.nowPay.Size = new System.Drawing.Size(165, 40);
            this.nowPay.TabIndex = 3;
            // 
            // newPay
            // 
            this.newPay.BackColor = System.Drawing.Color.DarkCyan;
            this.newPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPay.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPay.ForeColor = System.Drawing.Color.White;
            this.newPay.Location = new System.Drawing.Point(390, 270);
            this.newPay.Name = "newPay";
            this.newPay.Size = new System.Drawing.Size(165, 40);
            this.newPay.TabIndex = 4;
            // 
            // Osoby
            // 
            this.Osoby.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Osoby.ForeColor = System.Drawing.Color.DarkCyan;
            this.Osoby.FormattingEnabled = true;
            this.Osoby.ItemHeight = 26;
            this.Osoby.Location = new System.Drawing.Point(30, 120);
            this.Osoby.Name = "Osoby";
            this.Osoby.Size = new System.Drawing.Size(345, 290);
            this.Osoby.TabIndex = 5;
            this.Osoby.SelectedIndexChanged += new System.EventHandler(this.Osoby_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 59);
            this.label4.TabIndex = 7;
            this.label4.Text = "ZMIANA PŁACY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(390, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nowa płaca";
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.BackColor = System.Drawing.Color.DarkCyan;
            this.Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Update.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Image = global::PBank.Properties.Resources.change;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Update.Location = new System.Drawing.Point(595, 193);
            this.Update.MaximumSize = new System.Drawing.Size(150, 100);
            this.Update.MinimumSize = new System.Drawing.Size(150, 100);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(150, 100);
            this.Update.TabIndex = 9;
            this.Update.Text = "Aktualizuj\r\n";
            this.Update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Update.Click += new System.EventHandler(this.update_Click);
            this.Update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.Update.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Update_MouseUp);
            // 
            // FormZmianaPlacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Osoby);
            this.Controls.Add(this.newPay);
            this.Controls.Add(this.nowPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormZmianaPlacy";
            this.Text = "Zmiana płacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nowPay;
        private System.Windows.Forms.TextBox newPay;
        private System.Windows.Forms.ListBox Osoby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Update;
    }
}