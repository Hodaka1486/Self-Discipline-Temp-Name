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
        public Form main_timer_reference { get; set; }//reference to the parent form which will be MainTimer

        public Website_Textbox()
        {
            InitializeComponent();
        }

        private void website_textbox_previous_button_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_website_checkboxes();
            }

            //need to load values

            this.Close();

        }

        private void website_textbox_next_button_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_program_textboxes();
            }

            //need to save the values

            this.Close();
            
        }
    }
}
