namespace CTRL
{
    partial class Website_Textbox
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
            this.website_textbox_previous_button = new System.Windows.Forms.Button();
            this.website_textbox_next_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.website_textbox_add_button = new System.Windows.Forms.Button();
            this.website_textbox_remove_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // website_textbox_previous_button
            // 
            this.website_textbox_previous_button.Location = new System.Drawing.Point(309, 150);
            this.website_textbox_previous_button.Name = "website_textbox_previous_button";
            this.website_textbox_previous_button.Size = new System.Drawing.Size(75, 23);
            this.website_textbox_previous_button.TabIndex = 0;
            this.website_textbox_previous_button.Text = "Previous";
            this.website_textbox_previous_button.UseVisualStyleBackColor = true;
            this.website_textbox_previous_button.Click += new System.EventHandler(this.website_textbox_previous_button_Click);
            // 
            // website_textbox_next_button
            // 
            this.website_textbox_next_button.Location = new System.Drawing.Point(390, 150);
            this.website_textbox_next_button.Name = "website_textbox_next_button";
            this.website_textbox_next_button.Size = new System.Drawing.Size(75, 23);
            this.website_textbox_next_button.TabIndex = 1;
            this.website_textbox_next_button.Text = "Next";
            this.website_textbox_next_button.UseVisualStyleBackColor = true;
            this.website_textbox_next_button.Click += new System.EventHandler(this.website_textbox_next_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 160);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 3;
            // 
            // website_textbox_add_button
            // 
            this.website_textbox_add_button.Location = new System.Drawing.Point(236, 98);
            this.website_textbox_add_button.Name = "website_textbox_add_button";
            this.website_textbox_add_button.Size = new System.Drawing.Size(56, 23);
            this.website_textbox_add_button.TabIndex = 4;
            this.website_textbox_add_button.Text = "Add";
            this.website_textbox_add_button.UseVisualStyleBackColor = true;
            this.website_textbox_add_button.Click += new System.EventHandler(this.website_textbox_add_button_Click);
            // 
            // website_textbox_remove_button
            // 
            this.website_textbox_remove_button.Location = new System.Drawing.Point(298, 98);
            this.website_textbox_remove_button.Name = "website_textbox_remove_button";
            this.website_textbox_remove_button.Size = new System.Drawing.Size(56, 23);
            this.website_textbox_remove_button.TabIndex = 5;
            this.website_textbox_remove_button.Text = "Remove";
            this.website_textbox_remove_button.UseVisualStyleBackColor = true;
            this.website_textbox_remove_button.Click += new System.EventHandler(this.website_textbox_remove_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(236, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manually add websites to the list\r\nor click one and then remove to\r\nremove it";
            // 
            // Website_Textbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.website_textbox_remove_button);
            this.Controls.Add(this.website_textbox_add_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.website_textbox_next_button);
            this.Controls.Add(this.website_textbox_previous_button);
            this.Name = "Website_Textbox";
            this.Text = "Website_Textbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Website_Textbox_FormClosing);
            this.Load += new System.EventHandler(this.Website_Textbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button website_textbox_previous_button;
        private System.Windows.Forms.Button website_textbox_next_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button website_textbox_add_button;
        private System.Windows.Forms.Button website_textbox_remove_button;
        private System.Windows.Forms.Label label1;
    }
}