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
    public partial class FrmGreetings_F2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FrmGreetings_F2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources/I love you.wav";
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources/My name is.wav";
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources/Thank you.wav";
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources/You're Welcome.wav";
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "je t'aime")
                MessageBox.Show("Correct!");
            else MessageBox.Show("incorrect");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "je m'appelle")
                MessageBox.Show("Correct!");
            else MessageBox.Show("incorrect");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Merci")
                MessageBox.Show("Correct!");
            else MessageBox.Show("incorrect");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "avec plaisir")
                MessageBox.Show("Correct!");
            else MessageBox.Show("incorrect");
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmGreetings_F1 GreetingsF1 = new FrmGreetings_F1();
            GreetingsF1.ShowDialog();
            this.Hide();
        }
    }
}
