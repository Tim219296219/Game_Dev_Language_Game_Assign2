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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if(panel2.Width >= 600)
            {
                timer1.Stop();
                FrmMain Main = new FrmMain();
                this.Hide();
                Main.ShowDialog();
            }
        }
    }
}
