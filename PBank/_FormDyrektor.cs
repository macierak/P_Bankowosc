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

        public _FormDyrektor(string ImNaz, FormLogin form) {
            InitializeComponent();
            this.Text = "PBanK   Dyrektor " + ImNaz;
            this.form = form;
        }

        private void _FormDyrektor_FormClosing(object sender, FormClosingEventArgs e) {
            form.Visible = true;
        }

        private void search_Click(object sender, EventArgs e) {

        }

        private void awans_Click(object sender, EventArgs e) {
            FormAwans formA = new FormAwans();
            formA.ShowDialog();
        }

        private void degradacja_Click(object sender, EventArgs e) {
            FormDegradacja formD = new FormDegradacja(100);
            formD.ShowDialog();
        }

        private void paychange_Click(object sender, EventArgs e) {
            FormZmianaPlacy formZP = new FormZmianaPlacy(100);
            formZP.ShowDialog();
        }
    }
}
