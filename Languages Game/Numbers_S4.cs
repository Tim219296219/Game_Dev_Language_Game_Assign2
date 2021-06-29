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
    public partial class FrmNumbers_S4 : Form
    {
        public FrmNumbers_S4()
        {
            InitializeComponent();
            displayHeadings();
        }

        private void displayHeadings()
        {
            lblHeading.Text = "Fill in the missing numbers";

            btnDos.Text = "Dos";
            btnCinco.Text = "Cinco";
            btnOcho.Text = "Ocho";
            btnCaballo.Text = "Caballo";
        }

        private void btnDos_MouseDown(object sender, MouseEventArgs e)
        {
            btnDos.DoDragDrop(btnDos.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnCinco_MouseDown(object sender, MouseEventArgs e)
        {
            btnCinco.DoDragDrop(btnCinco.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnOcho_MouseDown(object sender, MouseEventArgs e)
        {
            btnOcho.DoDragDrop(btnOcho.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnCaballo_MouseDown(object sender, MouseEventArgs e)
        {
            btnCaballo.DoDragDrop(btnCaballo.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Dos" && txtBox2.Text == "Cinco")
            {
                MessageBox.Show("Correct!");
                this.Hide();
                FrmNumbers_S5 S5 = new FrmNumbers_S5();
                S5.ShowDialog();
            }
            else if (txtBox1.Text != "Dos" && txtBox2.Text == "Cinco" || txtBox1.Text == "Dos"
                && txtBox2.Text != "Cinco" || txtBox1.Text != "Dos" && txtBox2.Text != "Cinco")
            {
                MessageBox.Show("Incorrect!");
            }

        }
    }
}
