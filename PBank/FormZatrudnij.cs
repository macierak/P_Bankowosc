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
    public partial class FormZatrudnij : Form {
        public TextBox[] tekst;
        bool isCorrect = true;
        public FormZatrudnij(int permlvl) {
            InitializeComponent();
            this.tekst = new TextBox[8];

            this.tekst[0] = imie;
            this.tekst[1] = nazwisko;
            this.tekst[2] = pesel;
            this.tekst[3] = nr_komputera;
            this.tekst[4] = przelozony;
            this.tekst[5] = pensja;
            this.tekst[6] = login;
            this.tekst[7] = haslo;
            if (permlvl <51) stanowisko.Items.RemoveAt(2);
        }

        private void zatrudnij_Click(object sender, EventArgs e) {
            isCorrect = true;
            stanowisko.BackColor = System.Drawing.Color.DarkCyan;
            foreach (TextBox txt in tekst) {
                txt.BackColor = System.Drawing.Color.DarkCyan;
            }

            if (stanowisko.SelectedIndex == -1) {
                stanowisko.BackColor = System.Drawing.Color.DarkRed;
                isCorrect = false;
                stanowisko.ForeColor = System.Drawing.Color.White;
            }
            foreach (TextBox txt in tekst) {
                if(txt.TextLength == 0) {
                    txt.BackColor = System.Drawing.Color.DarkRed;
                    isCorrect = false;
                }
            }
            if (pesel.TextLength != 11) isCorrect = false;
            if (isCorrect) {
                using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                    Dane.zatrudnij(imie.Text, nazwisko.Text, pesel.Text, stanowisko.SelectedItem.ToString(), int.Parse(nr_komputera.Text), int.Parse(przelozony.Text), double.Parse(pensja.Text), login.Text, haslo.Text);
                }
                foreach (TextBox txt in tekst) {
                    txt.Text = "";               
                }
                stanowisko.SelectedIndex = -1;
                stanowisko.ForeColor = System.Drawing.Color.White;
            }
            else {
                stanowisko.ForeColor = System.Drawing.Color.White;
            }
        }

        private void label10_MouseUp(object sender, MouseEventArgs e) {
            label10.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void label10_MouseDown(object sender, MouseEventArgs e) {
            label10.BackColor = System.Drawing.Color.DarkSlateGray;
            
        }
    }
}
