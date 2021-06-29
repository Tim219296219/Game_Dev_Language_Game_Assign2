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
    public partial class FrmPhrases_F2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmPhrases_F2()
        {
            InitializeComponent();
        }

        private void btnJetaime_MouseDown(object sender, MouseEventArgs e)
        {
            btnJetaime.DoDragDrop(btnJetaime.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btnJemappelle.DoDragDrop(btnJemappelle.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btnMerci.DoDragDrop(btnMerci.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btnJetenprie.DoDragDrop(btnJetenprie.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            player.SoundLocation = "Je t'aime.wav";
            player.Play();
        }

        private void btnJemappelleSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "je m'appelle.wav";
            player.Play();
        }

        private void btnMerciSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Merci.wav";
            player.Play();
        }

        private void btnJetenprieSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Je t'en prie.wav";
            player.Play();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Je t'aime")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Je m'appelle")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Merci")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Je t'en prie")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmPhrases_F3 F3 = new FrmPhrases_F3();
            this.Hide();
            F3.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmPhrases_F1 F1 = new FrmPhrases_F1();
            this.Hide();
            F1.ShowDialog();
        }
    }
}
