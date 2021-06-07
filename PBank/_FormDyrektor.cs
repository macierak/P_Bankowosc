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
    public partial class _FormDyrektor : Form {

        FormLogin form;
        int ID = 0;
        public _FormDyrektor(string ImNaz, FormLogin form, int ID) {
            InitializeComponent();
            this.Text = "PBanK   Dyrektor " + ImNaz;
            this.form = form;
            this.ID = ID;
        }

        private void _FormDyrektor_FormClosing(object sender, FormClosingEventArgs e) {
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
            FormAwans formA = new FormAwans(this.ID);
            formA.ShowDialog();
        }
        private void Awans_MouseDown(object sender, MouseEventArgs e) {
            Awans.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Awans_MouseUp(object sender, MouseEventArgs e) {
            Awans.BackColor = System.Drawing.Color.DarkCyan;
        }


        private void Degradacja_Click(object sender, EventArgs e) {
            FormDegradacja formD = new FormDegradacja(100, this.ID);
            formD.ShowDialog();
        }
        private void Degradacja_MouseDown(object sender, MouseEventArgs e) {
            Degradacja.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Degradacja_MouseUp(object sender, MouseEventArgs e) {
            Degradacja.BackColor = System.Drawing.Color.DarkCyan;
        }


        private void Paychange_Click(object sender, EventArgs e) {
            FormZmianaPlacy formZP = new FormZmianaPlacy(100, this.ID);
            formZP.ShowDialog();
        }
        private void Paychange_MouseDown(object sender, MouseEventArgs e) {
            Paychange.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Paychange_MouseUp(object sender, MouseEventArgs e) {
            Paychange.BackColor = System.Drawing.Color.DarkCyan;
        }


        private void Zwolnienie_Click(object sender, EventArgs e) {

        }
        private void Zwolnienie_MouseDown(object sender, MouseEventArgs e) {
            Zwolnienie.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Zwolnienie_MouseUp(object sender, MouseEventArgs e) {
            Zwolnienie.BackColor = System.Drawing.Color.DarkCyan;
        }


        private void Zatrudnienie_Click(object sender, EventArgs e) {
            FormZatrudnij formZ = new FormZatrudnij(100);
            formZ.ShowDialog();
        }
        private void Zatrudnienie_MouseDown(object sender, MouseEventArgs e) {
            Zatrudnienie.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Zatrudnienie_MouseUp(object sender, MouseEventArgs e) {
            Zatrudnienie.BackColor = System.Drawing.Color.DarkCyan;
        }

    }
}
