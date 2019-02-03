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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.total_days_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avg_daily_leisure_time_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.avg_daily_productive_time_label = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goal Days Remaining:";
            // 
            // days_until_goal_number
            // 
            this.days_until_goal_number.AutoSize = true;
            this.days_until_goal_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.days_until_goal_number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days_until_goal_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.days_until_goal_number.Location = new System.Drawing.Point(157, 0);
            this.days_until_goal_number.Name = "days_until_goal_number";
            this.days_until_goal_number.Size = new System.Drawing.Size(28, 21);
            this.days_until_goal_number.TabIndex = 1;
            this.days_until_goal_number.Text = "XX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(202, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Original Max Time:";
            // 
            // original_max_time_value
            // 
            this.original_max_time_value.AutoSize = true;
            this.original_max_time_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.original_max_time_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.original_max_time_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.original_max_time_value.Location = new System.Drawing.Point(337, 1);
            this.original_max_time_value.Name = "original_max_time_value";
            this.original_max_time_value.Size = new System.Drawing.Size(49, 21);
            this.original_max_time_value.TabIndex = 3;
            this.original_max_time_value.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(404, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Today\'s Max Time:";
            // 
            // current_max_time_value
            // 
            this.current_max_time_value.AutoSize = true;
            this.current_max_time_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.current_max_time_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_max_time_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.current_max_time_value.Location = new System.Drawing.Point(535, 1);
            this.current_max_time_value.Name = "current_max_time_value";
            this.current_max_time_value.Size = new System.Drawing.Size(49, 21);
            this.current_max_time_value.TabIndex = 5;
            this.current_max_time_value.Text = "00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.label7.Location = new System.Drawing.Point(603, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Goal Time:";
            // 
            // goal_max_time_value
            // 
            this.goal_max_time_value.AutoSize = true;
            this.goal_max_time_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.goal_max_time_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goal_max_time_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.goal_max_time_value.Location = new System.Drawing.Point(682, 1);
            this.goal_max_time_value.Name = "goal_max_time_value";
            this.goal_max_time_value.Size = new System.Drawing.Size(49, 21);
            this.goal_max_time_value.TabIndex = 7;
            this.goal_max_time_value.Text = "00:00";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.listView1.Location = new System.Drawing.Point(78, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(225, 325);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Days Used:";
            // 
            // total_days_label
            // 
            this.total_days_label.AutoSize = true;
            this.total_days_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.total_days_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_days_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.total_days_label.Location = new System.Drawing.Point(121, 31);
            this.total_days_label.Name = "total_days_label";
            this.total_days_label.Size = new System.Drawing.Size(37, 21);
            this.total_days_label.TabIndex = 10;
            this.total_days_label.Text = "XXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.label6.Location = new System.Drawing.Point(170, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Average Daily Leisure Time:";
            // 
            // avg_daily_leisure_time_label
            // 
            this.avg_daily_leisure_time_label.AutoSize = true;
            this.avg_daily_leisure_time_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.avg_daily_leisure_time_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_daily_leisure_time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.avg_daily_leisure_time_label.Location = new System.Drawing.Point(367, 31);
            this.avg_daily_leisure_time_label.Name = "avg_daily_leisure_time_label";
            this.avg_daily_leisure_time_label.Size = new System.Drawing.Size(70, 21);
            this.avg_daily_leisure_time_label.TabIndex = 12;
            this.avg_daily_leisure_time_label.Text = "00:00:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.label9.Location = new System.Drawing.Point(443, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Average Daily Productive Time:";
            // 
            // avg_daily_productive_time_label
            // 
            this.avg_daily_productive_time_label.AutoSize = true;
            this.avg_daily_productive_time_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.avg_daily_productive_time_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_daily_productive_time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.avg_daily_productive_time_label.Location = new System.Drawing.Point(662, 30);
            this.avg_daily_productive_time_label.Name = "avg_daily_productive_time_label";
            this.avg_daily_productive_time_label.Size = new System.Drawing.Size(70, 21);
            this.avg_daily_productive_time_label.TabIndex = 14;
            this.avg_daily_productive_time_label.Text = "00:00:00";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.listView2.Location = new System.Drawing.Point(443, 75);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(225, 325);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.avg_daily_productive_time_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.avg_daily_leisure_time_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total_days_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.goal_max_time_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.current_max_time_value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.original_max_time_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.days_until_goal_number);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total_days_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label avg_daily_leisure_time_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label avg_daily_productive_time_label;
        private System.Windows.Forms.ListView listView2;
    }
}