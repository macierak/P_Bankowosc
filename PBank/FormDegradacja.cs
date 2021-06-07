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
        double[] pensja;
        int id;
        int permissionLevel;
        int idosoby, nowapensja;
        public FormDegradacja(int perm, int id) {
            InitializeComponent();
            this.permissionLevel = perm;
            this.idosoby = id;
            this.IdTab = printDane();
        }
        public int[] printDane() {
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                
                var zalogowanyP = from p in Dane.Pracownik
                                  select p;
                this.IdTab = new int[zalogowanyP.Count()];
                this.pensja = new double[zalogowanyP.Count() + 1];
                int i = 0;
                foreach (Pracownik p in zalogowanyP) {
                    if (p.Stanowisko == "Dyrektor" || p.Stanowisko == "Asystent") continue;
                    if (p.Stanowisko == "Zarzadca Oddzialu" && this.permissionLevel < 51) continue;
                    if (p.Przełożony == this.idosoby || this.idosoby == 1) {
                        Osoba.Items.Add(p.ID + ". " + p.Imię + " " + p.Nazwisko + "  -  " + p.Stanowisko);
                        this.IdTab[i] = p.ID;
                        this.pensja[i] = p.Pensja;
                        i++;
                    }                    
                }
            }
            return IdTab;
        }


        private void Degraduj_Click(object sender, EventArgs e) {
            Osoba.Items.Clear();
            nowapensja = int.Parse(tekst_pensja.Text);
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                Dane.Pracownik_Manage(this.next, this.id, this.nowapensja);
                Dane.SaveChanges();
                this.IdTab = printDane();
            }
            tekst_pensja.Text = "";
        }

        private void tekst_pensja_Click(object sender, EventArgs e) {
            tekst_pensja.Text = "";
        }

        private void label1_MouseUp(object sender, MouseEventArgs e) {
            label1.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e) {
            label1.BackColor = System.Drawing.Color.DarkSlateGray;
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
                tekst_pensja.Text = pensja[Osoba.SelectedIndex].ToString();
            }
            catch (System.NullReferenceException) {

            }
        }
    }
}
