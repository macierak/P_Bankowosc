using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PBank {
    public partial class FormPerm : Form {
        string name;
        string ImNaz;
        public FormPerm(int permission, string ImNaz) {
            InitializeComponent();
            this.ImNaz = ImNaz;
            switch (permission) {
                case 5:
                    this.name = "Klient";
                    break;
                case 20:
                    this.name = "Asystent";
                    break;
                case 30:
                    this.name = "Konsultant";
                    break;
                case 50:
                    this.name = "Zarzadca";
                    break;
                case 100:
                    this.name = "Dyrektor";
                    break;
            }
            this.name = "Klient";
            this.Text = "PBanK   " + this.name + " " + this.ImNaz; 
        }
    }
}

