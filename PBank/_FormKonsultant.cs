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
    }
}
