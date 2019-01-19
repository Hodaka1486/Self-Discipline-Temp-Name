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
    public partial class Website_Textbox : Form
    {
        public Website_Textbox()
        {
            InitializeComponent();
        }

        private void website_textbox_previous_button_Click(object sender, EventArgs e)
        {

            Website_Checkbox website_Checkbox = new Website_Checkbox();
            website_Checkbox.Show();

            //need to load values

            this.Close();

        }

        private void website_textbox_next_button_Click(object sender, EventArgs e)
        {

            Program_Textbox program_Textbox = new Program_Textbox();
            program_Textbox.Show();

            //need to save the values

            this.Close();
            
        }
    }
}
