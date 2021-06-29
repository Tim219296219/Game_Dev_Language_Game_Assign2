using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Languages_Game
{
    public partial class FrmNumbers_F1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public FrmNumbers_F1()
        {
            InitializeComponent();
            displayHeading();
            displayNumbers();

        }

        private void displayHeading()
        {
            lblHeading.Text = "Look at the following numbers in french ";
        }

        private void displayNumbers()
        {
            lbl1.Text = "Un";
            lbl2.Text = "Deux";
            lbl3.Text = "Trois";
            lbl4.Text = "Quatre";
            lbl5.Text = "Cinq";
            lbl6.Text = "Six";
            lbl7.Text = "Sept";
            lbl8.Text = "Huit";
            lbl9.Text = "Neuf";
            lbl10.Text = "Dix";
        }

        private void btnUn_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Un.wav";
            player.Play();
        }

        private void btnDeux_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Deux.wav";
            player.Play();
        }

        private void btnTrois_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Trois.wav";
            player.Play();
        }

        private void btnQuatre_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Quatre.wav";
            player.Play();
        }

        private void btnCinq_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Cinq.wav";
            player.Play();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Six.wav";
            player.Play();
        }

        private void btnSept_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Sept.wav";
            player.Play();
        }

        private void btnHuit_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Huit.wav";
            player.Play();
        }

        private void btnNeuf_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Neuf.wav";
            player.Play();
        }

        private void btnDix_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Dix.wav";
            player.Play();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmNumbers_F2 F2 = new FrmNumbers_F2();
            this.Hide();
            F2.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCategoriesF F = new FrmCategoriesF();
            this.Hide();
            F.ShowDialog();
        }
    }
}
