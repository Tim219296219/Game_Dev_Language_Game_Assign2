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
    public partial class FrmNumbers_F3 : Form
    {
        public FrmNumbers_F3()
        {
            InitializeComponent();
            displayHeadings();
        }

        private void displayHeadings()
        {
            lblHeading.Text = "Match the french word to the number";

            btnSix.Text = "Six";
            btnSept.Text = "Sept";
            btnHuit.Text = "Huit";
            btnNeuf.Text = "Neuf";
            btnDix.Text = "Dix";

        }

        private void btnSix_MouseDown(object sender, MouseEventArgs e)
        {
            btnSix.DoDragDrop(btnSix.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnSept_MouseDown(object sender, MouseEventArgs e)
        {
            btnSept.DoDragDrop(btnSept.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnNeuf_MouseDown(object sender, MouseEventArgs e)
        {
            btnNeuf.DoDragDrop(btnNeuf.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnDix_MouseDown(object sender, MouseEventArgs e)
        {
            btnDix.DoDragDrop(btnDix.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Six")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Sept")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Huit")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Neuf")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (txtBox5.Text == "Dix")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmNumbers_F4 F4 = new FrmNumbers_F4();
            this.Hide();
            F4.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmNumbers_F2 F2 = new FrmNumbers_F2();
            this.Hide();
            F2.ShowDialog();
        }
    }
}
