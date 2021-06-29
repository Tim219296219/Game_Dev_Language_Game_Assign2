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
    public partial class FrmLangSelect : Form
    {
        public FrmLangSelect()
        {
            InitializeComponent();
            displayHeading();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Select a language";
        }

        private void btnFrench_Click(object sender, EventArgs e)
        {
            FrmCategoriesF category = new FrmCategoriesF();
            this.Hide();
            category.ShowDialog();
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            FrmCategoriesS category = new FrmCategoriesS();
            this.Hide();
            category.ShowDialog();
        }

    }
}
