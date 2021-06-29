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
    public partial class FrmShapes_F1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmShapes_F1()
        {
            InitializeComponent();
            displayHeading();
            displayShapes();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Look at the following shapes in french";
        }

        private void displayShapes()
        {
            lbl1.Text = "Carré";
            lbl2.Text = "Triangle";
            lbl3.Text = "Ovale";
            lbl4.Text = "Cercle";
            lbl5.Text = "Rectangle";
            lbl6.Text = "Losange";
        }

        private void btnCarré_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Carré.wav";
            player.Play();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Triangle.wav";
            player.Play();
        }

        private void btnOvale_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Ovale.wav";
            player.Play();
        }

        private void btnCercle_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Cercle.wav";
            player.Play();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Rectangle.wav";
            player.Play();
        }

        private void btnLosange_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Losange.wav";
            player.Play();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmShapes_F2 F2 = new FrmShapes_F2();
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
