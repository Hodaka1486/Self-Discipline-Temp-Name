using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool ValidHttpURL(string s, out Uri resultURI)
        {
            if (!Regex.IsMatch(s, @"^https?:\/\/", RegexOptions.IgnoreCase))
                s = "http://" + s;

            if (Uri.TryCreate(s, UriKind.Absolute, out resultURI))
                return (resultURI.Scheme == Uri.UriSchemeHttp ||
                        resultURI.Scheme == Uri.UriSchemeHttps);

            return false;
        }

        private void website_add_button_Click(object sender, EventArgs e)
        {
            Uri uriResult;

            if (ValidHttpURL(website_textbox.Text, out uriResult))//if not empty add the text
            {
                blocked_websites_listbox.Items.Add(website_textbox.Text.ToLower());//add the website to the listbox
                blocked_websites_listbox.Text = "";//reset the textbox
            }
            else
            {
                MessageBox.Show("Please enter a valid url.", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void website_remove_button_Click(object sender, EventArgs e)
        {
            if (blocked_websites_listbox.SelectedIndex != -1)
            {
                blocked_websites_listbox.Items.RemoveAt(blocked_websites_listbox.SelectedIndex);//get rid of the selected item
            }
        }

        private void program_add_button_Click(object sender, EventArgs e)
        {
            blocked_programs_listbox.Items.Add(program_textbox.Text.ToLower());//add the website to the listbox

            program_textbox.Text = "";//reset the textbox
        }

        private void program_remove_button_Click(object sender, EventArgs e)
        {
            if (blocked_programs_listbox.SelectedIndex != -1)
            {
                blocked_programs_listbox.Items.RemoveAt(blocked_programs_listbox.SelectedIndex);//get rid of the selected item
            }
        }

        private void settings_finished_button_Click(object sender, EventArgs e)
        {
            //cleraing the string collections just in case
            this.blocked_websites.Clear();
            this.blocked_programs.Clear();

            //message box asking if the user wants to make these changes
            DialogResult res = MessageBox.Show("Do you want to make these changes? They will not come into effect until tommorow.", "Confirmation", MessageBoxButtons.OKCancel);

            if(res == DialogResult.OK)
            {
                foreach (string x in blocked_websites_listbox.Items)
                {
                    blocked_websites.Add(x);
                }
                foreach (string x in blocked_programs_listbox.Items)
                {
                    blocked_programs.Add(x);
                }
                //save the values in the list box into tommorow_blocked_websites
                Properties.Settings.Default.tommorow_blocked_websites = blocked_websites;
                Properties.Settings.Default.tommorow_blocked_programs = blocked_programs;

                Properties.Settings.Default.Save();
            }

            //close the settings form
            this.Close();

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //-----------------------------------Checking if the block websites have been changed-----------------------------

            if (Properties.Settings.Default.blocked_websites == null)//making sure that we don't index a null value
            {
                Properties.Settings.Default.blocked_websites = this.blocked_websites;//setting it from NULL to empty, they are not the same
            }

            //tommorow blocked websites will be null unless the list of blocked websites has been changed today
            if (Properties.Settings.Default.tommorow_blocked_websites == null)
            {
                foreach (string x in Properties.Settings.Default.blocked_websites)//load the normal blocked websites
                {
                    blocked_websites_listbox.Items.Add(x);
                }
            }
            else//if the blocked websites have been modified load those and make the warning label visible
            {
                foreach (string x in Properties.Settings.Default.tommorow_blocked_websites)//load the modified blocked websites
                {
                    blocked_websites_listbox.Items.Add(x);
                }

                warning_label.Visible = true;//make the warning true
            }
            //-----------------------------------Checking if the block programs have been changed-----------------------------

            if (Properties.Settings.Default.blocked_programs == null)//making sure that we don't index a null value
            {
                Properties.Settings.Default.blocked_programs = this.blocked_programs;//setting it from NULL to empty, they are not the same
            }

            //tommorow blocked websites will be null unless the list of blocked websites has been changed today
            if (Properties.Settings.Default.tommorow_blocked_programs == null)
            {
                foreach (string x in Properties.Settings.Default.blocked_programs)//load the normal blocked websites
                {
                    blocked_programs_listbox.Items.Add(x);
                }
            }
            else//if the blocked websites have been modified load those and make the warning label visible
            {
                foreach (string x in Properties.Settings.Default.tommorow_blocked_programs)//load the modified blocked websites
                {
                    blocked_programs_listbox.Items.Add(x);
                }

                warning_label.Visible = true;//make the warning true
            }
        }

        private void website_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//makes enter equivalent to clicking the add button
            {
                website_add_button_Click(sender, e);
                //this stop the error ding sound form playing when hitting enter while selecting the textbox
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void program_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//makes enter equivalent to clicking the add button
            {
                program_add_button_Click(sender, e);
                //this stop the error ding sound form playing when hitting enter while selecting the textbox
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void blocked_websites_listbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) website_remove_button_Click(sender, e);//allow the use of the delete key to remove values from the listbox
        }

        private void blocked_programs_listbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) program_remove_button_Click(sender, e);//allow the use of the delete key to remove values from the listbox
        }

        //clicking outside a listbox/button/textbox unselects the listbox index
        private void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            blocked_programs_listbox.SelectedIndex = -1;
            blocked_websites_listbox.SelectedIndex = -1;
        }
    }
}
