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
    public partial class FrmShapes_S3 : Form
    {
        public FrmShapes_S3()
        {
            InitializeComponent();
            displayHeading();
            displayShapes();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Match the shape to the spanish word";

        }

        private void displayShapes()
        {
            lbl1.Text = "Cuadro";
            lbl2.Text = "Triángulo";
            lbl3.Text = "Ovalo";
            lbl4.Text = "Circulo";
            lbl5.Text = "Rectángulo";
            lbl6.Text = "Diamante";
        }

        private void pictureBoxCuadro_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCuadro.DoDragDrop(pictureBoxCuadro.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void pictureBoxTriángulo_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxTriángulo.DoDragDrop(pictureBoxTriángulo.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void pictureBoxOvalo_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxOvalo.DoDragDrop(pictureBoxOvalo.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void pictureBoxCirculo_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCirculo.DoDragDrop(pictureBoxCirculo.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void pictureBoxRectángulo_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRectángulo.DoDragDrop(pictureBoxRectángulo.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void pictureBoxDiamante_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxDiamante.DoDragDrop(pictureBoxDiamante.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void FrmShapes_S3_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == pictureBoxCuadro.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == pictureBoxTriángulo.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == pictureBoxOvalo.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == pictureBoxCirculo.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == pictureBoxRectángulo.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == pictureBoxDiamante.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmFruits_F2 F2 = new FrmFruits_F2();
            this.Hide();
            F2.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmCategoriesS S = new FrmCategoriesS();
            this.Hide();
            S.ShowDialog();
        }
    }
}
