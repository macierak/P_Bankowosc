using System;
using System.Linq;
using System.Windows.Forms;

namespace PBank {
    public partial class FormWyswietlDane : Form {
        P_BankowoscEntities bazadanych;
        public FormWyswietlDane() {
            InitializeComponent();
            bazadanych = new P_BankowoscEntities();
        }

        private void klienci_Click(object sender, EventArgs e) {
            dane.DataSource = bazadanych.klienci.ToList<klienci>();
        }

        private void pracownicy_Click(object sender, EventArgs e) {
            dane.DataSource = bazadanych.pracownicy.ToList<pracownicy>();
        }

        private void exPracownicy_Click(object sender, EventArgs e) {
            dane.DataSource = bazadanych.expracownicy.ToList<expracownicy>();
        }

        private void exKlienci_Click(object sender, EventArgs e) {
            dane.DataSource = bazadanych.exklienci.ToList<exklienci>();
        }
    }
}
