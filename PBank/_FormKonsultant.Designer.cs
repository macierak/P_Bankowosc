
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
            this.wyplata = new System.Windows.Forms.Button();
            this.newClient = new System.Windows.Forms.Button();
            this.loginClient = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.wplac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wyplata
            // 
            this.wyplata.Location = new System.Drawing.Point(325, 307);
            this.wyplata.Name = "wyplata";
            this.wyplata.Size = new System.Drawing.Size(156, 60);
            this.wyplata.TabIndex = 0;
            this.wyplata.Text = "Wypłać Środki";
            this.wyplata.UseVisualStyleBackColor = true;
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(632, 205);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(128, 61);
            this.newClient.TabIndex = 1;
            this.newClient.Text = "Utwórz Klienta";
            this.newClient.UseVisualStyleBackColor = true;
            // 
            // loginClient
            // 
            this.loginClient.Location = new System.Drawing.Point(635, 139);
            this.loginClient.Name = "loginClient";
            this.loginClient.Size = new System.Drawing.Size(124, 49);
            this.loginClient.TabIndex = 2;
            this.loginClient.Text = "Zaloguj Klienta";
            this.loginClient.UseVisualStyleBackColor = true;
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(642, 405);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(116, 25);
            this.deleteClient.TabIndex = 3;
            this.deleteClient.Text = "Usuń klienta";
            this.deleteClient.UseVisualStyleBackColor = true;
            // 
            // wplac
            // 
            this.wplac.Location = new System.Drawing.Point(327, 233);
            this.wplac.Name = "wplac";
            this.wplac.Size = new System.Drawing.Size(153, 59);
            this.wplac.TabIndex = 4;
            this.wplac.Text = "Wpłać Środki";
            this.wplac.UseVisualStyleBackColor = true;
            // 
            // _FormKonsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBank.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wplac);
            this.Controls.Add(this.deleteClient);
            this.Controls.Add(this.loginClient);
            this.Controls.Add(this.newClient);
            this.Controls.Add(this.wyplata);
            this.Name = "_FormKonsultant";
            this.Text = "_FormKonsultant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormKonsultant_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wyplata;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.Button loginClient;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button wplac;
    }
}