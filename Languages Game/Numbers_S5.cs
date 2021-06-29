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
    public partial class FrmNumbers_S5 : Form
    {
        public FrmNumbers_S5()
        {
            InitializeComponent();
            displayHeadings();
        }

        private void displayHeadings()
        {
            lblHeading.Text = "Fill in the missing numbers";

            btnSeis.Text = "Seis";
            btnOcho.Text = "Ocho";
            btnCuatro.Text = "Cuatro";
            btnUva.Text = "Uva";
        }

        private void btnSeis_MouseDown(object sender, MouseEventArgs e)
        {
            btnSeis.DoDragDrop(btnSeis.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnOcho_MouseDown(object sender, MouseEventArgs e)
        {
            btnOcho.DoDragDrop(btnOcho.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnCuatro_MouseDown(object sender, MouseEventArgs e)
        {
            btnCuatro.DoDragDrop(btnCuatro.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnUva_MouseDown(object sender, MouseEventArgs e)
        {
            btnUva.DoDragDrop(btnUva.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Seis" && txtBox2.Text == "Ocho")
            {
                MessageBox.Show("Correct!");
                this.Hide();
                FrmNumbers_S6 S6 = new FrmNumbers_S6();
                S6.ShowDialog();
            }
            else if (txtBox1.Text != "Seis" && txtBox2.Text == "Ocho" || txtBox1.Text == "Seis"
                && txtBox2.Text != "Ocho" || txtBox1.Text != "Seis" && txtBox2.Text != "Ocho")
            {
                MessageBox.Show("Incorrect!");
            }

        }
    }
}
