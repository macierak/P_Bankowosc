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
        double stanKonta, nowaKwota;
        int idKlienta;
        _FormKonsultant form;
        bool correct;

        public _FormKlient(string nazwa, string adres_, string pesel_, string nr, double konto_, int id,_FormKonsultant form) {
            InitializeComponent();
            this.Text = "PBanK   Klient " + nazwa;
            this.form = form;
            this.stanKonta = konto_;
            this.idKlienta = id;

            imie.Text = nazwa;
            adres.Text = adres_;
            pesel.Text = pesel_;
            nr_dowodu.Text = nr;
            konto.Text = konto_.ToString();
        }

        private void _FormKlient_FormClosing(object sender, FormClosingEventArgs e) {
            form.Visible = true;
        }

        private Boolean check() {
            correct = true;
            kwota.BackColor = System.Drawing.Color.DarkCyan;
            if (kwota.TextLength == 0) {
                correct = false;
                kwota.BackColor = System.Drawing.Color.DarkRed;
                return false;
            }
            try {
                nowaKwota = Double.Parse(kwota.Text);
                return true;
            } catch {
                kwota.BackColor = System.Drawing.Color.DarkRed;
                return false;
            }
        }

        private void wplata_Click(object sender, EventArgs e) {
            if(check()) {
                kwota.Text = "";
                String text = "Wpłata wynosi: " + nowaKwota;
                using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                    Dane.wplac(idKlienta, nowaKwota);

                    var log = from k in Dane.Klient
                              where (k.ID.Equals(idKlienta))
                              select k;
                    foreach (Klient k in log) {
                        konto.Text = k.Stan_Konta.ToString();
                        MessageBox.Show(text, "Powodzenie operacji", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } else {
                MessageBox.Show("Wpłata nie powiodła się.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void wplata_MouseDown(object sender, MouseEventArgs e) {
            wplata.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void wplata_MouseUp(object sender, MouseEventArgs e) {
            wplata.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void wyplata_Click(object sender, EventArgs e) {
            if (check() && nowaKwota <= stanKonta) {
                kwota.Text = "";
                String text = "Wypłata wynosi: " + nowaKwota;
                using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                    Dane.wyplac(idKlienta, nowaKwota);
                    var log = from k in Dane.Klient
                              where (k.ID.Equals(idKlienta))
                              select k;
                    foreach(Klient k in log) {
                        konto.Text = k.Stan_Konta.ToString();

                        MessageBox.Show(text, "Powodzenie operacji", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } else {
                kwota.BackColor = System.Drawing.Color.DarkRed;
                MessageBox.Show("Wypłata nie powiodła się.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void wyplata_MouseDown(object sender, MouseEventArgs e) {
            wyplata.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        private void wyplata_MouseUp(object sender, MouseEventArgs e) {
            wyplata.BackColor = System.Drawing.Color.DarkCyan;
        }
    }
}
