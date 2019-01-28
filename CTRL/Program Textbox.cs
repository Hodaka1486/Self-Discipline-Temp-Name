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
        private System.Collections.Specialized.StringCollection blocked_programs = new System.Collections.Specialized.StringCollection();

        private bool next_previous_button_clicked = false;//using this to see if form is closed through the next button or the X button

        public Program_Textbox()
        {
            InitializeComponent();
        }

        private void program_textbox_add_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.ToLower());//add the website to the listbox

            textBox1.Text = "";//reset the textbox
        }

        private void program_textbox_remove_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);//get rid of the selected item
        }

        private void program_textbox_previous_button_Click(object sender, EventArgs e)
        {
            blocked_programs.Clear();//clear the string collection so we get only the values in the list box


            foreach (string x in listBox1.Items)
            {
                blocked_programs.Add(x);
            }

            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_website_textboxes();
            }

            next_previous_button_clicked = true;

            this.Close();

        }

        private void program_textbox_next_button_Click(object sender, EventArgs e)
        {

            this.blocked_programs.Clear();
            

            foreach (string x in listBox1.Items)
            {
                blocked_programs.Add(x);
            }

            Properties.Settings.Default.blocked_programs = this.blocked_programs;
            Properties.Settings.Default.Save();


            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_confirmation();
            }

            next_previous_button_clicked = true;

            this.Close();

        }

        private void Program_Textbox_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.blocked_programs == null)
            {
                Properties.Settings.Default.blocked_programs = this.blocked_programs;//setting it from NULL to empty, they are not the same
            }

            //load the blocked_websites and put them into the list box        
            this.blocked_programs = Properties.Settings.Default.blocked_programs;

            if (Properties.Settings.Default.blocked_programs != null)
            {
                foreach (string x in Properties.Settings.Default.blocked_programs)
                {
                    listBox1.Items.Add(x);
                }
            }
        }

        private void Program_Textbox_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (next_previous_button_clicked)//if closing because of the next/previous buttons
            {
                //do nothing
            }
            else//closing because of the x button
            {
                Application.Exit();
            }

        }
    }
}
