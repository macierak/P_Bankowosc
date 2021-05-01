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
    public partial class _FormKlient : Form {

        FormLogin form;

        public _FormKlient(string ImNaz, FormLogin form) {
            InitializeComponent();
            this.Text = "PBanK   Klient " + ImNaz;
            this.form = form;
        }

        private void _FormKlient_FormClosing(object sender, FormClosingEventArgs e) {
            form.Visible = true;
        }
    }
}
