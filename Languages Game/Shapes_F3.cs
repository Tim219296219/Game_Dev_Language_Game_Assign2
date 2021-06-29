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
    public partial class FrmShapes_F3 : Form
    {
        public FrmShapes_F3()
        {
            InitializeComponent();
            displayHeading();
            displayShapes();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Match the shape to the french word";

        }

        private void displayShapes()
        {
            lbl1.Text = "Carré";
            lbl2.Text = "Triangle";
            lbl3.Text = "Ovale";
            lbl4.Text = "Cercle";
            lbl5.Text = "Rectangle";
            lbl6.Text = "Losange";
        }

        private void pictureBoxCarré_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCarré.DoDragDrop(pictureBoxCarré.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxTriangle_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxTriangle.DoDragDrop(pictureBoxTriangle.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxOvale_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxOvale.DoDragDrop(pictureBoxOvale.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxCercle_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCercle.DoDragDrop(pictureBoxCercle.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRectangle.DoDragDrop(pictureBoxRectangle.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxLosange_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxLosange.DoDragDrop(pictureBoxLosange.BackgroundImage, DragDropEffects.Copy);
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

        private void FrmShapes_F3_Load(object sender, EventArgs e)
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
            if (pictureBox1.Image == pictureBoxCarré.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == pictureBoxTriangle.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == pictureBoxOvale.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == pictureBoxCercle.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == pictureBoxRectangle.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == pictureBoxLosange.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmShapes_F2 F2 = new FrmShapes_F2();
            this.Hide();
            F2.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmCategoriesF F = new FrmCategoriesF();
            this.Hide();
            F.ShowDialog();
        }
    }
}
