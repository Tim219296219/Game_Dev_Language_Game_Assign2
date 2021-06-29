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
    public partial class FrmNumbers_F4 : Form
    {
        public FrmNumbers_F4()
        {
            InitializeComponent();
            displayHeadings();
        }

        private void displayHeadings()
        {
            lblHeading.Text = "Fill in the missing numbers";

            btnDeux.Text = "Deux";
            btnCinq.Text = "Cinq";
            btnHuit.Text = "Huit";
            btnCitron.Text = "Citron";
        }

        private void btnDeux_MouseDown(object sender, MouseEventArgs e)
        {
            btnDeux.DoDragDrop(btnDeux.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnCinq_MouseDown(object sender, MouseEventArgs e)
        {
            btnCinq.DoDragDrop(btnCinq.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnHuit_MouseDown(object sender, MouseEventArgs e)
        {
            btnHuit.DoDragDrop(btnHuit.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnCitron_MouseDown(object sender, MouseEventArgs e)
        {
            btnCitron.DoDragDrop(btnCitron.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Deux" && txtBox2.Text == "Cinq")
            {
                MessageBox.Show("Correct!");
                this.Hide();
                FrmNumbers_F5 F5 = new FrmNumbers_F5();
                F5.ShowDialog();
            }
            else if (txtBox1.Text != "Deux" && txtBox2.Text == "Cinq" || txtBox1.Text == "Deux"
                && txtBox2.Text != "Cinq" || txtBox1.Text != "Deux" && txtBox2.Text != "Cinq")
            {
                MessageBox.Show("Incorrect!");
            }

        }
    }
}
