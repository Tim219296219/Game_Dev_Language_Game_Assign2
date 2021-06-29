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
    public partial class FrmShapes_F2 : Form
    {
        public FrmShapes_F2()
        {
            InitializeComponent();
            displayHeading();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Match the french word to the shape";

            btnCarré.Text = "Carré";
            btnTriangle.Text = "Triangle";
            btnOvale.Text = "Ovale";
            btnCercle.Text = "Cercle";
            btnRectangle.Text = "Rectangle";
            btnLosange.Text = "Losange";
            
        }

        private void btnCarré_MouseDown(object sender, MouseEventArgs e)
        {
            btnCarré.DoDragDrop(btnCarré.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnTriangle_MouseDown(object sender, MouseEventArgs e)
        {
            btnTriangle.DoDragDrop(btnTriangle.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnOvale_MouseDown(object sender, MouseEventArgs e)
        {
            btnOvale.DoDragDrop(btnOvale.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox3_DragDrop(object sender, DragEventArgs e)
        {
            txtBox3.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnCercle_MouseDown(object sender, MouseEventArgs e)
        {
            btnCercle.DoDragDrop(btnCercle.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox4_DragDrop(object sender, DragEventArgs e)
        {
            txtBox4.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            btnRectangle.DoDragDrop(btnRectangle.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox5_DragDrop(object sender, DragEventArgs e)
        {
            txtBox5.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnLosange_MouseDown(object sender, MouseEventArgs e)
        {
            btnLosange.DoDragDrop(btnLosange.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox6_DragDrop(object sender, DragEventArgs e)
        {
            txtBox6.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Carré")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Triangle")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Ovale")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Cercle")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (txtBox5.Text == "Rectangle")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {
            if (txtBox6.Text == "Losange")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmShapes_F3 F3 = new FrmShapes_F3();
            this.Hide();
            F3.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmShapes_F1 F1 = new FrmShapes_F1();
            this.Hide();
            F1.ShowDialog();
        }
    }
}