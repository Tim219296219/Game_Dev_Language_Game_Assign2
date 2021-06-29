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
    public partial class FrmPhrases_S3 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmPhrases_S3()
        {
            InitializeComponent();
        }

        private void btnSilvousplait_MouseDown(object sender, MouseEventArgs e)
        {
            btnHablainglés.DoDragDrop(btnHablainglés.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnJecomprends_MouseDown(object sender, MouseEventArgs e)
        {
            btnMuchogusto.DoDragDrop(btnMuchogusto.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnHeurex_MouseDown(object sender, MouseEventArgs e)
        {
            btnPorfavor.DoDragDrop(btnPorfavor.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnParlezvousanglais_MouseDown(object sender, MouseEventArgs e)
        {
            btnComprendo.DoDragDrop(btnComprendo.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void btnSilvousplaitSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Pleases.wav";
            player.Play();
        }

        private void btnJecomprendsSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Iunderstand.wav";
            player.Play();
        }

        private void btnHeureuxSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Nicetomeetyou.wav";
            player.Play();
        }

        private void btnParlezvousanglaisSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Canyouspeak.wav";
            player.Play();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Por favor")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Comprendo")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Mucho gusto")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Habla inglés?")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmPhrases_S2 S2 = new FrmPhrases_S2();
            this.Hide();
            S2.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmCategoriesS S = new FrmCategoriesS();
            this.Hide();
            S.ShowDialog();
        }
    }
}
