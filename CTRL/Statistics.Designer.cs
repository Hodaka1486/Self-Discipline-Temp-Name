namespace CTRL
{
    partial class Statistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.days_until_goal_number = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.original_max_time_value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.current_max_time_value = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.goal_max_time_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days Remaining:";
            // 
            // days_until_goal_number
            // 
            this.days_until_goal_number.AutoSize = true;
            this.days_until_goal_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.days_until_goal_number.Location = new System.Drawing.Point(137, 9);
            this.days_until_goal_number.Name = "days_until_goal_number";
            this.days_until_goal_number.Size = new System.Drawing.Size(31, 20);
            this.days_until_goal_number.TabIndex = 1;
            this.days_until_goal_number.Text = "XX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Original Max Time:";
            // 
            // original_max_time_value
            // 
            this.original_max_time_value.AutoSize = true;
            this.original_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.original_max_time_value.Location = new System.Drawing.Point(308, 9);
            this.original_max_time_value.Name = "original_max_time_value";
            this.original_max_time_value.Size = new System.Drawing.Size(49, 20);
            this.original_max_time_value.TabIndex = 3;
            this.original_max_time_value.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(363, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Today\'s Max Time:";
            // 
            // current_max_time_value
            // 
            this.current_max_time_value.AutoSize = true;
            this.current_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.current_max_time_value.Location = new System.Drawing.Point(497, 9);
            this.current_max_time_value.Name = "current_max_time_value";
            this.current_max_time_value.Size = new System.Drawing.Size(49, 20);
            this.current_max_time_value.TabIndex = 5;
            this.current_max_time_value.Text = "00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(552, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Goal Time:";
            // 
            // goal_max_time_value
            // 
            this.goal_max_time_value.AutoSize = true;
            this.goal_max_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goal_max_time_value.Location = new System.Drawing.Point(632, 9);
            this.goal_max_time_value.Name = "goal_max_time_value";
            this.goal_max_time_value.Size = new System.Drawing.Size(49, 20);
            this.goal_max_time_value.TabIndex = 7;
            this.goal_max_time_value.Text = "00:00";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 390);
            this.Controls.Add(this.goal_max_time_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.current_max_time_value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.original_max_time_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.days_until_goal_number);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label days_until_goal_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label original_max_time_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label current_max_time_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label goal_max_time_value;
    }
}