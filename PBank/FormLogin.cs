using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace PBank {
    public partial class FormLogin : Form {
        int ID = 0;
        private int permissionLevel;
        private string ImNaz;
        Random rand = new Random();
        private string[] randomBs = {"Uprzejmie informujemy, że w dniu dzisiejszym, w godzinach 8 - 23 odbędą się prace techniczne. Za utrudnienia przepraszamy", 
                                     "Moim zdaniem to nie ma tak, że dobrze albo że nie dobrze. Gdybym miał powiedzieć, co cenię w życiu najbardziej, powiedziałbym, że ludzi. Ekhm... Ludzi, którzy podali mi pomocną dłoń, kiedy sobie nie radziłem, kiedy byłem sam. I co ciekawe, to właśnie przypadkowe spotkania wpływają na nasze życie. Chodzi o to, że kiedy wyznaje się pewne wartości, nawet pozornie uniwersalne, bywa, że nie znajduje się zrozumienia, które by tak rzec, które pomaga się nam rozwijać. Ja miałem szczęście, by tak rzec, ponieważ je znalazłem. I dziękuję życiu. Dziękuję mu, życie to śpiew, życie to taniec, życie to miłość. Wielu ludzi pyta mnie o to samo, ale jak ty to robisz?, skąd czerpiesz tę radość? A ja odpowiadam, że to proste, to umiłowanie życia, to właśnie ono sprawia, że dzisiaj na przykład buduję maszyny, a jutro... kto wie, dlaczego by nie, oddam się pracy społecznej i będę ot, choćby sadzić... znaczy... marchew.",
                                     "Miłego dnia! :D",
                                     "Bugi zdarzają się najlepszym, a że my jesteśmy najlepsi, to zdarzają się nam cały czas.",
                                     "Patrzę na was… Głodnych… Przerażonych… Przyciskających dzieci do piersi. Cesarz Emhyr wprowadził swoje legiony na nasze ziemie, oblega każdą twierdzę stąd aż po Góry Sine. Wściekły i wygłodniały, wciąż gryzie i kąsa! Ludzie Północy stoicie nad przepaścią! Wasi królowie zawiedli, więc zwracacie się do bogów! A jednak nie błagacie o przebaczenie? Nie posypujecie głów popiołem? Zamiast tego lamentujecie! Pytacie ‘czemu bogowie nas opuścili?’ Musimy wrócić na drogę, którą porzuciliśmy dawno temu! W przeszłości nasz świat przeplatał się z innymi w procesie, który uczeni nazwali Koniunkcją Sfer. Bogowie pozwolili wedrzeć się tu nieczystym siłom. Pokłosiem tego kataklizmu jest nikczemna siła zwana magią… A jednak nie wygnaliśmy jej. Zamiast tego studiujemy jej niegodziwe arkana, by zdobyć władzę i bogactwo! A co z potworami u naszych drzwi? Ohydnymi reliktami Koniunkcji Sfer? Trollami…? Trupojadami…? I wilkołakami? Czy podnosimy przeciw nim oręż? Czy raczej zrzucamy ten ciężar na innych? Na tak zwanych wiedźminów. Porzucone dzieci, szkolone, by używać mrocznej magii, zmutowane za pomocą bluźnierczych rytuałów. Wysłani do walki z potworami, nie potrafią odróżnić dobra od zła. Blady płomień człowieczeństwa, który kiedyś w nich płonął, już dawno zgasł. Z każdym rokiem jest ich coraz mniej, to prawda. Ale kilku wciąż przemierza nasze ziemie, przelewając krew za pieniądze. Po dziś dzień swym istnieniem przynoszą nam hańbę! Północ krwawi, chłostana biczem wojny! To kara bogów za nasze grzechy! Nie zapominajmy też o okrutnej pladze spoza naszego świata! Wszak Dziki Gon galopuje po niebie w każdą pełnię! Mroczni jeźdźcy porywają w nieznane nasze dzieci! Niektórzy mówią, że to zwiastuje drugą Koniunkcję! Czy damy radę powrócić na drogę światłości? Czy znajdziemy siłę, by wygnać czarodziejów z naszych królestw? Zjednoczyć się wokół ciepła Wiecznego Ognia? Bliski jest czas miecza i topora! Tej wojny nikt za nas nie wygra! Bliski jest czas szaleństwa i czas pogardy!",
                                     "To są drzwi. Drzwi trzeba otworzyć. Żeby otworzyć drzwi, trzeba strzelić w nie trzema ogromnymi promieniami światła. Obróćmy się. To jest maszyna generująca trzy ogromne promienie światła. Żeby strzelić trzema ogromnymi promieniami światła, trzeba stanąć na trzech płytkach. Ale z racji, że są one upaćkane czarnym glutem, my jako ekipa sprzątająca musimy je posprzątać."
                                     };


        public FormLogin() {
            InitializeComponent();
            
            randomBsGo.Text = this.randomBs[rand.Next(0, 5)];
        }

        private void logowanie_Click(object sender, EventArgs e) {        
            string login1 = login.Text;
            string haslo1 = haslo.Text;
            
            login.Text = null;
            haslo.Text = null;
            using (P_BankowoscEntities Dane = new P_BankowoscEntities()) {
                
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
                    ImNaz = p.Imię + " " + p.Nazwisko;
                    this.ID = p.ID;//
                }

            /*    var zalogowanyK = from k in Dane.Klient
                                  where (k.login.Equals(login1) && k.haslo.Equals(haslo1))
                                  select k;

                foreach (Klient k in zalogowanyK) {
                    //MessageBox.Show("Zalogowano jako klient " + k.Imię + " " + k.Nazwisko);
                    //if(loggedOnPhone()){
                        if (this.checkphone(/*device.getIMEI,k.Urzadzenie_Mobilne, k.Urzadzenie_Mobilne)) {


                            permissionLevel = 5;
                            ImNaz = k.Imię + " " + k.Nazwisko;
                            this.ID = k.ID;
                        }
                    else {
                        permissionLevel = 5;
                        ImNaz = k.Imię + " " + k.Nazwisko;
                        this.ID = k.ID;
                    }
                }
            */
                if (permissionLevel == 0) {
                    timer1.Enabled = true;
                    wrongpass.Visible = true;
                }
                else {
                    this.Visible = false;
                    switch (permissionLevel) {
                    /*    case 5:
                            _FormKlient formK = new _FormKlient(ImNaz, this);
                            formK.ShowDialog();
                            break;  */
                        case 20:
                            _FormAsystent formA = new _FormAsystent(ImNaz, this);
                            formA.ShowDialog();
                            break;
                        case 30:
                            _FormKonsultant formKo = new _FormKonsultant(ImNaz, this);
                            formKo.ShowDialog();
                            break;
                        case 50:
                            _FormZarzadca formZ = new _FormZarzadca(ImNaz, this, this.ID);
                            formZ.ShowDialog();
                            break;
                        case 100:
                            _FormDyrektor formD = new _FormDyrektor(ImNaz, this, this.ID);
                            formD.ShowDialog();
                            break;
                    }                    
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            wrongpass.Visible = false;
            timer1.Enabled = false;
        }
        private bool checkphone(string imeiIN, string imeiDB) {
            if (imeiIN == imeiDB) {

            }
            else {
                //return validatePhone();
            }


            return true;
        }
        private void logowanie_MouseDown(object sender, MouseEventArgs e) {
            logowanie.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void logowanie_MouseUp(object sender, MouseEventArgs e) {
            logowanie.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void timerText_Tick(object sender, EventArgs e) {        
            randomBsGo.Location = new Point(randomBsGo.Location.X - 1, randomBsGo.Location.Y);
            if (randomBsGo.Location.X < 0 - randomBsGo.Width + 1) {
                randomBsGo.Location = new Point(this.Width, randomBsGo.Location.Y);
                randomBsGo.Text = this.randomBs[this.rand.Next(0, 5)];
            }       
        }

        private void FormLogin_Load(object sender, EventArgs e) {

        }
    }
}
