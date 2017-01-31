using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate_Scoring_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime _start;
        private void startTimer_Button_Click(object sender, EventArgs e)
        {
            _start = DateTime.Now;
            timer1.Start();
        }

        private void stopTimer_Button_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - _start;
            label.Text = duration.ToString();
        }

    }
}
