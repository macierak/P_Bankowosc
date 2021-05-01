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

        public _FormZarzadca(string ImNaz, FormLogin form) {
            InitializeComponent();
            this.Text = "PBanK   Zarządca " + ImNaz;
            this.form = form;
        }

        private void _FormZarzadca_FormClosing(object sender, FormClosingEventArgs e) {
            form.Visible = true;
        }
    }
}
