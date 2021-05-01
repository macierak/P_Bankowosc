using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PBank {
    public partial class FormLogin : Form {
        private int permissionLevel;
        private string ImNaz;
        //BankowoscEntities Dane;



        public FormLogin() {
            InitializeComponent();
        }

        private void logowanie_Click(object sender, EventArgs e) {
            string login1 = login.Text;
            string haslo1 = haslo.Text;

            login.Text = null;
            haslo.Text = null;
            using (BankowoscEntities Dane = new BankowoscEntities()) {
                
                var zalogowanyP = from p in Dane.Pracownik
                                  where (p.login.Equals(login1) && p.haslo.Equals(haslo1))
                                  select p;

                foreach (Pracownik p in zalogowanyP) {
                    if (p.Stanowisko == "Dyrektor"){
                        permissionLevel = 100;
                    }
                    if (p.Stanowisko == "Zarzadca Oddzialu") {
                        permissionLevel = 50;
                    }
                    if (p.Stanowisko == "Konsultant") {
                        permissionLevel = 30;
                    }
                    if (p.Stanowisko == "Asystent") {
                        permissionLevel = 20;
                    } 
                    //MessageBox.Show("Zalogowano jako " + p.Stanowisko + " " + p.Imię + " " + p.Nazwisko);
                    
                    ImNaz = p.Imię + " " + p.Nazwisko;
                 
                }

                var zalogowanyK = from k in Dane.Klient
                                  where (k.login.Equals(login1) && k.haslo.Equals(haslo1))
                                  select k;
                
                foreach(Klient k in zalogowanyK) {
                    //MessageBox.Show("Zalogowano jako klient " + k.Imię + " " + k.Nazwisko);
                    permissionLevel = 5;
                    ImNaz = k.Imię + " " + k.Nazwisko;
                }


                if (permissionLevel == 0) {
                    wrongpass.Visible = true;
                }
                else {
                    this.Visible = false;
                    switch (permissionLevel) {
                        case 5:
                            _FormKlient formK = new _FormKlient(ImNaz, this);
                            formK.ShowDialog();
                            break;
                        case 20:
                            _FormAsystent formA = new _FormAsystent(ImNaz, this);
                            formA.ShowDialog();
                            break;
                        case 30:
                            _FormKonsultant formKo = new _FormKonsultant(ImNaz, this);
                            formKo.ShowDialog();
                            break;
                        case 50:
                            _FormZarzadca formZ = new _FormZarzadca(ImNaz, this);
                            formZ.ShowDialog();
                            break;
                        case 100:
                            _FormDyrektor formD = new _FormDyrektor(ImNaz, this);
                            formD.ShowDialog();
                            break;
                    }
                  
                    
                    
                    
                }


            }
            
        }
    }
}
