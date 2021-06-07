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
        private void search_Click(object sender, EventArgs e) {
            FormWyswietlDane formW = new FormWyswietlDane();
            formW.ShowDialog();
        }

        private void awans_Click(object sender, EventArgs e) {
            FormAwans formA = new FormAwans(this.idosoby);
            formA.ShowDialog();
        }

        private void degradacja_Click(object sender, EventArgs e) {
            int id = this.idosoby;
            FormDegradacja formD = new FormDegradacja(50, id);
            
            formD.ShowDialog();
        }

        private void paychange_Click(object sender, EventArgs e) {
            FormZmianaPlacy formZP = new FormZmianaPlacy(50, this.idosoby);
            formZP.ShowDialog();
        }

        private void Zatrudnij_Click(object sender, EventArgs e) {
            FormZatrudnij formZ = new FormZatrudnij(50);
            formZ.ShowDialog();
        }

        private void Zwolnij_Click(object sender, EventArgs e) {
        }
    }
}
