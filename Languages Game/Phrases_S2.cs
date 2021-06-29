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
    public partial class FrmPhrases_S2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmPhrases_S2()
        {
            InitializeComponent();
        }

        private void btnJetaime_MouseDown(object sender, MouseEventArgs e)
        {
            btnDenada.DoDragDrop(btnDenada.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnJemappelle_MouseDown(object sender, MouseEventArgs e)
        {
            btnGracias.DoDragDrop(btnGracias.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnMerci_MouseDown(object sender, MouseEventArgs e)
        {
            btnTequiero.DoDragDrop(btnTequiero.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnJetenprie_MouseDown(object sender, MouseEventArgs e)
        {
            btnMellamo.DoDragDrop(btnMellamo.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnJetaimeSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Iloveyous.wav";
            player.Play();
        }

        private void btnJemappelleSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Mynameis.wav";
            player.Play();
        }

        private void btnMerciSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Thankyou.wav";
            player.Play();
        }

        private void btnJetenprieSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Yourewelcome.wav";
            player.Play();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Te quiero")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Me llamo")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Gracias")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "De nada")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmPhrases_S3 S3 = new FrmPhrases_S3();
            this.Hide();
            S3.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmPhrases_S1 S1 = new FrmPhrases_S1();
            this.Hide();
            S1.ShowDialog();
        }
    }
}
