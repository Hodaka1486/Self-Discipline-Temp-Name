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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reset_test_button = new System.Windows.Forms.Button();
            this.testbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stopwatch_label = new System.Windows.Forms.Label();
            this.productivity_stopwatch_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.double_pause_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pause_resume_button
            // 
            this.pause_resume_button.Location = new System.Drawing.Point(69, 134);
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
            this.timer_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.timer_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.timer_label.Location = new System.Drawing.Point(31, 63);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(192, 53);
            this.timer_label.TabIndex = 1;
            this.timer_label.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reset_test_button
            // 
            this.reset_test_button.Location = new System.Drawing.Point(174, 236);
            this.reset_test_button.Name = "reset_test_button";
            this.reset_test_button.Size = new System.Drawing.Size(75, 23);
            this.reset_test_button.TabIndex = 15;
            this.reset_test_button.Text = "Reset";
            this.reset_test_button.UseVisualStyleBackColor = true;
            this.reset_test_button.Click += new System.EventHandler(this.reset_test_button_Click);
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(93, 236);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(75, 23);
            this.testbutton.TabIndex = 16;
            this.testbutton.Text = "daily reset";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "lockdown";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statToolStripMenuItem
            // 
            this.statToolStripMenuItem.Name = "statToolStripMenuItem";
            this.statToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statToolStripMenuItem.Text = "Statistics";
            this.statToolStripMenuItem.Click += new System.EventHandler(this.statToolStripMenuItem_Click);
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
            this.stopwatch_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stopwatch_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stopwatch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.stopwatch_label.Location = new System.Drawing.Point(282, 63);
            this.stopwatch_label.Name = "stopwatch_label";
            this.stopwatch_label.Size = new System.Drawing.Size(192, 53);
            this.stopwatch_label.TabIndex = 19;
            this.stopwatch_label.Text = "00:00:00";
            // 
            // productivity_stopwatch_button
            // 
            this.productivity_stopwatch_button.Location = new System.Drawing.Point(321, 134);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(285, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Time Productive";
            // 
            // double_pause_button
            // 
            this.double_pause_button.BackColor = System.Drawing.Color.White;
            this.double_pause_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("double_pause_button.BackgroundImage")));
            this.double_pause_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.double_pause_button.Location = new System.Drawing.Point(484, 237);
            this.double_pause_button.Name = "double_pause_button";
            this.double_pause_button.Size = new System.Drawing.Size(20, 20);
            this.double_pause_button.TabIndex = 22;
            this.double_pause_button.UseVisualStyleBackColor = false;
            this.double_pause_button.Click += new System.EventHandler(this.double_pause_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Time Remaining";
            // 
            // MainTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(516, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.double_pause_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productivity_stopwatch_button);
            this.Controls.Add(this.stopwatch_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.reset_test_button);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.pause_resume_button);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainTimer";
            this.Text = "CTRL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainTimer_FormClosed);
            this.Load += new System.EventHandler(this.MainTimer_Load);
            this.Shown += new System.EventHandler(this.MainTimer_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainTimer_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pause_resume_button;
        private System.Windows.Forms.Label timer_label;
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
        private System.Windows.Forms.ToolStripMenuItem statToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

