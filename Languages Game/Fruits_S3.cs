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
    public partial class FrmFruits_S3 : Form
    {
        public FrmFruits_S3()
        {
            InitializeComponent();
            displayHeading();
            displayFruits();
        }

        private void displayHeading()
        {
            lblHeading.Text = "Match the image to the spanish word";

        }

        private void displayFruits()
        {
            lbl1.Text = "Manzana";
            lbl2.Text = "Plátano";
            lbl3.Text = "Naranja";
            lbl4.Text = "Limón";
            lbl5.Text = "Fresa";
            lbl6.Text = "Uva";
        }

        private void pictureBoxManzana_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxManzana.DoDragDrop(pictureBoxManzana.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxPlatano_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxPlatano.DoDragDrop(pictureBoxPlatano.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxNaranja_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxNaranja.DoDragDrop(pictureBoxNaranja.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxLimon_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxLimon.DoDragDrop(pictureBoxLimon.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxFresa_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxFresa.DoDragDrop(pictureBoxFresa.BackgroundImage, DragDropEffects.Copy);
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

        private void pictureBoxUva_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxUva.DoDragDrop(pictureBoxUva.BackgroundImage, DragDropEffects.Copy);
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

        private void FrmFruits_S3_Load(object sender, EventArgs e)
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
            if (pictureBox1.Image == pictureBoxManzana.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == pictureBoxPlatano.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == pictureBoxNaranja.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == pictureBoxLimon.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == pictureBoxFresa.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == pictureBoxUva.BackgroundImage)

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmCategoriesS S = new FrmCategoriesS();
            this.Hide();
            S.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmFruits_S2 S2 = new FrmFruits_S2();
            this.Hide();
            S2.ShowDialog();
        }
    }
}
