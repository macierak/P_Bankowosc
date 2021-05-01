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
    }
}
