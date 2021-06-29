﻿using System;
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
    public partial class FrmPhrases_F3 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmPhrases_F3()
        {
            InitializeComponent();
        }

        private void btnSilvousplait_MouseDown(object sender, MouseEventArgs e)
        {
            btnSilvousplait.DoDragDrop(btnSilvousplait.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btnJecomprends.DoDragDrop(btnJecomprends.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btnHeurex.DoDragDrop(btnHeurex.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btnParlezvousanglais.DoDragDrop(btnParlezvousanglais.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            player.SoundLocation = "S'il vous plaît.wav";
            player.Play();
        }

        private void btnJecomprendsSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Je comprends.wav";
            player.Play();
        }

        private void btnHeureuxSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Heureux de vous rencontrer.wav";
            player.Play();
        }

        private void btnParlezvousanglaisSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Parlez vous anglais.wav";
            player.Play();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "S'il vous plaît")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Je comprends")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Heureux de vous rencontrer")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Parlez vous anglais")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmCategoriesF F = new FrmCategoriesF();
            this.Hide();
            F.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmPhrases_F2 F2 = new FrmPhrases_F2();
            this.Hide();
            F2.ShowDialog();
        }
    }
}
