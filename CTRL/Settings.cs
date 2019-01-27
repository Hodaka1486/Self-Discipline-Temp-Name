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
    public partial class Settings : Form
    {
        private System.Collections.Specialized.StringCollection blocked_websites = new System.Collections.Specialized.StringCollection();

        private System.Collections.Specialized.StringCollection blocked_programs = new System.Collections.Specialized.StringCollection();

        public Settings()
        {
            InitializeComponent();
        }

        private void website_add_button_Click(object sender, EventArgs e)
        {
            blocked_websites_listbox.Items.Add(website_textbox.Text.ToLower());//add the website to the listbox

            website_textbox.Text = "";//reset the textbox
        }

        private void website_remove_button_Click(object sender, EventArgs e)
        {
            blocked_websites_listbox.Items.RemoveAt(blocked_websites_listbox.SelectedIndex);//get rid of the selected item
        }

        private void program_add_button_Click(object sender, EventArgs e)
        {
            blocked_programs_listbox.Items.Add(program_textbox.Text.ToLower());//add the website to the listbox

            program_textbox.Text = "";//reset the textbox
        }

        private void program_remove_button_Click(object sender, EventArgs e)
        {
            blocked_programs_listbox.Items.RemoveAt(blocked_programs_listbox.SelectedIndex);//get rid of the selected item
        }

        private void settings_finished_button_Click(object sender, EventArgs e)
        {
            //need to figure out a way to only update it on dailyreset, not for the current day
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.blocked_programs == null)
            {
                Properties.Settings.Default.blocked_websites = this.blocked_websites;//setting it from NULL to empty, they are not the same
            }

            if (Properties.Settings.Default.blocked_programs == null)
            {
                Properties.Settings.Default.blocked_programs = this.blocked_programs;//setting it from NULL to empty, they are not the same
            }

            foreach (string x in Properties.Settings.Default.blocked_websites)
            {
                blocked_websites_listbox.Items.Add(x);
            }

            foreach (string x in Properties.Settings.Default.blocked_programs)
            {
                blocked_programs_listbox.Items.Add(x);
            }

        }
    }
}
