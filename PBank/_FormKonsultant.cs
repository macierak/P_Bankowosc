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
    public partial class _FormKonsultant : Form {
        FormLogin form;
        private TextBox[] tekst;
        bool correct;
        public _FormKonsultant(string ImNaz, FormLogin form) {
            InitializeComponent();
            this.Text = "PBanK   Konsultant " + ImNaz;
            this.form = form;

            this.tekst = new TextBox[3];
            this.tekst[0] = imie;
            this.tekst[1] = nazwisko;
            this.tekst[2] = pesel;
        }

        private void _FormKonsultant_FormClosing(object sender, FormClosingEventArgs e) {
            form.Visible = true;
        }

        private void Remove_Click(object sender, EventArgs e) {
            FormUsunKlient formUsun = new FormUsunKlient();
            formUsun.ShowDialog();
        }

        private void Remove_MouseDown(object sender, MouseEventArgs e) {
            Remove.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void Remove_MouseUp(object sender, MouseEventArgs e) {
            Remove.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void add_Click(object sender, EventArgs e) {
            FormDodajKient formDodaj = new FormDodajKient();
            formDodaj.ShowDialog();
        }
        private void add_MouseDown(object sender, MouseEventArgs e) {
            add.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void add_MouseUp(object sender, MouseEventArgs e) {
            add.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void log_Click(object sender, EventArgs e) {
            correct = true;
            foreach (TextBox txt in tekst) {
                txt.BackColor = System.Drawing.Color.DarkCyan;
            }
            foreach (TextBox txt in tekst) {
                if (txt.TextLength == 0) {
                    txt.BackColor = System.Drawing.Color.DarkRed;
                    correct = false;
                }
            }
            if (pesel.TextLength != 11) {
                correct = false;
                pesel.BackColor = System.Drawing.Color.DarkRed;
            }

            if (correct) {
                blad.Visible = true;
                String nazwa = "";
                using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                    var logowanie = from k in Dane.Klient
                                where (k.login.Equals(imie.Text) && k.haslo.Equals(nazwisko.Text) && k.Pesel.Equals(pesel.Text))
                                select k;

                    foreach(Klient k in logowanie) {
                        blad.Visible = false;
                        nazwa = k.Imię + " " + k.Nazwisko;
                        this.Visible = false;

                        _FormKlient formK = new _FormKlient(nazwa, k.Adres, k.Pesel, k.Nr_Dowodu, k.Stan_Konta, k.ID, this);
                        formK.ShowDialog();

                        imie.Text = "";
                        nazwisko.Text = "";
                        pesel.Text = "";
                    }
                }
            }
        }

        private void log_MouseDown(object sender, MouseEventArgs e) {
            log.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void log_MouseUp(object sender, MouseEventArgs e) {
            log.BackColor = System.Drawing.Color.DarkCyan;
        }
    }
}
