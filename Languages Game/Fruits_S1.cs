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
    public partial class FrmFruits_S1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmFruits_S1()
        {
            InitializeComponent();
            displayHeading();
            displayFruits();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Look at the following fruits in spanish";
        }

        private void displayFruits()
        {
            lbl1.Text = "Manzana";
            lbl2.Text = "Plátano";
            lbl3.Text = "Naranja";
            lbl4.Text = "Limón";
            lbl5.Text = "Fresa";
            lbl6.Text = "Uva";
        }

        private void btnManzana_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Manzana.wav";
            player.Play();
        }

        private void btnPlatano_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Plátano.wav";
            player.Play();
        }

        private void btnNaranja_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Naranja.wav";
            player.Play();
        }

        private void btnLimon_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Limón.wav";
            player.Play();
        }

        private void btnFresa_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Fresa.wav";
            player.Play();
        }

        private void btnUva_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Uva.wav";
            player.Play();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmFruits_S2 S2 = new FrmFruits_S2();
            this.Hide();
            S2.ShowDialog();
        }
    }
}
