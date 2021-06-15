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
    public partial class FormUsunKlient : Form {
        int[] idTab;
        int selectedId;
        public FormUsunKlient() {
            InitializeComponent();
            this.idTab = printDane();
        }

        private int[] printDane() {
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                var klient = from k in Dane.Klient
                                  select k;
                idTab = new int[klient.Count()];
                int i = 0;
                foreach (Klient k in klient) {
                    lista.Items.Add(k.ID + ". " + k.Imię + " " + k.Nazwisko);
                    this.idTab[i] = k.ID;
                    i++;
                }
                return idTab;
            }
        }

        private void Usun_Click(object sender, EventArgs e) {
            if(this.selectedId > 0) {
                String nazwa = "";
                String adres = "";
                String pesel = "";
                String nr = "";
                using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                    var klient = from k in Dane.Klient
                                 where k.ID == this.selectedId
                                 select k;
                    foreach (Klient k in klient) {
                        nazwa = k.Imię + " " + k.Nazwisko;
                        adres = k.Adres;
                        pesel = k.Pesel;
                        nr = k.Nr_Dowodu;
                    }
                    FormPotwierdzUsun formPotwierdz = new FormPotwierdzUsun(nazwa, adres, pesel, nr, this.selectedId, this);
                    formPotwierdz.ShowDialog();
                }
            }
            
        }

        public void reload() {
            lista.Items.Clear();
            this.selectedId = -1;
            this.idTab = printDane();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e) {
            this.selectedId = idTab[lista.SelectedIndex];
        }
    }
}
