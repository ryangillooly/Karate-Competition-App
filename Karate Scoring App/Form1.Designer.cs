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
            this.pauseTimer_Button = new System.Windows.Forms.Button();
            this.resetTime_Button = new System.Windows.Forms.Button();
            this.inputTime_Textbox = new System.Windows.Forms.TextBox();
            this.chudanKickBlue_Button = new System.Windows.Forms.Button();
            this.jodanKickBlue_Button = new System.Windows.Forms.Button();
            this.sweepBlue_Button = new System.Windows.Forms.Button();
            this.punchBlue_Button = new System.Windows.Forms.Button();
            this.blueScore_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.colonLabel = new System.Windows.Forms.Label();
            this.minsLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lka_PictureBox = new System.Windows.Forms.PictureBox();
            this.punchRed_Button = new System.Windows.Forms.Button();
            this.chudanKick_Button = new System.Windows.Forms.Button();
            this.jodanKickRed_Button = new System.Windows.Forms.Button();
            this.sweepRed_Button = new System.Windows.Forms.Button();
            this.redScore_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lka_PictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startTimer_Button
            // 
            this.startTimer_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTimer_Button.Location = new System.Drawing.Point(3, 33);
            this.startTimer_Button.Name = "startTimer_Button";
            this.startTimer_Button.Size = new System.Drawing.Size(101, 57);
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
            // pauseTimer_Button
            // 
            this.pauseTimer_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseTimer_Button.Location = new System.Drawing.Point(217, 33);
            this.pauseTimer_Button.Name = "pauseTimer_Button";
            this.pauseTimer_Button.Size = new System.Drawing.Size(103, 57);
            this.pauseTimer_Button.TabIndex = 2;
            this.pauseTimer_Button.Text = "Pause";
            this.pauseTimer_Button.UseVisualStyleBackColor = true;
            this.pauseTimer_Button.Click += new System.EventHandler(this.pauseTimer_Button_Click);
            // 
            // resetTime_Button
            // 
            this.resetTime_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetTime_Button.Location = new System.Drawing.Point(110, 33);
            this.resetTime_Button.Name = "resetTime_Button";
            this.resetTime_Button.Size = new System.Drawing.Size(101, 57);
            this.resetTime_Button.TabIndex = 3;
            this.resetTime_Button.Text = "Stop / Reset";
            this.resetTime_Button.UseVisualStyleBackColor = true;
            this.resetTime_Button.Click += new System.EventHandler(this.resetTime_Button_Click);
            // 
            // inputTime_Textbox
            // 
            this.inputTime_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTime_Textbox.Location = new System.Drawing.Point(110, 3);
            this.inputTime_Textbox.Name = "inputTime_Textbox";
            this.inputTime_Textbox.Size = new System.Drawing.Size(101, 20);
            this.inputTime_Textbox.TabIndex = 4;
            this.inputTime_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chudanKickBlue_Button
            // 
            this.chudanKickBlue_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.chudanKickBlue_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chudanKickBlue_Button.Location = new System.Drawing.Point(3, 585);
            this.chudanKickBlue_Button.Name = "chudanKickBlue_Button";
            this.chudanKickBlue_Button.Size = new System.Drawing.Size(448, 39);
            this.chudanKickBlue_Button.TabIndex = 15;
            this.chudanKickBlue_Button.Text = "Chudan Kick";
            this.chudanKickBlue_Button.UseVisualStyleBackColor = true;
            this.chudanKickBlue_Button.Click += new System.EventHandler(this.chudanKickBlue_Button_Click);
            // 
            // jodanKickBlue_Button
            // 
            this.jodanKickBlue_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.jodanKickBlue_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jodanKickBlue_Button.Location = new System.Drawing.Point(3, 630);
            this.jodanKickBlue_Button.Name = "jodanKickBlue_Button";
            this.jodanKickBlue_Button.Size = new System.Drawing.Size(448, 37);
            this.jodanKickBlue_Button.TabIndex = 14;
            this.jodanKickBlue_Button.Text = "Jodan Kick";
            this.jodanKickBlue_Button.UseVisualStyleBackColor = true;
            this.jodanKickBlue_Button.Click += new System.EventHandler(this.jodanKickBlue_Button_Click);
            // 
            // sweepBlue_Button
            // 
            this.sweepBlue_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.sweepBlue_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sweepBlue_Button.Location = new System.Drawing.Point(3, 673);
            this.sweepBlue_Button.Name = "sweepBlue_Button";
            this.sweepBlue_Button.Size = new System.Drawing.Size(448, 38);
            this.sweepBlue_Button.TabIndex = 13;
            this.sweepBlue_Button.Text = "Sweep";
            this.sweepBlue_Button.UseVisualStyleBackColor = true;
            this.sweepBlue_Button.Click += new System.EventHandler(this.sweepBlue_Button_Click);
            // 
            // punchBlue_Button
            // 
            this.punchBlue_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.punchBlue_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.punchBlue_Button.Location = new System.Drawing.Point(3, 535);
            this.punchBlue_Button.Name = "punchBlue_Button";
            this.punchBlue_Button.Size = new System.Drawing.Size(448, 44);
            this.punchBlue_Button.TabIndex = 12;
            this.punchBlue_Button.Text = "Jodan/Chudan Punch";
            this.punchBlue_Button.UseVisualStyleBackColor = true;
            this.punchBlue_Button.Click += new System.EventHandler(this.punchBlue_Button_Click);
            // 
            // blueScore_Label
            // 
            this.blueScore_Label.AutoSize = true;
            this.blueScore_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueScore_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueScore_Label.Location = new System.Drawing.Point(3, 167);
            this.blueScore_Label.Name = "blueScore_Label";
            this.blueScore_Label.Size = new System.Drawing.Size(448, 244);
            this.blueScore_Label.TabIndex = 19;
            this.blueScore_Label.Text = "0";
            this.blueScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.punchBlue_Button, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.chudanKickBlue_Button, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.jodanKickBlue_Button, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.sweepBlue_Button, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.blueScore_Label, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(783, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 714);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lka_PictureBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(457, -1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(323, 207);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.Controls.Add(this.colonLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.minsLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.secondsLabel, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(457, 205);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(323, 92);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // colonLabel
            // 
            this.colonLabel.BackColor = System.Drawing.Color.Black;
            this.colonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.colonLabel.ForeColor = System.Drawing.Color.White;
            this.colonLabel.Location = new System.Drawing.Point(141, 0);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(39, 92);
            this.colonLabel.TabIndex = 5;
            this.colonLabel.Text = ":";
            this.colonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minsLabel
            // 
            this.minsLabel.BackColor = System.Drawing.Color.Black;
            this.minsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.minsLabel.ForeColor = System.Drawing.Color.White;
            this.minsLabel.Location = new System.Drawing.Point(3, 0);
            this.minsLabel.Name = "minsLabel";
            this.minsLabel.Size = new System.Drawing.Size(132, 92);
            this.minsLabel.TabIndex = 1;
            this.minsLabel.Text = "00";
            this.minsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondsLabel
            // 
            this.secondsLabel.BackColor = System.Drawing.Color.Black;
            this.secondsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.secondsLabel.ForeColor = System.Drawing.Color.White;
            this.secondsLabel.Location = new System.Drawing.Point(186, 0);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(134, 92);
            this.secondsLabel.TabIndex = 6;
            this.secondsLabel.Text = "00";
            this.secondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.pauseTimer_Button, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.resetTime_Button, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.startTimer_Button, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.inputTime_Textbox, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(457, 621);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5523F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(323, 93);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // lka_PictureBox
            // 
            this.lka_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.lka_PictureBox.BackgroundImage = global::Karate_Scoring_App.Properties.Resources.LKA;
            this.lka_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lka_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lka_PictureBox.Location = new System.Drawing.Point(3, 3);
            this.lka_PictureBox.Name = "lka_PictureBox";
            this.lka_PictureBox.Size = new System.Drawing.Size(317, 201);
            this.lka_PictureBox.TabIndex = 16;
            this.lka_PictureBox.TabStop = false;
            this.lka_PictureBox.WaitOnLoad = true;
            // 
            // punchRed_Button
            // 
            this.punchRed_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.punchRed_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.punchRed_Button.Location = new System.Drawing.Point(3, 535);
            this.punchRed_Button.Name = "punchRed_Button";
            this.punchRed_Button.Size = new System.Drawing.Size(448, 44);
            this.punchRed_Button.TabIndex = 12;
            this.punchRed_Button.Text = "Jodan/Chudan Punch";
            this.punchRed_Button.UseVisualStyleBackColor = true;
            this.punchRed_Button.Click += new System.EventHandler(this.punchRed_Button_Click);
            // 
            // chudanKick_Button
            // 
            this.chudanKick_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.chudanKick_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chudanKick_Button.Location = new System.Drawing.Point(3, 585);
            this.chudanKick_Button.Name = "chudanKick_Button";
            this.chudanKick_Button.Size = new System.Drawing.Size(448, 39);
            this.chudanKick_Button.TabIndex = 15;
            this.chudanKick_Button.Text = "Chudan Kick";
            this.chudanKick_Button.UseVisualStyleBackColor = true;
            this.chudanKick_Button.Click += new System.EventHandler(this.chudanKickRed_Button_Click);
            // 
            // jodanKickRed_Button
            // 
            this.jodanKickRed_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.jodanKickRed_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jodanKickRed_Button.Location = new System.Drawing.Point(3, 630);
            this.jodanKickRed_Button.Name = "jodanKickRed_Button";
            this.jodanKickRed_Button.Size = new System.Drawing.Size(448, 37);
            this.jodanKickRed_Button.TabIndex = 14;
            this.jodanKickRed_Button.Text = "Jodan Kick";
            this.jodanKickRed_Button.UseVisualStyleBackColor = true;
            this.jodanKickRed_Button.Click += new System.EventHandler(this.jodanKickRed_Button_Click);
            // 
            // sweepRed_Button
            // 
            this.sweepRed_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.sweepRed_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sweepRed_Button.Location = new System.Drawing.Point(3, 673);
            this.sweepRed_Button.Name = "sweepRed_Button";
            this.sweepRed_Button.Size = new System.Drawing.Size(448, 38);
            this.sweepRed_Button.TabIndex = 13;
            this.sweepRed_Button.Text = "Sweep";
            this.sweepRed_Button.UseVisualStyleBackColor = true;
            this.sweepRed_Button.Click += new System.EventHandler(this.jodanKickRed_Button_Click);
            // 
            // redScore_Label
            // 
            this.redScore_Label.AutoSize = true;
            this.redScore_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redScore_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redScore_Label.Location = new System.Drawing.Point(3, 167);
            this.redScore_Label.Name = "redScore_Label";
            this.redScore_Label.Size = new System.Drawing.Size(448, 244);
            this.redScore_Label.TabIndex = 19;
            this.redScore_Label.Text = "0";
            this.redScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.punchRed_Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chudanKick_Button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.jodanKickRed_Button, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.sweepRed_Button, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.redScore_Label, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 714);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 714);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lka_PictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startTimer_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pauseTimer_Button;
        private System.Windows.Forms.Button resetTime_Button;
        private System.Windows.Forms.TextBox inputTime_Textbox;
        private System.Windows.Forms.Button chudanKickBlue_Button;
        private System.Windows.Forms.Button jodanKickBlue_Button;
        private System.Windows.Forms.Button sweepBlue_Button;
        private System.Windows.Forms.Button punchBlue_Button;
        private System.Windows.Forms.PictureBox lka_PictureBox;
        private System.Windows.Forms.Label blueScore_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.Label minsLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Button punchRed_Button;
        private System.Windows.Forms.Button chudanKick_Button;
        private System.Windows.Forms.Button jodanKickRed_Button;
        private System.Windows.Forms.Button sweepRed_Button;
        private System.Windows.Forms.Label redScore_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

