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
    public partial class FrmFruits_S2 : Form
    {
        public FrmFruits_S2()
        {
            InitializeComponent();
            displayHeading();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Match the spanish word to the fruit";

            btnManzana.Text = "Manzana";
            btnPlatano.Text = "Plátano";
            btnNaranja.Text = "Naranja";
            btnLimon.Text = "Limón";
            btnFresa.Text = "Fresa";
            btnUva.Text = "Uva";
            
        }

        private void btnManzana_MouseDown(object sender, MouseEventArgs e)
        {
            btnManzana.DoDragDrop(btnManzana.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnPlatano_MouseDown(object sender, MouseEventArgs e)
        {
            btnPlatano.DoDragDrop(btnPlatano.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnNaranja_MouseDown(object sender, MouseEventArgs e)
        {
            btnNaranja.DoDragDrop(btnNaranja.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnLimon_MouseDown(object sender, MouseEventArgs e)
        {
            btnLimon.DoDragDrop(btnLimon.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnFresa_MouseDown(object sender, MouseEventArgs e)
        {
            btnFresa.DoDragDrop(btnFresa.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnUva_MouseDown(object sender, MouseEventArgs e)
        {
            btnUva.DoDragDrop(btnUva.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            if (txtBox1.Text == "Manzana")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Plátano")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Naranja")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Limón")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (txtBox5.Text == "Fresa")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {
            if (txtBox6.Text == "Uva")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmFruits_S3 S3 = new FrmFruits_S3();
            this.Hide();
            S3.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmFruits_S1 S1 = new FrmFruits_S1();
            this.Hide();
            S1.ShowDialog();
        }
    }
}