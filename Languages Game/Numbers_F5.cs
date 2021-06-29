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
    public partial class FrmNumbers_F5 : Form
    {
        public FrmNumbers_F5()
        {
            InitializeComponent();
            displayHeadings();
        }

        private void displayHeadings()
        {
            lblHeading.Text = "Fill in the missing numbers";

            btnSept.Text = "Sept";
            btnNeuf.Text = "Neuf";
            btnSeize.Text = "Seize";
            btnCinq.Text = "Cinq";
        }

        private void btnSept_MouseDown(object sender, MouseEventArgs e)
        {
            btnSept.DoDragDrop(btnSept.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox1_DragDrop(object sender, DragEventArgs e)
        {
            txtBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnNeuf_MouseDown(object sender, MouseEventArgs e)
        {
            btnNeuf.DoDragDrop(btnNeuf.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox2_DragDrop(object sender, DragEventArgs e)
        {
            txtBox2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnSeize_MouseDown(object sender, MouseEventArgs e)
        {
            btnSeize.DoDragDrop(btnSeize.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnCinq_MouseDown(object sender, MouseEventArgs e)
        {
            btnCinq.DoDragDrop(btnCinq.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Sept" && txtBox2.Text == "Neuf")
            {
                MessageBox.Show("Correct!");
                this.Hide();
                FrmNumbers_F6 F6 = new FrmNumbers_F6();
                F6.ShowDialog();
            }
            else if (txtBox1.Text != "Sept" && txtBox2.Text == "Neuf" || txtBox1.Text == "Sept"
                && txtBox2.Text != "Neuf" || txtBox1.Text != "Sept" && txtBox2.Text != "Neuf")
            {
                MessageBox.Show("Incorrect!");
            }

        }
    }
}
