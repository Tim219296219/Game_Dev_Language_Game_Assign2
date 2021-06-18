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
    public partial class FrmShapes_F2 : Form
    {
        int correctAnswer;
        int question = 1;
        public FrmShapes_F2()
        {
            InitializeComponent();
            displayQuestion(question);
        }

        private void displayQuestion(int question)
        {
            switch (question)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Square;
                    lblQuestion.Text = "What is the french word for 'square'?";

                    btn1.Text = "Cinqe";
                    btn2.Text = "Losange";
                    btn3.Text = "Quatre";
                    btn4.Text = "Carré";

                    correctAnswer = 4;

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
                FrmShapes_F3 shapes3 = new FrmShapes_F3();
                shapes3.ShowDialog();
            }
            else if (answer != correctAnswer)
            {
                MessageBox.Show("Incorrect!");
                this.Hide();
                FrmShapes_F2 shapes2 = new FrmShapes_F2();
                shapes2.ShowDialog();
            }
        }
    }
}