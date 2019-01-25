namespace CTRL
{
    partial class Program_Textbox
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
            this.program_textbox_previous_button = new System.Windows.Forms.Button();
            this.program_textbox_next_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.program_textbox_add_button = new System.Windows.Forms.Button();
            this.program_textbox_remove_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // program_textbox_previous_button
            // 
            this.program_textbox_previous_button.Location = new System.Drawing.Point(316, 153);
            this.program_textbox_previous_button.Name = "program_textbox_previous_button";
            this.program_textbox_previous_button.Size = new System.Drawing.Size(75, 23);
            this.program_textbox_previous_button.TabIndex = 0;
            this.program_textbox_previous_button.Text = "Previous";
            this.program_textbox_previous_button.UseVisualStyleBackColor = true;
            this.program_textbox_previous_button.Click += new System.EventHandler(this.program_textbox_previous_button_Click);
            // 
            // program_textbox_next_button
            // 
            this.program_textbox_next_button.Location = new System.Drawing.Point(397, 153);
            this.program_textbox_next_button.Name = "program_textbox_next_button";
            this.program_textbox_next_button.Size = new System.Drawing.Size(75, 23);
            this.program_textbox_next_button.TabIndex = 1;
            this.program_textbox_next_button.Text = "Next";
            this.program_textbox_next_button.UseVisualStyleBackColor = true;
            this.program_textbox_next_button.Click += new System.EventHandler(this.program_textbox_next_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 160);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(237, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manually add programs to the list\r\nor click one and then remove to\r\nremove it";
            // 
            // program_textbox_add_button
            // 
            this.program_textbox_add_button.Location = new System.Drawing.Point(240, 93);
            this.program_textbox_add_button.Name = "program_textbox_add_button";
            this.program_textbox_add_button.Size = new System.Drawing.Size(56, 23);
            this.program_textbox_add_button.TabIndex = 4;
            this.program_textbox_add_button.Text = "Add";
            this.program_textbox_add_button.UseVisualStyleBackColor = true;
            this.program_textbox_add_button.Click += new System.EventHandler(this.program_textbox_add_button_Click);
            // 
            // program_textbox_remove_button
            // 
            this.program_textbox_remove_button.Location = new System.Drawing.Point(302, 93);
            this.program_textbox_remove_button.Name = "program_textbox_remove_button";
            this.program_textbox_remove_button.Size = new System.Drawing.Size(56, 23);
            this.program_textbox_remove_button.TabIndex = 5;
            this.program_textbox_remove_button.Text = "Remove";
            this.program_textbox_remove_button.UseVisualStyleBackColor = true;
            this.program_textbox_remove_button.Click += new System.EventHandler(this.program_textbox_remove_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Program_Textbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 188);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.program_textbox_remove_button);
            this.Controls.Add(this.program_textbox_add_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.program_textbox_next_button);
            this.Controls.Add(this.program_textbox_previous_button);
            this.Name = "Program_Textbox";
            this.Text = "Program_Textbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Program_Textbox_FormClosing);
            this.Load += new System.EventHandler(this.Program_Textbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button program_textbox_previous_button;
        private System.Windows.Forms.Button program_textbox_next_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button program_textbox_add_button;
        private System.Windows.Forms.Button program_textbox_remove_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}