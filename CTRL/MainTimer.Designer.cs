namespace CTRL
{
    partial class MainTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTimer));
            this.pause_resume_button = new System.Windows.Forms.Button();
            this.timer_label = new System.Windows.Forms.Label();
            this.days_left_till_goal_label = new System.Windows.Forms.Label();
            this.days_until_goal_number = new System.Windows.Forms.Label();
            this.original_max_time_label = new System.Windows.Forms.Label();
            this.current_max_time_label = new System.Windows.Forms.Label();
            this.goal_max_time_label = new System.Windows.Forms.Label();
            this.original_max_time_value = new System.Windows.Forms.Label();
            this.current_max_time_value = new System.Windows.Forms.Label();
            this.goal_max_time_value = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reset_test_button = new System.Windows.Forms.Button();
            this.testbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stopwatch_label = new System.Windows.Forms.Label();
            this.productivity_stopwatch_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.double_pause_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pause_resume_button
            // 
            this.pause_resume_button.Location = new System.Drawing.Point(144, 60);
            this.pause_resume_button.Name = "pause_resume_button";
            this.pause_resume_button.Size = new System.Drawing.Size(109, 23);
            this.pause_resume_button.TabIndex = 0;
            this.pause_resume_button.Text = "Start";
            this.pause_resume_button.UseVisualStyleBackColor = true;
            this.pause_resume_button.Click += new System.EventHandler(this.pause_resume_button_Click);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.Location = new System.Drawing.Point(67, 60);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(71, 20);
            this.timer_label.TabIndex = 1;
            this.timer_label.Text = "00:00:00";
            // 
            // days_left_till_goal_label
            // 
            this.days_left_till_goal_label.AutoSize = true;
            this.days_left_till_goal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.days_left_till_goal_label.Location = new System.Drawing.Point(67, 105);
            this.days_left_till_goal_label.Name = "days_left_till_goal_label";
            this.days_left_till_goal_label.Size = new System.Drawing.Size(127, 20);
            this.days_left_till_goal_label.TabIndex = 4;
            this.days_left_till_goal_label.Text = "Days left to goal:";
            // 
            // days_until_goal_number
            // 
            this.days_until_goal_number.AutoSize = true;
            this.days_until_goal_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.days_until_goal_number.Location = new System.Drawing.Point(200, 105);
            this.days_until_goal_number.Name = "days_until_goal_number";
            this.days_until_goal_number.Size = new System.Drawing.Size(31, 20);
            this.days_until_goal_number.TabIndex = 5;
            this.days_until_goal_number.Text = "XX";
            // 
            // original_max_time_label
            // 
            this.original_max_time_label.AutoSize = true;
            this.original_max_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.original_max_time_label.Location = new System.Drawing.Point(67, 141);
            this.original_max_time_label.Name = "original_max_time_label";
            this.original_max_time_label.Size = new System.Drawing.Size(137, 20);
            this.original_max_time_label.TabIndex = 6;
            this.original_max_time_label.Text = "Original Max Time:";
            // 
            // current_max_time_label
            // 
            this.current_max_time_label.AutoSize = true;
            this.current_max_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.current_max_time_label.Location = new System.Drawing.Point(67, 176);
            this.current_max_time_label.Name = "current_max_time_label";
            this.current_max_time_label.Size = new System.Drawing.Size(137, 20);
            this.current_max_time_label.TabIndex = 7;
            this.current_max_time_label.Text = "Current Max Time:";
            // 
            // goal_max_time_label
            // 
            this.goal_max_time_label.AutoSize = true;
            this.goal_max_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goal_max_time_label.Location = new System.Drawing.Point(67, 208);
            this.goal_max_time_label.Name = "goal_max_time_label";
            this.goal_max_time_label.Size = new System.Drawing.Size(118, 20);
            this.goal_max_time_label.TabIndex = 8;
            this.goal_max_time_label.Text = "Goal Max Time:";
            // 
            // original_max_time_value
            // 
            this.original_max_time_value.AutoSize = true;
            this.original_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.original_max_time_value.Location = new System.Drawing.Point(200, 141);
            this.original_max_time_value.Name = "original_max_time_value";
            this.original_max_time_value.Size = new System.Drawing.Size(49, 20);
            this.original_max_time_value.TabIndex = 9;
            this.original_max_time_value.Text = "00:00";
            // 
            // current_max_time_value
            // 
            this.current_max_time_value.AutoSize = true;
            this.current_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.current_max_time_value.Location = new System.Drawing.Point(200, 176);
            this.current_max_time_value.Name = "current_max_time_value";
            this.current_max_time_value.Size = new System.Drawing.Size(49, 20);
            this.current_max_time_value.TabIndex = 10;
            this.current_max_time_value.Text = "00:00";
            // 
            // goal_max_time_value
            // 
            this.goal_max_time_value.AutoSize = true;
            this.goal_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goal_max_time_value.Location = new System.Drawing.Point(200, 208);
            this.goal_max_time_value.Name = "goal_max_time_value";
            this.goal_max_time_value.Size = new System.Drawing.Size(49, 20);
            this.goal_max_time_value.TabIndex = 11;
            this.goal_max_time_value.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reset_test_button
            // 
            this.reset_test_button.Location = new System.Drawing.Point(276, 202);
            this.reset_test_button.Name = "reset_test_button";
            this.reset_test_button.Size = new System.Drawing.Size(75, 23);
            this.reset_test_button.TabIndex = 15;
            this.reset_test_button.Text = "Reset";
            this.reset_test_button.UseVisualStyleBackColor = true;
            this.reset_test_button.Click += new System.EventHandler(this.reset_test_button_Click);
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(276, 173);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(75, 23);
            this.testbutton.TabIndex = 16;
            this.testbutton.Text = "daily reset";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "lockdown";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // stopwatch_label
            // 
            this.stopwatch_label.AutoSize = true;
            this.stopwatch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stopwatch_label.Location = new System.Drawing.Point(293, 60);
            this.stopwatch_label.Name = "stopwatch_label";
            this.stopwatch_label.Size = new System.Drawing.Size(71, 20);
            this.stopwatch_label.TabIndex = 19;
            this.stopwatch_label.Text = "00:00:00";
            // 
            // productivity_stopwatch_button
            // 
            this.productivity_stopwatch_button.Location = new System.Drawing.Point(370, 60);
            this.productivity_stopwatch_button.Name = "productivity_stopwatch_button";
            this.productivity_stopwatch_button.Size = new System.Drawing.Size(106, 23);
            this.productivity_stopwatch_button.TabIndex = 20;
            this.productivity_stopwatch_button.Text = "Start";
            this.productivity_stopwatch_button.UseVisualStyleBackColor = true;
            this.productivity_stopwatch_button.Click += new System.EventHandler(this.productivity_stopwatch_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(293, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Productivity Stopwatch";
            // 
            // double_pause_button
            // 
            this.double_pause_button.BackColor = System.Drawing.Color.White;
            this.double_pause_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("double_pause_button.BackgroundImage")));
            this.double_pause_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.double_pause_button.Location = new System.Drawing.Point(463, 221);
            this.double_pause_button.Name = "double_pause_button";
            this.double_pause_button.Size = new System.Drawing.Size(41, 36);
            this.double_pause_button.TabIndex = 22;
            this.double_pause_button.UseVisualStyleBackColor = false;
            this.double_pause_button.Click += new System.EventHandler(this.double_pause_button_Click);
            // 
            // MainTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 269);
            this.Controls.Add(this.double_pause_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productivity_stopwatch_button);
            this.Controls.Add(this.stopwatch_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.reset_test_button);
            this.Controls.Add(this.goal_max_time_value);
            this.Controls.Add(this.current_max_time_value);
            this.Controls.Add(this.original_max_time_value);
            this.Controls.Add(this.goal_max_time_label);
            this.Controls.Add(this.current_max_time_label);
            this.Controls.Add(this.original_max_time_label);
            this.Controls.Add(this.days_until_goal_number);
            this.Controls.Add(this.days_left_till_goal_label);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.pause_resume_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainTimer";
            this.Text = "CTRL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainTimer_FormClosed);
            this.Load += new System.EventHandler(this.MainTimer_Load);
            this.Shown += new System.EventHandler(this.MainTimer_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pause_resume_button;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label days_left_till_goal_label;
        private System.Windows.Forms.Label days_until_goal_number;
        private System.Windows.Forms.Label original_max_time_label;
        private System.Windows.Forms.Label current_max_time_label;
        private System.Windows.Forms.Label goal_max_time_label;
        private System.Windows.Forms.Label original_max_time_value;
        private System.Windows.Forms.Label current_max_time_value;
        private System.Windows.Forms.Label goal_max_time_value;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reset_test_button;
        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label stopwatch_label;
        private System.Windows.Forms.Button productivity_stopwatch_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button double_pause_button;
    }
}

