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
    public partial class FrmNumbers_F1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public FrmNumbers_F1()
        {
            InitializeComponent();
            displayHeading();
            displayNumbers();

        }

        private void displayHeading()
        {
            lblHeading.Text = "Look at the following numbers in french ";
        }

        private void displayNumbers()
        {
            lbl1.Text = "un";
            lbl2.Text = "deux";
            lbl3.Text = "trois";
            lbl4.Text = "quatre";
            lbl5.Text = "cinq";
            lbl6.Text = "six";
            lbl7.Text = "sept";
            lbl8.Text = "huit";
            lbl9.Text = "neuf";
            lbl10.Text = "dix";
        }

        private void btnUn_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\un.wav";
            player.Play();
        }

        private void btnDeux_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\deux.wav";
            player.Play();
        }

        private void btnTrois_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\trois.wav";
            player.Play();
        }

        private void btnQuatre_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\quatre.wav";
            player.Play();
        }

        private void btnCinq_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\cinq.wav";
            player.Play();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\six.wav";
            player.Play();
        }

        private void btnSept_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\sept.wav";
            player.Play();
        }

        private void btnHuit_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\huit.wav";
            player.Play();
        }

        private void btnNeuf_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\neuf.wav";
            player.Play();
        }

        private void btnDix_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\M.Faeedh\source\repos\Languages Game\Languages Game\Resources\dix.wav";
            player.Play();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNumbers_F2 numbers = new FrmNumbers_F2();
            numbers.ShowDialog();
        }
    }
}
