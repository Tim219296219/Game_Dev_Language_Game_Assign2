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
    public partial class FrmAnimals_S1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmAnimals_S1()
        {
            InitializeComponent();
        }

        private void btnBonjour_MouseDown(object sender, MouseEventArgs e)
        {
            btnelPerro.DoDragDrop(btnelPerro.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnAurevoir_MouseDown(object sender, MouseEventArgs e)
        {
            btnPezdorado.DoDragDrop(btnPezdorado.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnCommentallezvous_MouseDown(object sender, MouseEventArgs e)
        {
            btnelgato.DoDragDrop(btnelgato.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnBonsoir_MouseDown(object sender, MouseEventArgs e)
        {
            btnelloro.DoDragDrop(btnelloro.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnBonjourSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "el Perro.wav";
            player.Play();
        }

        private void btnAurevoirSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "el gato.wav";
            player.Play();
        }

        private void btnCommentallezvousSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Pez dorado_.wav";
            player.Play();
        }

        private void btnBonsoirSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "el loro.wav";
            player.Play();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "el Perro")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "el Gato")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Pez dorado")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "el Loro")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmAnimals_S2 S2 = new FrmAnimals_S2();
            this.Hide();
            S2.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCategoriesS S = new FrmCategoriesS();
            this.Hide();
            S.ShowDialog();
        }
    }
}