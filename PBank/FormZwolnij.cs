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
    public partial class FormZwolnij : Form {
        int idosoby, selectedID;
        int[] idTab;
        public FormZwolnij(int ID) {
            InitializeComponent();
            this.idosoby = ID;
            this.idTab = printDane();
        }

        private int[] printDane() {
            
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                var zalogowanyP = from p in Dane.Pracownik
                                  select p;
                idTab = new int[zalogowanyP.Count()];
                int i = 0;
                foreach (Pracownik p in zalogowanyP) {
                    if (p.Stanowisko == "Dyrektor" || (p.Stanowisko == "Zarzadca Oddzialu" && idosoby != 1)) continue;
                    if (p.Przełożony == this.idosoby || this.idosoby == 1) {
                        Osoba.Items.Add(p.ID + ". " + p.Imię + " " + p.Nazwisko + "  -  " + p.Stanowisko);
                        idTab[i] = p.ID;
                        i++;
                    }
                }

                return idTab;
            }
        }

        private void zwolnij_Click(object sender, EventArgs e) {
            
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                Dane.zwolnienie(this.selectedID, System.DateTime.Today.Date);
                Dane.SaveChanges();
                Osoba.Items.Clear();
                this.idTab = printDane();
            }
        }

        private void Osoba_SelectedIndexChanged(object sender, EventArgs e) {//osoba.click
            this.selectedID = idTab[Osoba.SelectedIndex];
        }
    }
}
