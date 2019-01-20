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
        public Form main_timer_reference { get; set; }//reference to the parent form which will be MainTimer

        public Program_Textbox()
        {
            InitializeComponent();
        }

        private void program_textbox_previous_button_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_website_textboxes();
            }

            this.Close();

        }

        private void program_textbox_next_button_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_confirmation();
            }

            this.Close();

        }

    }
}
