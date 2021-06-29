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
    public partial class FrmFruits_F3 : Form
    {
        public FrmFruits_F3()
        {
            InitializeComponent();
            displayHeading();
            displayFruits();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Match the image to the french word";

        }

        private void displayFruits()
        {
            lbl1.Text = "Pomme";
            lbl2.Text = "Banane";
            lbl3.Text = "Orange";
            lbl4.Text = "Citron";
            lbl5.Text = "Fraise";
            lbl6.Text = "Raisin";
        }

        private void pictureBoxPomme_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxPomme.DoDragDrop(pictureBoxPomme.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxBananes_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBananes.DoDragDrop(pictureBoxBananes.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxOrange_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxOrange.DoDragDrop(pictureBoxOrange.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxCitron_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxCitron.DoDragDrop(pictureBoxCitron.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxFraise_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxFraise.DoDragDrop(pictureBoxFraise.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxRaisin_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRaisin.DoDragDrop(pictureBoxRaisin.BackgroundImage, DragDropEffects.Copy);
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

        private void FrmFruits_F3_Load(object sender, EventArgs e)
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
            if (pictureBox1.Image == pictureBoxPomme.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == pictureBoxBananes.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == pictureBoxOrange.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == pictureBoxCitron.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == pictureBoxFraise.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == pictureBoxRaisin.BackgroundImage)

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
            FrmCategoriesF F = new FrmCategoriesF();
            this.Hide();
            F.ShowDialog();
        }
    }
}
