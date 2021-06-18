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
    public partial class FrmNumbers_F2 : Form
    {
        int correctAnswer;
        int question = 1;
        public FrmNumbers_F2()
        {
            InitializeComponent();
            displayQuestion(question);
        }

        private void displayQuestion(int question)
        {
            switch (question)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Five;
                    lblQuestion.Text = "What is the french word for 'five'?";

                    btn1.Text = "Citron";
                    btn2.Text = "Huit";
                    btn3.Text = "Cinq";
                    btn4.Text = "Neuf";

                    correctAnswer = 3;

                    break;
            }
        }

        private void ClickAnswer(object sender, EventArgs e)
        {
            var ans = (Button)sender;
            int answer = Convert.ToInt32(ans.Tag);

            if (answer == correctAnswer)
            {
                MessageBox.Show("Correct!");
                this.Hide();
                FrmNumbers_F3 numbers3 = new FrmNumbers_F3();
                numbers3.ShowDialog();
            }
            else if (answer != correctAnswer)
            {
                MessageBox.Show("Incorrect!");
                this.Hide();
                FrmNumbers_F2 numbers2 = new FrmNumbers_F2();
                numbers2.ShowDialog();
            }
        }

    }
}
