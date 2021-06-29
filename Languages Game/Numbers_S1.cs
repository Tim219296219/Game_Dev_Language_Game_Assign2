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
    public partial class FrmNumbers_S1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public FrmNumbers_S1()
        {
            InitializeComponent();
            displayHeading();
            displayNumbers();

        }

        private void displayHeading()
        {
            lblHeading.Text = "Look at the following numbers in spanish";
        }

        private void displayNumbers()
        {
            lbl1.Text = "Uno";
            lbl2.Text = "Dos";
            lbl3.Text = "Tres";
            lbl4.Text = "Cuatro";
            lbl5.Text = "Cinco";
            lbl6.Text = "Seis";
            lbl7.Text = "Siete";
            lbl8.Text = "Ocho";
            lbl9.Text = "Nueve";
            lbl10.Text = "Diez";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Uno.wav";
            player.Play();
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Dos.wav";
            player.Play();
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Tres.wav";
            player.Play();
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Cuatro.wav";
            player.Play();
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Cinco.wav";
            player.Play();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Seis.wav";
            player.Play();
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Siete.wav";
            player.Play();
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Ocho.wav";
            player.Play();
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Nueve.wav";
            player.Play();
        }

        private void btnDiez_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Diez.wav";
            player.Play();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmNumbers_S2 S2 = new FrmNumbers_S2();
            this.Hide();
            S2.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCategoriesS S = new FrmCategoriesS();
            this.Hide();
            S.ShowDialog();
        }
    }
}
