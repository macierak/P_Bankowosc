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
    public partial class FormAwans : Form {
        string next;
        int[] IdTab;
        int id, idosoby;
        string[] pensja;

        public FormAwans(int ID) {
            InitializeComponent();
            this.idosoby = ID;
            this.IdTab = printDane();
        }
       
        public int[] printDane() {
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {               
                var zalogowanyP = from p in Dane.Pracownik
                                  select p;
                this.IdTab = new int[zalogowanyP.Count()];
                this.pensja = new string[zalogowanyP.Count()];
                int i = 0;
                foreach (Pracownik p in zalogowanyP) {
                    if (p.Stanowisko == "Dyrektor" || p.Stanowisko == "Zarzadca Oddzialu") continue;
                    if (p.Przełożony == this.idosoby || this.idosoby == 1) {
                        Osoba.Items.Add(p.ID + ". " + p.Imię + " " + p.Nazwisko + "  -  " + p.Stanowisko);
                        this.IdTab[i] = p.ID;
                        this.pensja[i] = p.Pensja.ToString();
                        i++;
                    }
                }
            }
            return IdTab;
        }

        private void FormAwans_Click(object sender, EventArgs e) {
            try {
                float nowaPensja = float.Parse(Pensja2.Text);
                Osoba.Items.Clear();
                using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                    Dane.Pracownik_Manage(this.next, this.id, nowaPensja);
                    Dane.SaveChanges();
                    this.IdTab = printDane();
                }
            }
            catch(System.FormatException) {
                
            }
            Pensja2.Text = "";
        }


        private void label1_MouseUp(object sender, MouseEventArgs e) {
            label1.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e) {
            label1.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void Pensja2_Click(object sender, EventArgs e) {
            Pensja2.Text = "";
        }

        private void Osoba_Click(object sender, EventArgs e) {
            
            Pensja2.Text = this.pensja[Osoba.SelectedIndex];
            try {
                string stanowisko = Osoba.SelectedItem.ToString();
                this.id = IdTab[Osoba.SelectedIndex];

                if (stanowisko.Contains("Asystent")) this.next = "Konsultant";
                else this.next = "Zarzadca Oddzialu";
            }
            catch (System.NullReferenceException) { }
        }
    }
}
