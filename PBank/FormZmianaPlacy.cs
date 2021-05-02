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
    public partial class FormZmianaPlacy : Form {
        int permLvl;
        int[] idTab;
        string[] pensja;
        int id;
        public FormZmianaPlacy(int permLvl) {
            InitializeComponent();
            this.permLvl = permLvl;
            this.idTab = printDane();
        }

        public int[] printDane() {
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                var zalogowanyP = from p in Dane.Pracownik
                                  select p;
                this.idTab = new int[zalogowanyP.Count()];
                this.pensja = new string[zalogowanyP.Count()];
                int i = 0;
                foreach (Pracownik p in zalogowanyP) {
                    if (p.Stanowisko == "Dyrektor" || (p.Stanowisko == "Zarzadca Oddzialu" && this.permLvl >51)) continue;

                    Osoby.Items.Add(p.ID + ". " + p.Imię + " " + p.Nazwisko + "( " + p.Stanowisko+" ) "+ p.Pensja);
                    this.idTab[i] = p.ID;
                    this.pensja[i] = p.Pensja.ToString();
                    i++;
                }
            }
            return idTab;
        }

        private void Osoby_SelectedIndexChanged(object sender, EventArgs e) {
            nowPay.Text = this.pensja[Osoby.SelectedIndex];
            this.id = this.idTab[Osoby.SelectedIndex];
        }

        private void update_Click(object sender, EventArgs e) {
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                Dane.pay_manage(this.id, float.Parse(newPay.Text));
            }
            this.idTab = printDane();
        }
    }
}
