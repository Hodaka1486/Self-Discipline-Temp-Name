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
            this.test_button_1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reset_test_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pause_resume_button
            // 
            this.pause_resume_button.Location = new System.Drawing.Point(156, 47);
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
            this.timer_label.Location = new System.Drawing.Point(67, 50);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(71, 20);
            this.timer_label.TabIndex = 1;
            this.timer_label.Text = "00:00:00";
            // 
            // days_left_till_goal_label
            // 
            this.days_left_till_goal_label.AutoSize = true;
            this.days_left_till_goal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.days_left_till_goal_label.Location = new System.Drawing.Point(67, 95);
            this.days_left_till_goal_label.Name = "days_left_till_goal_label";
            this.days_left_till_goal_label.Size = new System.Drawing.Size(127, 20);
            this.days_left_till_goal_label.TabIndex = 4;
            this.days_left_till_goal_label.Text = "Days left to goal:";
            // 
            // days_until_goal_number
            // 
            this.days_until_goal_number.AutoSize = true;
            this.days_until_goal_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.days_until_goal_number.Location = new System.Drawing.Point(200, 95);
            this.days_until_goal_number.Name = "days_until_goal_number";
            this.days_until_goal_number.Size = new System.Drawing.Size(31, 20);
            this.days_until_goal_number.TabIndex = 5;
            this.days_until_goal_number.Text = "XX";
            // 
            // original_max_time_label
            // 
            this.original_max_time_label.AutoSize = true;
            this.original_max_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.original_max_time_label.Location = new System.Drawing.Point(67, 131);
            this.original_max_time_label.Name = "original_max_time_label";
            this.original_max_time_label.Size = new System.Drawing.Size(137, 20);
            this.original_max_time_label.TabIndex = 6;
            this.original_max_time_label.Text = "Original Max Time:";
            // 
            // current_max_time_label
            // 
            this.current_max_time_label.AutoSize = true;
            this.current_max_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.current_max_time_label.Location = new System.Drawing.Point(67, 166);
            this.current_max_time_label.Name = "current_max_time_label";
            this.current_max_time_label.Size = new System.Drawing.Size(137, 20);
            this.current_max_time_label.TabIndex = 7;
            this.current_max_time_label.Text = "Current Max Time:";
            // 
            // goal_max_time_label
            // 
            this.goal_max_time_label.AutoSize = true;
            this.goal_max_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goal_max_time_label.Location = new System.Drawing.Point(67, 198);
            this.goal_max_time_label.Name = "goal_max_time_label";
            this.goal_max_time_label.Size = new System.Drawing.Size(118, 20);
            this.goal_max_time_label.TabIndex = 8;
            this.goal_max_time_label.Text = "Goal Max Time:";
            // 
            // original_max_time_value
            // 
            this.original_max_time_value.AutoSize = true;
            this.original_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.original_max_time_value.Location = new System.Drawing.Point(200, 131);
            this.original_max_time_value.Name = "original_max_time_value";
            this.original_max_time_value.Size = new System.Drawing.Size(49, 20);
            this.original_max_time_value.TabIndex = 9;
            this.original_max_time_value.Text = "00:00";
            // 
            // current_max_time_value
            // 
            this.current_max_time_value.AutoSize = true;
            this.current_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.current_max_time_value.Location = new System.Drawing.Point(200, 166);
            this.current_max_time_value.Name = "current_max_time_value";
            this.current_max_time_value.Size = new System.Drawing.Size(49, 20);
            this.current_max_time_value.TabIndex = 10;
            this.current_max_time_value.Text = "00:00";
            // 
            // goal_max_time_value
            // 
            this.goal_max_time_value.AutoSize = true;
            this.goal_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goal_max_time_value.Location = new System.Drawing.Point(200, 198);
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
            // test_button_1
            // 
            this.test_button_1.Location = new System.Drawing.Point(377, 153);
            this.test_button_1.Name = "test_button_1";
            this.test_button_1.Size = new System.Drawing.Size(112, 23);
            this.test_button_1.TabIndex = 12;
            this.test_button_1.Text = "To Web Check";
            this.test_button_1.UseVisualStyleBackColor = true;
            this.test_button_1.Click += new System.EventHandler(this.test_button_1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "To Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "To Gather Time Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset_test_button
            // 
            this.reset_test_button.Location = new System.Drawing.Point(419, 46);
            this.reset_test_button.Name = "reset_test_button";
            this.reset_test_button.Size = new System.Drawing.Size(75, 23);
            this.reset_test_button.TabIndex = 15;
            this.reset_test_button.Text = "Reset";
            this.reset_test_button.UseVisualStyleBackColor = true;
            this.reset_test_button.Click += new System.EventHandler(this.reset_test_button_Click);
            // 
            // MainTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 269);
            this.Controls.Add(this.reset_test_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test_button_1);
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
            this.Name = "MainTimer";
            this.Text = "CTRL";
            this.Load += new System.EventHandler(this.MainTimer_Load);
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
        private System.Windows.Forms.Button test_button_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button reset_test_button;
    }
}

