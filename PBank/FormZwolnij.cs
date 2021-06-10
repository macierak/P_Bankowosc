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
        int idosoby, selectedID, permLvl;
        int[] idTab;
        public FormZwolnij(int ID, int permLvl) {
            InitializeComponent();
            this.idosoby = ID;
            this.idTab = printDane();
            this.permLvl = permLvl;
        }

        private int[] printDane() {
            
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                var zalogowanyP = from p in Dane.Pracownik
                                  select p;
                idTab = new int[zalogowanyP.Count()];
                int i = 0;
                foreach (Pracownik p in zalogowanyP) {
                    if (p.Stanowisko == "Dyrektor" || (p.Stanowisko == "Zarzadca Oddzialu" && this.permLvl > 51)) continue;
                    if (p.Przełożony == this.idosoby || this.idosoby == 1) {
                        Osoba.Items.Add(p.ID + ". " + p.Imię + " " + p.Nazwisko + " (" + p.Stanowisko + ")");
                        this.idTab[i] = p.ID;
                        i++;
                    }
                }

                return idTab;
            }
        }

        private void zwolnij_Click(object sender, EventArgs e) {
            string nazwa = "";
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                var zalogowanyP = from p in Dane.Pracownik
                                  where p.ID == this.selectedID
                                  select p;
                foreach (Pracownik p in zalogowanyP) {
                    nazwa = p.Imię + " " + p.Nazwisko;
                }
                string message = "Czy na pewno chcesz zwolnić pracownika\n" + nazwa;
                string title = "Zwolnienie";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes) {
                    Dane.zwolnienie(this.selectedID, System.DateTime.Today.Date);
                    Dane.SaveChanges();
                    Osoba.Items.Clear();
                    this.idTab = printDane();
                    
                }
            }
        }

        private void Osoba_SelectedIndexChanged(object sender, EventArgs e) {//osoba.click
            this.selectedID = idTab[Osoba.SelectedIndex];
        }
    }
}
