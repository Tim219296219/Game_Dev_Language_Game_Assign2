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
    public partial class FrmCategoriesS : Form
    {
        public FrmCategoriesS()
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
            FrmPhrases_S1 phrases = new FrmPhrases_S1();
            this.Hide();
            phrases.ShowDialog();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            FrmNumbers_S1 numbers = new FrmNumbers_S1();
            this.Hide();
            numbers.ShowDialog();
        }

        private void btnShapes_Click(object sender, EventArgs e)
        {
            FrmShapes_S1 shapes = new FrmShapes_S1();
            this.Hide();
            shapes.ShowDialog();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            FrmAnimals_S1 animals = new FrmAnimals_S1();
            this.Hide();
            animals.ShowDialog();
        }

        private void btnFruits_Click(object sender, EventArgs e)
        {
            FrmFruits_S1 fruits = new FrmFruits_S1();
            this.Hide();
            fruits.ShowDialog();
        }
    }
}
