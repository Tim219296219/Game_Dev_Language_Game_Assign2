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
            lblHeading.Text = "Look at the following shapes in french   ";
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
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Carré.wav";
            player.Play();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Triangle.wav";
            player.Play();
        }

        private void btnOvale_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Ovale.wav";
            player.Play();
        }

        private void btnCercle_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Cercle.wav";
            player.Play();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Rectangle.wav";
            player.Play();
        }

        private void btnLosange_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Losange.wav";
            player.Play();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmShapes_F2 shapes = new FrmShapes_F2();
            shapes.ShowDialog();
        }

    }
}
