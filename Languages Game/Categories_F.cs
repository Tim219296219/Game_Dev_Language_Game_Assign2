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

        private void btnGreetings_Click(object sender, EventArgs e)
        {
            FrmGreetings_F1 greetings = new FrmGreetings_F1();
            greetings.ShowDialog();
            this.Hide();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            FrmNumbers_F1 numbers = new FrmNumbers_F1();
            numbers.ShowDialog();
            this.Hide();
        }

        private void btnShapes_Click(object sender, EventArgs e)
        {
            FrmShapes_F1 shapes = new FrmShapes_F1();
            shapes.ShowDialog();
            this.Hide();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            FrmAnimals_F1 animals = new FrmAnimals_F1();
            animals.ShowDialog();
            this.Hide();
        }
    }
}
