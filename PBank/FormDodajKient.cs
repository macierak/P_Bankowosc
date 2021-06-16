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
    public partial class FormDodajKient : Form {
        bool isCorrect = true;
        private TextBox[] tekst;
        public FormDodajKient() {
            InitializeComponent();

            this.tekst = new TextBox[8];
            this.tekst[0] = imie;
            this.tekst[1] = nazwisko;
            this.tekst[2] = pesel;
            this.tekst[3] = urzadzenie;
            this.tekst[4] = adres;
            this.tekst[5] = nr_dowodu;
            this.tekst[6] = login;
            this.tekst[7] = haslo;
        }

        private void dodaj_Click(object sender, EventArgs e) {
            isCorrect = true;
            foreach (TextBox txt in tekst) {
                txt.BackColor = System.Drawing.Color.DarkCyan;
            }
            foreach (TextBox txt in tekst) {
                if (txt.TextLength == 0) {
                    txt.BackColor = System.Drawing.Color.DarkRed;
                    isCorrect = false;
                }
            }
            if (pesel.TextLength != 11) {
                isCorrect = false;
                pesel.BackColor = System.Drawing.Color.DarkRed;
            }
                
            if (urzadzenie.TextLength != 15) {
                isCorrect = false;
                urzadzenie.BackColor = System.Drawing.Color.DarkRed;
            }
            if (nr_dowodu.TextLength != 9) {
                isCorrect = false;
                nr_dowodu.BackColor = System.Drawing.Color.DarkRed;
            }

            if (isCorrect) {
                using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                    Dane.dodaj(imie.Text, nazwisko.Text, pesel.Text, nr_dowodu.Text, adres.Text, urzadzenie.Text, login.Text, haslo.Text);
                }
                foreach (TextBox txt in tekst) {
                    txt.Text = "";
                }
            }
        }

        private void dodaj_MouseUp(object sender, MouseEventArgs e) {
            dodaj.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void dodaj_MouseDown(object sender, MouseEventArgs e) {
            dodaj.BackColor = System.Drawing.Color.DarkSlateGray;
        }
    }
}
