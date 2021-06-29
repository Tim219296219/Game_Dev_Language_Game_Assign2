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
    public partial class FrmShapes_S1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmShapes_S1()
        {
            InitializeComponent();
            displayHeading();
            displayShapes();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Look at the following shapes in spanish";
        }

        private void displayShapes()
        {
            lbl1.Text = "Cuadro";
            lbl2.Text = "Triángulo";
            lbl3.Text = "Ovalo";
            lbl4.Text = "Circulo";
            lbl5.Text = "Rectángulo";
            lbl6.Text = "Diamante";
        }

        private void btnCuadro_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Cuadro.wav";
            player.Play();
        }

        private void btnTriángulo_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Triángulo.wav";
            player.Play();
        }

        private void btnOvalo_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "óvalo.wav";
            player.Play();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Círculo.wav";
            player.Play();
        }

        private void btnRectángulo_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Rectángulo.wav";
            player.Play();
        }

        private void btnDiamante_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Diamante.wav";
            player.Play();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmShapes_S2 S2 = new FrmShapes_S2();
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
