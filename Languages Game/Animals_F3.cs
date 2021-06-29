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
    public partial class FrmAnimals_F3 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmAnimals_F3()
        {
            InitializeComponent();
        }

        private void btnBonjour_MouseDown(object sender, MouseEventArgs e)
        {
            btnbaleine.DoDragDrop(btnbaleine.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btndauphin.DoDragDrop(btndauphin.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btnrequin.DoDragDrop(btnrequin.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            btnpoisson.DoDragDrop(btnpoisson.Text, DragDropEffects.Copy | DragDropEffects.Move);
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
            player.SoundLocation = "Fish.wav";
            player.Play();
        }

        private void btnAurevoirSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Dolphin.wav";
            player.Play();
        }

        private void btnCommentallezvousSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Shark.wav";
            player.Play();
        }

        private void btnBonsoirSnd_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "Whale.wav";
            player.Play();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Poisson")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Dauphin")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (txtBox3.Text == "Requin")

                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Incorrect!");
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Baleine")

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
            FrmAnimals_F2 F2 = new FrmAnimals_F2();
            this.Hide();
            F2.ShowDialog();
        }
    }
}
