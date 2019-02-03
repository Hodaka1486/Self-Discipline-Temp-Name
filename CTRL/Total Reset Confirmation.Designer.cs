namespace CTRL
{
    partial class Total_Reset_Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total_Reset_Confirmation));
            this.TR_accept_button = new System.Windows.Forms.Button();
            this.TR_decline_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TR_accept_button
            // 
            this.TR_accept_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.TR_accept_button.Enabled = false;
            this.TR_accept_button.Location = new System.Drawing.Point(227, 168);
            this.TR_accept_button.Name = "TR_accept_button";
            this.TR_accept_button.Size = new System.Drawing.Size(75, 23);
            this.TR_accept_button.TabIndex = 0;
            this.TR_accept_button.Text = "Confirm";
            this.TR_accept_button.UseVisualStyleBackColor = true;
            this.TR_accept_button.Click += new System.EventHandler(this.TR_accept_button_Click);
            // 
            // TR_decline_button
            // 
            this.TR_decline_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TR_decline_button.Location = new System.Drawing.Point(317, 168);
            this.TR_decline_button.Name = "TR_decline_button";
            this.TR_decline_button.Size = new System.Drawing.Size(75, 23);
            this.TR_decline_button.TabIndex = 1;
            this.TR_decline_button.Text = "Cancel";
            this.TR_decline_button.UseVisualStyleBackColor = true;
            this.TR_decline_button.Click += new System.EventHandler(this.TR_decline_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 154);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Total_Reset_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 208);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TR_decline_button);
            this.Controls.Add(this.TR_accept_button);
            this.Name = "Total_Reset_Confirmation";
            this.Text = "Total_Reset_Confirmation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Total_Reset_Confirmation_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TR_accept_button;
        private System.Windows.Forms.Button TR_decline_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}