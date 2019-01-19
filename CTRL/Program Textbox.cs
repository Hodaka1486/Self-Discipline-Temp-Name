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
    public partial class Program_Textbox : Form
    {
        public Program_Textbox()
        {
            InitializeComponent();
        }

        private void program_textbox_previous_button_Click(object sender, EventArgs e)
        {

            Program_Textbox program_Textbox = new Program_Textbox();

            program_Textbox.Show();

            this.Close();

        }

        private void program_textbox_next_button_Click(object sender, EventArgs e)
        {

            Confirmation confirmation = new Confirmation();

            confirmation.Show();

            this.Close();

        }
    }
}
