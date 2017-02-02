namespace Karate_Scoring_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startTimer_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minsLabel = new System.Windows.Forms.Label();
            this.pauseTimer_Button = new System.Windows.Forms.Button();
            this.resetTime_Button = new System.Windows.Forms.Button();
            this.inputTime_Textbox = new System.Windows.Forms.TextBox();
            this.colonLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.redScore_Label = new System.Windows.Forms.Label();
            this.punchRed_Button = new System.Windows.Forms.Button();
            this.sweepRed_Button = new System.Windows.Forms.Button();
            this.jodanKickRed_Button = new System.Windows.Forms.Button();
            this.chudanKickRed_Button = new System.Windows.Forms.Button();
            this.chudanKickBlue_Button = new System.Windows.Forms.Button();
            this.jodanKickBlue_Button = new System.Windows.Forms.Button();
            this.sweepBlue_Button = new System.Windows.Forms.Button();
            this.punchBlue_Button = new System.Windows.Forms.Button();
            this.lka_PictureBox = new System.Windows.Forms.PictureBox();
            this.blueBack_PictureBox = new System.Windows.Forms.PictureBox();
            this.redBack_PictureBox = new System.Windows.Forms.PictureBox();
            this.blueScore_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lka_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBack_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBack_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startTimer_Button
            // 
            this.startTimer_Button.Location = new System.Drawing.Point(458, 631);
            this.startTimer_Button.Name = "startTimer_Button";
            this.startTimer_Button.Size = new System.Drawing.Size(97, 64);
            this.startTimer_Button.TabIndex = 0;
            this.startTimer_Button.Text = "Start";
            this.startTimer_Button.UseVisualStyleBackColor = true;
            this.startTimer_Button.Click += new System.EventHandler(this.startTimer_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minsLabel
            // 
            this.minsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minsLabel.Location = new System.Drawing.Point(499, 441);
            this.minsLabel.Name = "minsLabel";
            this.minsLabel.Size = new System.Drawing.Size(79, 57);
            this.minsLabel.TabIndex = 1;
            this.minsLabel.Text = "00";
            this.minsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pauseTimer_Button
            // 
            this.pauseTimer_Button.Location = new System.Drawing.Point(664, 631);
            this.pauseTimer_Button.Name = "pauseTimer_Button";
            this.pauseTimer_Button.Size = new System.Drawing.Size(97, 64);
            this.pauseTimer_Button.TabIndex = 2;
            this.pauseTimer_Button.Text = "Pause";
            this.pauseTimer_Button.UseVisualStyleBackColor = true;
            this.pauseTimer_Button.Click += new System.EventHandler(this.pauseTimer_Button_Click);
            // 
            // resetTime_Button
            // 
            this.resetTime_Button.Location = new System.Drawing.Point(561, 631);
            this.resetTime_Button.Name = "resetTime_Button";
            this.resetTime_Button.Size = new System.Drawing.Size(97, 64);
            this.resetTime_Button.TabIndex = 3;
            this.resetTime_Button.Text = "Stop / Reset";
            this.resetTime_Button.UseVisualStyleBackColor = true;
            this.resetTime_Button.Click += new System.EventHandler(this.resetTime_Button_Click);
            // 
            // inputTime_Textbox
            // 
            this.inputTime_Textbox.Location = new System.Drawing.Point(593, 605);
            this.inputTime_Textbox.Name = "inputTime_Textbox";
            this.inputTime_Textbox.Size = new System.Drawing.Size(25, 20);
            this.inputTime_Textbox.TabIndex = 4;
            // 
            // colonLabel
            // 
            this.colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel.Location = new System.Drawing.Point(566, 441);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(79, 57);
            this.colonLabel.TabIndex = 5;
            this.colonLabel.Text = ":";
            this.colonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondsLabel
            // 
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(638, 441);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(79, 57);
            this.secondsLabel.TabIndex = 6;
            this.secondsLabel.Text = "00";
            this.secondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redScore_Label
            // 
            this.redScore_Label.AutoSize = true;
            this.redScore_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redScore_Label.Location = new System.Drawing.Point(264, 329);
            this.redScore_Label.Name = "redScore_Label";
            this.redScore_Label.Size = new System.Drawing.Size(98, 108);
            this.redScore_Label.TabIndex = 7;
            this.redScore_Label.Text = "0";
            // 
            // punchRed_Button
            // 
            this.punchRed_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.punchRed_Button.Location = new System.Drawing.Point(274, 581);
            this.punchRed_Button.Name = "punchRed_Button";
            this.punchRed_Button.Size = new System.Drawing.Size(138, 23);
            this.punchRed_Button.TabIndex = 8;
            this.punchRed_Button.Text = "Jodan/Chudan Punch";
            this.punchRed_Button.UseVisualStyleBackColor = true;
            this.punchRed_Button.Click += new System.EventHandler(this.punchRed_Button_Click);
            // 
            // sweepRed_Button
            // 
            this.sweepRed_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.sweepRed_Button.Location = new System.Drawing.Point(274, 668);
            this.sweepRed_Button.Name = "sweepRed_Button";
            this.sweepRed_Button.Size = new System.Drawing.Size(138, 23);
            this.sweepRed_Button.TabIndex = 9;
            this.sweepRed_Button.Text = "Sweep";
            this.sweepRed_Button.UseVisualStyleBackColor = true;
            this.sweepRed_Button.Click += new System.EventHandler(this.sweepRed_Button_Click);
            // 
            // jodanKickRed_Button
            // 
            this.jodanKickRed_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.jodanKickRed_Button.Location = new System.Drawing.Point(274, 639);
            this.jodanKickRed_Button.Name = "jodanKickRed_Button";
            this.jodanKickRed_Button.Size = new System.Drawing.Size(138, 23);
            this.jodanKickRed_Button.TabIndex = 10;
            this.jodanKickRed_Button.Text = "Jodan Kick";
            this.jodanKickRed_Button.UseVisualStyleBackColor = true;
            this.jodanKickRed_Button.Click += new System.EventHandler(this.jodanKickRed_Button_Click);
            // 
            // chudanKickRed_Button
            // 
            this.chudanKickRed_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.chudanKickRed_Button.Location = new System.Drawing.Point(274, 610);
            this.chudanKickRed_Button.Name = "chudanKickRed_Button";
            this.chudanKickRed_Button.Size = new System.Drawing.Size(138, 23);
            this.chudanKickRed_Button.TabIndex = 11;
            this.chudanKickRed_Button.Text = "Chudan Kick";
            this.chudanKickRed_Button.UseVisualStyleBackColor = true;
            this.chudanKickRed_Button.Click += new System.EventHandler(this.chudanKickRed_Button_Click);
            // 
            // chudanKickBlue_Button
            // 
            this.chudanKickBlue_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.chudanKickBlue_Button.Location = new System.Drawing.Point(802, 610);
            this.chudanKickBlue_Button.Name = "chudanKickBlue_Button";
            this.chudanKickBlue_Button.Size = new System.Drawing.Size(138, 23);
            this.chudanKickBlue_Button.TabIndex = 15;
            this.chudanKickBlue_Button.Text = "Chudan Kick";
            this.chudanKickBlue_Button.UseVisualStyleBackColor = true;
            this.chudanKickBlue_Button.Click += new System.EventHandler(this.chudanKickBlue_Button_Click);
            // 
            // jodanKickBlue_Button
            // 
            this.jodanKickBlue_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.jodanKickBlue_Button.Location = new System.Drawing.Point(802, 639);
            this.jodanKickBlue_Button.Name = "jodanKickBlue_Button";
            this.jodanKickBlue_Button.Size = new System.Drawing.Size(138, 23);
            this.jodanKickBlue_Button.TabIndex = 14;
            this.jodanKickBlue_Button.Text = "Jodan Kick";
            this.jodanKickBlue_Button.UseVisualStyleBackColor = true;
            this.jodanKickBlue_Button.Click += new System.EventHandler(this.jodanKickBlue_Button_Click);
            // 
            // sweepBlue_Button
            // 
            this.sweepBlue_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.sweepBlue_Button.Location = new System.Drawing.Point(802, 668);
            this.sweepBlue_Button.Name = "sweepBlue_Button";
            this.sweepBlue_Button.Size = new System.Drawing.Size(138, 23);
            this.sweepBlue_Button.TabIndex = 13;
            this.sweepBlue_Button.Text = "Sweep";
            this.sweepBlue_Button.UseVisualStyleBackColor = true;
            this.sweepBlue_Button.Click += new System.EventHandler(this.sweepBlue_Button_Click);
            // 
            // punchBlue_Button
            // 
            this.punchBlue_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.punchBlue_Button.Location = new System.Drawing.Point(802, 581);
            this.punchBlue_Button.Name = "punchBlue_Button";
            this.punchBlue_Button.Size = new System.Drawing.Size(138, 23);
            this.punchBlue_Button.TabIndex = 12;
            this.punchBlue_Button.Text = "Jodan/Chudan Punch";
            this.punchBlue_Button.UseVisualStyleBackColor = true;
            this.punchBlue_Button.Click += new System.EventHandler(this.punchBlue_Button_Click);
            // 
            // lka_PictureBox
            // 
            this.lka_PictureBox.Location = new System.Drawing.Point(482, -1);
            this.lka_PictureBox.Name = "lka_PictureBox";
            this.lka_PictureBox.Size = new System.Drawing.Size(235, 174);
            this.lka_PictureBox.TabIndex = 16;
            this.lka_PictureBox.TabStop = false;
            // 
            // blueBack_PictureBox
            // 
            this.blueBack_PictureBox.Location = new System.Drawing.Point(602, -1);
            this.blueBack_PictureBox.Name = "blueBack_PictureBox";
            this.blueBack_PictureBox.Size = new System.Drawing.Size(638, 721);
            this.blueBack_PictureBox.TabIndex = 17;
            this.blueBack_PictureBox.TabStop = false;
            // 
            // redBack_PictureBox
            // 
            this.redBack_PictureBox.Location = new System.Drawing.Point(0, -1);
            this.redBack_PictureBox.Name = "redBack_PictureBox";
            this.redBack_PictureBox.Size = new System.Drawing.Size(604, 721);
            this.redBack_PictureBox.TabIndex = 18;
            this.redBack_PictureBox.TabStop = false;
            // 
            // blueScore_Label
            // 
            this.blueScore_Label.AutoSize = true;
            this.blueScore_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueScore_Label.Location = new System.Drawing.Point(333, 329);
            this.blueScore_Label.Name = "blueScore_Label";
            this.blueScore_Label.Size = new System.Drawing.Size(98, 108);
            this.blueScore_Label.TabIndex = 19;
            this.blueScore_Label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 714);
            this.Controls.Add(this.blueScore_Label);
            this.Controls.Add(this.lka_PictureBox);
            this.Controls.Add(this.chudanKickBlue_Button);
            this.Controls.Add(this.jodanKickBlue_Button);
            this.Controls.Add(this.sweepBlue_Button);
            this.Controls.Add(this.punchBlue_Button);
            this.Controls.Add(this.chudanKickRed_Button);
            this.Controls.Add(this.jodanKickRed_Button);
            this.Controls.Add(this.sweepRed_Button);
            this.Controls.Add(this.punchRed_Button);
            this.Controls.Add(this.redScore_Label);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.colonLabel);
            this.Controls.Add(this.inputTime_Textbox);
            this.Controls.Add(this.resetTime_Button);
            this.Controls.Add(this.pauseTimer_Button);
            this.Controls.Add(this.minsLabel);
            this.Controls.Add(this.startTimer_Button);
            this.Controls.Add(this.blueBack_PictureBox);
            this.Controls.Add(this.redBack_PictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lka_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBack_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBack_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startTimer_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label minsLabel;
        private System.Windows.Forms.Button pauseTimer_Button;
        private System.Windows.Forms.Button resetTime_Button;
        private System.Windows.Forms.TextBox inputTime_Textbox;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label redScore_Label;
        private System.Windows.Forms.Button punchRed_Button;
        private System.Windows.Forms.Button sweepRed_Button;
        private System.Windows.Forms.Button jodanKickRed_Button;
        private System.Windows.Forms.Button chudanKickRed_Button;
        private System.Windows.Forms.Button chudanKickBlue_Button;
        private System.Windows.Forms.Button jodanKickBlue_Button;
        private System.Windows.Forms.Button sweepBlue_Button;
        private System.Windows.Forms.Button punchBlue_Button;
        private System.Windows.Forms.PictureBox lka_PictureBox;
        private System.Windows.Forms.PictureBox blueBack_PictureBox;
        private System.Windows.Forms.PictureBox redBack_PictureBox;
        private System.Windows.Forms.Label blueScore_Label;
    }
}

