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
        private System.Collections.Specialized.StringCollection blocked_websites = new System.Collections.Specialized.StringCollection();

        private bool next_previous_button_clicked = false;//using this to see if form is closed through the next button or the X button

        public Website_Textbox()
        {
            InitializeComponent();
        }

        private void website_textbox_previous_button_Click(object sender, EventArgs e)
        {

            blocked_websites.Clear();//clear the string collection so we get only the values in the list box

            foreach (string x in listBox1.Items)
            {
                blocked_websites.Add(x);
            }


            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_website_checkboxes();
            }

            next_previous_button_clicked = true;

            this.Close();

        }

        private void website_textbox_next_button_Click(object sender, EventArgs e)
        {
            //clear the blocked websites list so that we can take the values from the the listbox
            //as users can delete websites from checkbox here
            this.blocked_websites.Clear();

            foreach (string x in listBox1.Items)
            {
                blocked_websites.Add(x);
            }

            Properties.Settings.Default.blocked_websites = this.blocked_websites;
            Properties.Settings.Default.Save();


            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_program_textboxes();
            }

            next_previous_button_clicked = true;

            this.Close();
            
        }

        private void website_textbox_add_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add( textBox1.Text.ToLower() );//add the website to the listbox

            textBox1.Text = "";//reset the textbox
        }

        private void website_textbox_remove_button_Click(object sender, EventArgs e)
        {
           listBox1.Items.RemoveAt(listBox1.SelectedIndex);//get rid of the selected item
        }

        private void Website_Textbox_Load(object sender, EventArgs e)
        {
            //load the blocked_websites and put them into the list box

            this.blocked_websites = Properties.Settings.Default.blocked_websites;

            foreach (string x in Properties.Settings.Default.blocked_websites)
            {
                listBox1.Items.Add(x);
            }

        }

        private void Website_Textbox_FormClosing(object sender, FormClosingEventArgs e)
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
