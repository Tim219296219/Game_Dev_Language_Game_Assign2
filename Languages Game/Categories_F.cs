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
    public partial class FrmCategoriesF : Form
    {
        public FrmCategoriesF()
        {
            InitializeComponent();
            displayHeading();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Select a category";
        }

        private void btnPhrases_Click(object sender, EventArgs e)
        {
            FrmPhrases_F1 phrases = new FrmPhrases_F1();
            this.Hide();
            phrases.ShowDialog();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            FrmNumbers_F1 numbers = new FrmNumbers_F1();
            this.Hide();
            numbers.ShowDialog();
        }

        private void btnShapes_Click(object sender, EventArgs e)
        {
            FrmShapes_F1 shapes = new FrmShapes_F1();
            this.Hide();
            shapes.ShowDialog();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            FrmAnimals_F1 animals = new FrmAnimals_F1();
            this.Hide();
            animals.ShowDialog();
        }

        private void btnFruits_Click(object sender, EventArgs e)
        {
            FrmFruits_F1 fruits = new FrmFruits_F1();
            this.Hide();
            fruits.ShowDialog();
        }
    }
}
