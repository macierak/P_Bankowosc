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
    public partial class _FormAsystent : Form {

        FormLogin form;

        public _FormAsystent(string ImNaz, FormLogin form) {
            InitializeComponent();
            this.Text = "PBanK   Asystent " + ImNaz;
            this.form = form;
        }

        private void _FormAsystent_Leave(object sender, EventArgs e) {
            
            
        }

        private void _FormAsystent_FormClosing(object sender, FormClosingEventArgs e) {
            form.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (pb.Value < 100) {
                pb.Value += 1;
            }
            else {
                timer1.Enabled = false;
                pb.Visible = false;
                label1.Visible = true;
                System.IO.Stream ding = Properties.Resources.ding;
                System.Media.SoundPlayer kawa = new System.Media.SoundPlayer(ding);
                kawa.Play();
                pictureBox1.Image = Properties.Resources.korwin;
            }         
        }

        private void label1_Click(object sender, EventArgs e) {
            pb.Value = 0;
            timer1.Enabled = true;
            label1.Visible = false;
            pb.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.tenor;
        }
    }
}
