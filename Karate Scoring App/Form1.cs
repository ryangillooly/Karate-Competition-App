﻿using System;
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
        int m = 0;
        int s = 0;
        int state = 0;
        public Boolean IsMoveToPointEnabled { get; set; }

        //Global variables
        internal const int CloseApp_Click = 0xF060;     //close button's code in windows api
        internal const int MF_GRAYED = 0x1;             //disabled button status (enabled = false)
        internal const int MF_ENABLED = 0x00000000;     //enabled button status
        internal const int MF_DISABLED = 0x00000002;    //disabled button status

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            //TopMost = true;                                                                           //Application is in front of all other programs
            //FormBorderStyle = FormBorderStyle.None;                                                   //Do not apply any border to this program
            //WindowState     = FormWindowState.Maximized;                                              //Start this program maximised

            object backgroundImage = Properties.Resources.ResourceManager.GetObject("backgroundimage_1280");
            this.BackgroundImage = (Image)backgroundImage;

            timeSelection_Slider.SmallChange = 1;
            timeSelection_Slider.LargeChange = 5;

              inputTime_Textbox.Select();                                                                 //Puts focus on the textbox to enable typing immediately
        }

        private void timeSelection_Slider_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show(timeSelection_Slider.Value.ToString());

        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        //*******************************************************************************//
        // Countdown Timer Section //

        private void startTimer_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled || inputTime_Textbox.Text == "" || inputTime_Textbox.Text == "0")        //If timer is enabled, break out. Don't allow it to reset m = labeltext. If input is blank or 0 then break out.
            {
                return;                                                                                 //Break out of the startTimer_Button_Click method
            }

            if (state == 1)                                                                             //If state  = 1, the pause button has been pressed, and the timer has stopped
            {
                timer1.Start();                                                                         //Re-start the timer from where it left off
                return;                                                                                 //Break out of the startTimer_Button_Click method
            }

            m = Convert.ToInt32(inputTime_Textbox.Text);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            
            if(s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if (m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("Completed.");
            }

            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            minsLabel.Text = mm;
            secondsLabel.Text = ss;

        }

        private void pauseTimer_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                state = 1; //State is equal to 1 if the pause button has been pressed;
                timer1.Stop();
            }
        }

        private void resetTime_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                state = 3; //State is equal to 3 if the timer is active when pressing RESET
                //m = Convert.ToInt32(inputTime_Textbox.Text);
                timer1.Stop();
            }
            else
            {
                state = 2; //State is equal to 2 if the timer is not active when pressing RESET
                m = 0;
            }
            minsLabel.Text       = "00";
            secondsLabel.Text    = "00";
            redScore_Label.Text  = "0";
            blueScore_Label.Text = "0";
            s = 0;
        }

         //*******************************************************************************//
        // Red Team Score //

        int redScore;

        private void punchRed_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                redScore = Convert.ToInt32(redScore_Label.Text) + 1;
                redScore_Label.Text = Convert.ToString(redScore);
            }
        }

        private void chudanKickRed_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                redScore = Convert.ToInt32(redScore_Label.Text) + 2;
                redScore_Label.Text = Convert.ToString(redScore);
            }
        }

        private void jodanKickRed_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                redScore = Convert.ToInt32(redScore_Label.Text) + 3;
                redScore_Label.Text = Convert.ToString(redScore);
            }
        }

        private void sweepRed_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                redScore = Convert.ToInt32(redScore_Label.Text) + 3;
                redScore_Label.Text = Convert.ToString(redScore);
            }
        }

        //********************//
        // Keyboard Strokes   //

        private void punchRed_KeyStroke_Press(object sender, EventArgs e)
        {

        }

        private void chudanKickRed_KeyStroke_Press(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                redScore = Convert.ToInt32(redScore_Label.Text) + 2;
                redScore_Label.Text = Convert.ToString(redScore);
            }
        }

        private void jodanKickRed_KeyStroke_Press(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                redScore = Convert.ToInt32(redScore_Label.Text) + 3;
                redScore_Label.Text = Convert.ToString(redScore);
            }
        }

        private void sweepRed_KeyStroke_Press(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                redScore = Convert.ToInt32(redScore_Label.Text) + 3;
                redScore_Label.Text = Convert.ToString(redScore);
            }
        }

        //*******************************************************************************//
        // Blue Team Score //

        int blueScore;

        private void punchBlue_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                blueScore = Convert.ToInt32(blueScore_Label.Text) + 1;
                blueScore_Label.Text = Convert.ToString(blueScore);
            }
        }

        private void chudanKickBlue_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                blueScore = Convert.ToInt32(blueScore_Label.Text) + 2;
                blueScore_Label.Text = Convert.ToString(blueScore);
            }
        }

        private void jodanKickBlue_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                blueScore = Convert.ToInt32(blueScore_Label.Text) + 3;
                blueScore_Label.Text = Convert.ToString(blueScore);
            }
        }

        private void sweepBlue_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                blueScore = Convert.ToInt32(blueScore_Label.Text) + 3;
                blueScore_Label.Text = Convert.ToString(blueScore);
            }
        }


         //********************//
        // Keyboard Strokes   //

        private void punchBlue_KeyStroke_Press(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                blueScore = Convert.ToInt32(blueScore_Label.Text) + 1;
                blueScore_Label.Text = Convert.ToString(blueScore);
            }
        }

        private void chudanKickBlue_KeyStroke_Press(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                blueScore = Convert.ToInt32(blueScore_Label.Text) + 2;
                blueScore_Label.Text = Convert.ToString(blueScore);
            }
        }

        private void jodanKickBlue_KeyStroke_Press(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                blueScore = Convert.ToInt32(blueScore_Label.Text) + 3;
                blueScore_Label.Text = Convert.ToString(blueScore);
            }
        }

        private void sweepBlue_KeyStroke_Press(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                blueScore = Convert.ToInt32(blueScore_Label.Text) + 3;
                blueScore_Label.Text = Convert.ToString(blueScore);
            }
        }

        //*******************************************************************************//


    }
}
