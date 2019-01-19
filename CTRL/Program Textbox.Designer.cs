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
            this.SuspendLayout();
            // 
            // program_textbox_previous_button
            // 
            this.program_textbox_previous_button.Location = new System.Drawing.Point(77, 226);
            this.program_textbox_previous_button.Name = "program_textbox_previous_button";
            this.program_textbox_previous_button.Size = new System.Drawing.Size(75, 23);
            this.program_textbox_previous_button.TabIndex = 0;
            this.program_textbox_previous_button.Text = "Previous";
            this.program_textbox_previous_button.UseVisualStyleBackColor = true;
            this.program_textbox_previous_button.Click += new System.EventHandler(this.program_textbox_previous_button_Click);
            // 
            // program_textbox_next_button
            // 
            this.program_textbox_next_button.Location = new System.Drawing.Point(177, 226);
            this.program_textbox_next_button.Name = "program_textbox_next_button";
            this.program_textbox_next_button.Size = new System.Drawing.Size(75, 23);
            this.program_textbox_next_button.TabIndex = 1;
            this.program_textbox_next_button.Text = "Next";
            this.program_textbox_next_button.UseVisualStyleBackColor = true;
            this.program_textbox_next_button.Click += new System.EventHandler(this.program_textbox_next_button_Click);
            // 
            // Program_Textbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.program_textbox_next_button);
            this.Controls.Add(this.program_textbox_previous_button);
            this.Name = "Program_Textbox";
            this.Text = "Program_Textbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button program_textbox_previous_button;
        private System.Windows.Forms.Button program_textbox_next_button;
    }
}