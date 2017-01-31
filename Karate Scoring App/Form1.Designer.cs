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
            this.startTime_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.stopTimer_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTime_Button
            // 
            this.startTime_Button.Location = new System.Drawing.Point(342, 63);
            this.startTime_Button.Name = "startTime_Button";
            this.startTime_Button.Size = new System.Drawing.Size(75, 23);
            this.startTime_Button.TabIndex = 0;
            this.startTime_Button.Text = "start";
            this.startTime_Button.UseVisualStyleBackColor = true;
            this.startTime_Button.Click += new System.EventHandler(this.startTimer_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(561, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            // 
            // stopTimer_Button
            // 
            this.stopTimer_Button.Location = new System.Drawing.Point(436, 63);
            this.stopTimer_Button.Name = "stopTimer_Button";
            this.stopTimer_Button.Size = new System.Drawing.Size(75, 23);
            this.stopTimer_Button.TabIndex = 2;
            this.stopTimer_Button.Text = "stop";
            this.stopTimer_Button.UseVisualStyleBackColor = true;
            this.stopTimer_Button.Click += new System.EventHandler(this.stopTimer_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 322);
            this.Controls.Add(this.stopTimer_Button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.startTime_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startTime_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button stopTimer_Button;
    }
}

