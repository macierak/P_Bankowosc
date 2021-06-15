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
    public partial class FormPotwierdzUsun : Form {
        FormUsunKlient form;
        int selectedId;
        public FormPotwierdzUsun(String nazwa, String adres_, String pesel_, String nr, int id, FormUsunKlient form) {
            InitializeComponent();
            this.form = form;
            imie.Text = nazwa;
            adres.Text = adres_;
            pesel.Text = pesel_;
            nr_dowodu.Text = nr;
            this.selectedId = id;
        }

        private void yes_Click(object sender, EventArgs e) {
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                Dane.usun(this.selectedId, System.DateTime.Today.Date);
                Dane.SaveChanges();
                form.reload();
                this.Close();
            }
        }

        private void no_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
