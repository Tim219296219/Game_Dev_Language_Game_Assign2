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
    public partial class FrmFruits_F1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmFruits_F1()
        {
            InitializeComponent();
            displayHeading();
            displayFruits();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Look at the following fruits in french";
        }

        private void displayFruits()
        {
            lbl1.Text = "Pomme";
            lbl2.Text = "Banane";
            lbl3.Text = "Orange";
            lbl4.Text = "Citron";
            lbl5.Text = "Fraise";
            lbl6.Text = "Raisin";
        }

        private void btnPomme_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Pomme.wav";
            player.Play();
        }

        private void btnBananes_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Banane.wav";
            player.Play();
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Orange.wav";
            player.Play();
        }

        private void btnCitron_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Citron.wav";
            player.Play();
        }

        private void btnFraise_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Fraise.wav";
            player.Play();
        }

        private void btnRaisin_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Raisin.wav";
            player.Play();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmFruits_F2 F2 = new FrmFruits_F2();
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
