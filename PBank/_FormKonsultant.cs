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
    public partial class _FormKonsultant : Form {
        FormLogin form;
        public _FormKonsultant(string ImNaz, FormLogin form) {
            InitializeComponent();
            this.Text = "PBanK   Konsultant " + ImNaz;
            this.form = form;
        }

        private void _FormKonsultant_FormClosing(object sender, FormClosingEventArgs e) {
            form.Visible = true;
        }

        private void Remove_Click(object sender, EventArgs e) {
            FormUsunKlient formUsun = new FormUsunKlient();
            formUsun.ShowDialog();
        }

        private void Remove_MouseDown(object sender, MouseEventArgs e) {
            Remove.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Awans_MouseUp(object sender, MouseEventArgs e) {
            Remove.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void add_Click(object sender, EventArgs e) {
            FormDodajKient formDodaj = new FormDodajKient();
            formDodaj.ShowDialog();
        }
        private void add_MouseDown(object sender, MouseEventArgs e) {
            Remove.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void add_MouseUp(object sender, MouseEventArgs e) {
            Remove.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void log_Click(object sender, EventArgs e) {

        }
        private void log_MouseDown(object sender, MouseEventArgs e) {
            Remove.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void log_MouseUp(object sender, MouseEventArgs e) {
            Remove.BackColor = System.Drawing.Color.DarkCyan;
        }
    }
}
