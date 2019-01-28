namespace CTRL
{
    partial class Settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.website_add_button = new System.Windows.Forms.Button();
            this.website_remove_button = new System.Windows.Forms.Button();
            this.website_textbox = new System.Windows.Forms.TextBox();
            this.blocked_programs_listbox = new System.Windows.Forms.ListBox();
            this.program_add_button = new System.Windows.Forms.Button();
            this.program_remove_button = new System.Windows.Forms.Button();
            this.blocked_websites_listbox = new System.Windows.Forms.ListBox();
            this.program_textbox = new System.Windows.Forms.TextBox();
            this.settings_finished_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blocked Websites";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Blocked Programs";
            // 
            // website_add_button
            // 
            this.website_add_button.Location = new System.Drawing.Point(127, 257);
            this.website_add_button.Name = "website_add_button";
            this.website_add_button.Size = new System.Drawing.Size(55, 23);
            this.website_add_button.TabIndex = 4;
            this.website_add_button.Text = "Add";
            this.website_add_button.UseVisualStyleBackColor = true;
            this.website_add_button.Click += new System.EventHandler(this.website_add_button_Click);
            // 
            // website_remove_button
            // 
            this.website_remove_button.Location = new System.Drawing.Point(188, 257);
            this.website_remove_button.Name = "website_remove_button";
            this.website_remove_button.Size = new System.Drawing.Size(55, 23);
            this.website_remove_button.TabIndex = 5;
            this.website_remove_button.Text = "Remove";
            this.website_remove_button.UseVisualStyleBackColor = true;
            this.website_remove_button.Click += new System.EventHandler(this.website_remove_button_Click);
            // 
            // website_textbox
            // 
            this.website_textbox.Location = new System.Drawing.Point(15, 259);
            this.website_textbox.Name = "website_textbox";
            this.website_textbox.Size = new System.Drawing.Size(106, 20);
            this.website_textbox.TabIndex = 6;
            // 
            // blocked_programs_listbox
            // 
            this.blocked_programs_listbox.FormattingEnabled = true;
            this.blocked_programs_listbox.Location = new System.Drawing.Point(282, 41);
            this.blocked_programs_listbox.Name = "blocked_programs_listbox";
            this.blocked_programs_listbox.Size = new System.Drawing.Size(228, 212);
            this.blocked_programs_listbox.TabIndex = 8;
            // 
            // program_add_button
            // 
            this.program_add_button.Location = new System.Drawing.Point(394, 257);
            this.program_add_button.Name = "program_add_button";
            this.program_add_button.Size = new System.Drawing.Size(55, 23);
            this.program_add_button.TabIndex = 9;
            this.program_add_button.Text = "Add";
            this.program_add_button.UseVisualStyleBackColor = true;
            this.program_add_button.Click += new System.EventHandler(this.program_add_button_Click);
            // 
            // program_remove_button
            // 
            this.program_remove_button.Location = new System.Drawing.Point(455, 257);
            this.program_remove_button.Name = "program_remove_button";
            this.program_remove_button.Size = new System.Drawing.Size(55, 23);
            this.program_remove_button.TabIndex = 10;
            this.program_remove_button.Text = "Remove";
            this.program_remove_button.UseVisualStyleBackColor = true;
            this.program_remove_button.Click += new System.EventHandler(this.program_remove_button_Click);
            // 
            // blocked_websites_listbox
            // 
            this.blocked_websites_listbox.FormattingEnabled = true;
            this.blocked_websites_listbox.Location = new System.Drawing.Point(15, 41);
            this.blocked_websites_listbox.Name = "blocked_websites_listbox";
            this.blocked_websites_listbox.Size = new System.Drawing.Size(228, 212);
            this.blocked_websites_listbox.TabIndex = 11;
            // 
            // program_textbox
            // 
            this.program_textbox.Location = new System.Drawing.Point(282, 259);
            this.program_textbox.Name = "program_textbox";
            this.program_textbox.Size = new System.Drawing.Size(106, 20);
            this.program_textbox.TabIndex = 12;
            // 
            // settings_finished_button
            // 
            this.settings_finished_button.Location = new System.Drawing.Point(437, 289);
            this.settings_finished_button.Name = "settings_finished_button";
            this.settings_finished_button.Size = new System.Drawing.Size(75, 23);
            this.settings_finished_button.TabIndex = 13;
            this.settings_finished_button.Text = "Done";
            this.settings_finished_button.UseVisualStyleBackColor = true;
            this.settings_finished_button.Click += new System.EventHandler(this.settings_finished_button_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 324);
            this.Controls.Add(this.settings_finished_button);
            this.Controls.Add(this.program_textbox);
            this.Controls.Add(this.blocked_websites_listbox);
            this.Controls.Add(this.program_remove_button);
            this.Controls.Add(this.program_add_button);
            this.Controls.Add(this.blocked_programs_listbox);
            this.Controls.Add(this.website_textbox);
            this.Controls.Add(this.website_remove_button);
            this.Controls.Add(this.website_add_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Settings";
            this.Text = "CTRL";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button website_add_button;
        private System.Windows.Forms.Button website_remove_button;
        private System.Windows.Forms.TextBox website_textbox;
        private System.Windows.Forms.ListBox blocked_programs_listbox;
        private System.Windows.Forms.Button program_add_button;
        private System.Windows.Forms.Button program_remove_button;
        private System.Windows.Forms.ListBox blocked_websites_listbox;
        private System.Windows.Forms.TextBox program_textbox;
        private System.Windows.Forms.Button settings_finished_button;
    }
}