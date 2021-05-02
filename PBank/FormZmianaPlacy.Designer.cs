
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nowPay = new System.Windows.Forms.TextBox();
            this.newPay = new System.Windows.Forms.TextBox();
            this.Osoby = new System.Windows.Forms.ListBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osoba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktualna płaca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nowa płaca";
            // 
            // nowPay
            // 
            this.nowPay.Location = new System.Drawing.Point(225, 60);
            this.nowPay.Name = "nowPay";
            this.nowPay.ReadOnly = true;
            this.nowPay.Size = new System.Drawing.Size(105, 20);
            this.nowPay.TabIndex = 3;
            // 
            // newPay
            // 
            this.newPay.Location = new System.Drawing.Point(375, 60);
            this.newPay.Name = "newPay";
            this.newPay.Size = new System.Drawing.Size(105, 20);
            this.newPay.TabIndex = 4;
            // 
            // Osoby
            // 
            this.Osoby.FormattingEnabled = true;
            this.Osoby.Location = new System.Drawing.Point(45, 60);
            this.Osoby.Name = "Osoby";
            this.Osoby.Size = new System.Drawing.Size(150, 56);
            this.Osoby.TabIndex = 5;
            this.Osoby.SelectedIndexChanged += new System.EventHandler(this.Osoby_SelectedIndexChanged);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(225, 90);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(255, 30);
            this.update.TabIndex = 6;
            this.update.Text = "Aktualizuj";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // FormZmianaPlacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Osoby);
            this.Controls.Add(this.newPay);
            this.Controls.Add(this.nowPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormZmianaPlacy";
            this.Text = "FormZmianaPlacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nowPay;
        private System.Windows.Forms.TextBox newPay;
        private System.Windows.Forms.ListBox Osoby;
        private System.Windows.Forms.Button update;
    }
}