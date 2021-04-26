using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PBank {
    public partial class Form1ss : Form {
        private int permissionLevel;
        //BankowoscEntities Dane;



        public Form1ss() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void logowanie_Click(object sender, EventArgs e) {
            string login1 = login.Text;
            string haslo1 = haslo.Text;

            MessageBox.Show(login1 + haslo1);
            using (BankowoscEntities Dane = new BankowoscEntities()) {
                var zalogowanyP = from p in Dane.Pracownik
                                    where (p.login.Equals(login1))// && p.haslo.Equals(haslo1))
                                    select p ;
                foreach (Pracownik p in zalogowanyP) {
                    MessageBox.Show("Zalogowano jako pracownik " + p.ID + " " + p.Imię + " " + p.Nazwisko);
                    permissionLevel = 10;
                    break;
                }

                var zalogowanyK = from k in Dane.Klient
                                    where (k.login.Equals(login1) && k.haslo.Equals(haslo1))
                                  select k;
                
                foreach(Klient k in zalogowanyK) {
                    MessageBox.Show("Zalogowano jako użytkownik " + k.Imię + " " + k.Nazwisko);
                    permissionLevel = 2;
                }


                if (permissionLevel < 2) MessageBox.Show("Dupa blada, nie znalazło!");



            }
            
        }

        private void login_TextChanged(object sender, EventArgs e) {

        }
    }
}
