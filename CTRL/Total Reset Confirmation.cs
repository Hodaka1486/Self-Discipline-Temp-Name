using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTRL
{
    public partial class Total_Reset_Confirmation : Form
    {
        public Total_Reset_Confirmation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if((textBox1.Text.ToUpper()) == "RESET") TR_accept_button.Enabled = true;//the user has entered RESET enable the confirm button
        }

        private DialogResult res;

        private void TR_accept_button_Click(object sender, EventArgs e)
        {
            res = DialogResult.OK;
            this.Close();
        }

        private void TR_decline_button_Click(object sender, EventArgs e)
        {
            res = DialogResult.Cancel;
            this.Close();
        }

        private void Total_Reset_Confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
