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
    public partial class FrmGreetings_F1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmGreetings_F1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Hello.wav";
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Good Bye.wav";
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\How Are You familiar.wav";
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\Good Evening.wav";
            player.Play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bonjure")
                MessageBox.Show("Correct!");
            else MessageBox.Show("incorrect");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "au revoir")
                MessageBox.Show("Correct!");
            else MessageBox.Show("incorrect");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Comment allez-vous")
                MessageBox.Show("Correct!");
            else MessageBox.Show("incorrect");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "bonsoir")
                MessageBox.Show("Correct!");
            else MessageBox.Show("incorrect");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmGreetings_F2 GreetingsF2 = new FrmGreetings_F2();
            GreetingsF2.ShowDialog();
            this.Hide();
        }
    }
}
