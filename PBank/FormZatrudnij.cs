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
        TextBox[] tekst;
        public FormZatrudnij(int permlvl) {
            InitializeComponent();
            TextBox[] tekst = { imie, nazwisko, pesel, nr_komputera, przelozony, pensja, login, haslo };
            if (permlvl <51) stanowisko.Items.RemoveAt(2);
        }

        private void zatrudnij_Click(object sender, EventArgs e) {
            bool correct = true;
            if(pesel.TextLength != 11) {
                pesel.BackColor = System.Drawing.Color.Red;
                correct = false;
            }
            foreach(TextBox TB in this.tekst) {
                if(TB.TextLength == 0) {
                    TB.BackColor = System.Drawing.Color.Red;
                    correct = false;
                }
            }
            if (correct) {
                using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                    Dane.zatrudnij(imie.Text, nazwisko.Text, pesel.Text, stanowisko.SelectedItem.ToString(), int.Parse(nr_komputera.Text), int.Parse(przelozony.Text), double.Parse(pensja.Text), login.Text, haslo.Text);
                }
            }
        }
    }
}
