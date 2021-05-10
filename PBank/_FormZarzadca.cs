using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBank {
    public partial class _FormZarzadca : Form {

        FormLogin form;
        int idosoby;
        public _FormZarzadca(string ImNaz, FormLogin form, int id) {
            InitializeComponent();
            this.Text = "PBanK   Zarządca " + ImNaz;
            this.form = form;
            this.idosoby = id;
            
        }

        private void _FormZarzadca_FormClosing(object sender, FormClosingEventArgs e) {
            form.Visible = true;
        }


        private void Search_Click(object sender, EventArgs e) {

        }
        private void Search_MouseDown(object sender, MouseEventArgs e) {
            Search.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Search_MouseUp(object sender, MouseEventArgs e) {
            Search.BackColor = System.Drawing.Color.DarkCyan;
        }


        private void Awans_Click(object sender, EventArgs e) {
            FormAwans formA = new FormAwans(this.idosoby);
            formA.ShowDialog();
        }
        private void Awans_MouseDown(object sender, MouseEventArgs e) {
            Awans.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Awans_MouseUp(object sender, MouseEventArgs e) {
            Awans.BackColor = System.Drawing.Color.DarkCyan;
        }


        private void Degradacja_Click(object sender, EventArgs e) {
            //MessageBox.Show(this.idosoby.ToString());
            int id = this.idosoby;
            FormDegradacja formD = new FormDegradacja(50, id);
            
            formD.ShowDialog();
        }
        private void Degradacja_MouseDown(object sender, MouseEventArgs e) {
            Degradacja.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Degradacja_MouseUp(object sender, MouseEventArgs e) {
            Degradacja.BackColor = System.Drawing.Color.DarkCyan;
        }


        private void Paychange_Click(object sender, EventArgs e) {
            FormZmianaPlacy formZP = new FormZmianaPlacy(50, this.idosoby);
            formZP.ShowDialog();
        }
        private void Paychange_MouseDown(object sender, MouseEventArgs e) {
            Paychange.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Paychange_MouseUp(object sender, MouseEventArgs e) {
            Paychange.BackColor = System.Drawing.Color.DarkCyan;
        }

    }
}
