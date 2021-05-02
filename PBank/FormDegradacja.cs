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
    public partial class FormDegradacja : Form {
        string next;
        int[] IdTab;
        int id;
        int permissionLevel;

        public FormDegradacja(int perm) {
            InitializeComponent();
            this.IdTab = printDane();
            this.permissionLevel = perm;
        }

        public int[] printDane() {
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                var zalogowanyP = from p in Dane.Pracownik
                                  select p;
                this.IdTab = new int[zalogowanyP.Count()];
                int i = 0;
                foreach (Pracownik p in zalogowanyP) {
                    if (p.Stanowisko == "Dyrektor" || p.Stanowisko == "Asystent") continue;
                    if (p.Stanowisko == "Zarzadca Oddzialu" && this.permissionLevel == 50) continue;
                    Osoba.Items.Add(p.ID + ". " + p.Imię + " " + p.Nazwisko + "  -  " + p.Stanowisko);
                    this.IdTab[i] = p.ID;
                    i++;
                }
            }
            return IdTab;
        }


        private void Degraduj_Click(object sender, EventArgs e) {
            Osoba.Items.Clear();
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                Dane.Awans(this.next, this.id);
                Dane.SaveChanges();
                this.IdTab = printDane();
            }
        }

        private void Osoba_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                string stanowisko = Osoba.SelectedItem.ToString();
                this.id = IdTab[Osoba.SelectedIndex];

                if (stanowisko.Contains("Konsultant")) {
                    this.next = "Asystent";
                }
                if (stanowisko.Contains("Zarzadca Oddzialu")) {
                    this.next = "Konsultant";
                }
            }
            catch (System.NullReferenceException) {

            }
        }
    }
}
