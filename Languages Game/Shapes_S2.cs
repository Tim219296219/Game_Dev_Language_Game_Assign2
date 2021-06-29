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
    public partial class FrmShapes_S2 : Form
    {
        public FrmShapes_S2()
        {
            InitializeComponent();
            displayHeading();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Match the spanish word to the shape";

            btnCuadro.Text = "Cuadro";
            btnTriángulo.Text = "Triángulo";
            btnOvalo.Text = "Ovalo";
            btnCirculo.Text = "Circulo";
            btnRectángulo.Text = "Rectángulo";
            btnDiamante.Text = "Diamante";
            
        }

        private void btnCuadro_MouseDown(object sender, MouseEventArgs e)
        {
            btnCuadro.DoDragDrop(btnCuadro.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnTriángulo_MouseDown(object sender, MouseEventArgs e)
        {
            btnTriángulo.DoDragDrop(btnTriángulo.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnOvalo_MouseDown(object sender, MouseEventArgs e)
        {
            btnOvalo.DoDragDrop(btnOvalo.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnCirculo_MouseDown(object sender, MouseEventArgs e)
        {
            btnCirculo.DoDragDrop(btnCirculo.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnRectángulo_MouseDown(object sender, MouseEventArgs e)
        {
            btnRectángulo.DoDragDrop(btnRectángulo.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnDiamante_MouseDown(object sender, MouseEventArgs e)
        {
            btnDiamante.DoDragDrop(btnDiamante.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            if (txtBox1.Text == "Cuadro")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Triángulo")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Ovalo")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Circulo")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (txtBox5.Text == "Rectángulo")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {
            if (txtBox6.Text == "Diamante")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmShapes_S3 S3 = new FrmShapes_S3();
            this.Hide();
            S3.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmShapes_S1 S1 = new FrmShapes_S1();
            this.Hide();
            S1.ShowDialog();
        }
    }
}