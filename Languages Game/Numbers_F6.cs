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
    public partial class FrmNumbers_F6 : Form
    {
        public FrmNumbers_F6()
        {
            InitializeComponent();
            displayHeadings();
        }

        private void displayHeadings()
        {
            lblHeading.Text = "Match the english number to the french number";

            btn1.Text = "One";
            btn2.Text = "Two";
            btn3.Text = "Three";
            btn4.Text = "Four";
            btn5.Text = "Five";
            btn6.Text = "Six";
            btn7.Text = "Seven";
            btn8.Text = "Eight";
            btn9.Text = "Nine";
            btn10.Text = "Ten";

        }

        private void btn5_MouseDown(object sender, MouseEventArgs e)
        {
            btn5.DoDragDrop(btn5.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btn9_MouseDown(object sender, MouseEventArgs e)
        {
            btn9.DoDragDrop(btn9.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox9_DragDrop(object sender, DragEventArgs e)
        {
            txtBox9.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btn8_MouseDown(object sender, MouseEventArgs e)
        {
            btn8.DoDragDrop(btn8.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox8_DragDrop(object sender, DragEventArgs e)
        {
            txtBox8.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btn3_MouseDown(object sender, MouseEventArgs e)
        {
            btn3.DoDragDrop(btn3.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btn4_MouseDown(object sender, MouseEventArgs e)
        {
            btn4.DoDragDrop(btn4.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btn6_MouseDown(object sender, MouseEventArgs e)
        {
            btn6.DoDragDrop(btn6.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            btn2.DoDragDrop(btn2.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btn10_MouseDown(object sender, MouseEventArgs e)
        {
            btn10.DoDragDrop(btn10.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox10_DragDrop(object sender, DragEventArgs e)
        {
            txtBox10.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btn7_MouseDown(object sender, MouseEventArgs e)
        {
            btn7.DoDragDrop(btn7.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBox7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBox7_DragDrop(object sender, DragEventArgs e)
        {
            txtBox7.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            btn1.DoDragDrop(btn1.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (txtBox5.Text == "Five")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck9_Click(object sender, EventArgs e)
        {
            if (txtBox9.Text == "Nine")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck8_Click(object sender, EventArgs e)
        {
            if (txtBox8.Text == "Eight")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Three")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Four")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {
            if (txtBox6.Text == "Six")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Two")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck10_Click(object sender, EventArgs e)
        {
            if (txtBox10.Text == "Ten")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck7_Click(object sender, EventArgs e)
        {
            if (txtBox7.Text == "Seven")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "One")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategoriesF category = new FrmCategoriesF();
            this.Hide();
            category.ShowDialog();
        }

    }
}
