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
    public partial class Website_Checkbox : Form
    {

        public Website_Checkbox()
        {
            InitializeComponent();
        }

        private System.Collections.Specialized.StringCollection blocked_websites = new System.Collections.Specialized.StringCollection();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//YouTube
        {
            if (checkBox1.Checked)//go from not checked to checked
            {
                blocked_websites.Add("youtube");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("youtube");
            }            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//Facebook
        {
            if (checkBox2.Checked)//go from not checked to checked
            {
                blocked_websites.Add("facebook");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("facebook");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)//Reddit
        {
            if (checkBox3.Checked)//go from not checked to checked
            {
                blocked_websites.Add("reddit");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("reddit");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)//Amazon
        {
            if (checkBox4.Checked)//go from not checked to checked
            {
                blocked_websites.Add("amazon");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("amazon");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)//Twitter
        {
            if (checkBox5.Checked)//go from not checked to checked
            {
                blocked_websites.Add("twitter");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("twitter");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)//Instagram
        {
            if (checkBox6.Checked)//go from not checked to checked
            {
                blocked_websites.Add("instagram");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("instagram");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)//Netflix
        {
            if (checkBox7.Checked)//go from not checked to checked
            {
                blocked_websites.Add("netflix");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("netflix");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)//eBay
        {
            if (checkBox8.Checked)//go from not checked to checked
            {
                blocked_websites.Add("ebay");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("ebay");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)//WhatsApp
        {
            if (checkBox9.Checked)//go from not checked to checked
            {
                blocked_websites.Add("whatsapp");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("whatsapp");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)//Spotify
        {
            if (checkBox10.Checked)//go from not checked to checked
            {
                blocked_websites.Add("spotify");
            }
            else//going from checked to not checked
            {
                blocked_websites.Remove("spotify");
            }
        }

        private void to_website_textboxes_button_Click(object sender, EventArgs e)//used to go to the next form
        {
            //save the string collection of all the websites
            Properties.Settings.Default.blocked_websites = blocked_websites;
            Properties.Settings.Default.Save();

            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_website_textboxes();
            }        

            this.Close();

        }

        private void to_gather_time_data_button_Click(object sender, EventArgs e)//button to go back to the gather time data form
        {
            //save the string collection of all the websites
            Properties.Settings.Default.blocked_websites = blocked_websites;
            Properties.Settings.Default.Save();

            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_gather_time_data();
            }

            this.Close();

        }

        private void Website_Checkbox_Load(object sender, EventArgs e)
        {
            //when loading this page check if any of the webpages on this page are already saved
            //if they are then you need to start the checkboxes in the correct checked state
            if (Properties.Settings.Default.blocked_websites.Contains("youtube"))   { checkBox1.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("facebook"))  { checkBox2.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("reddit"))    { checkBox3.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("amazon"))    { checkBox4.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("twitter"))   { checkBox5.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("instagram")) { checkBox6.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("netflix"))   { checkBox7.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("ebay"))      { checkBox8.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("whatsapp"))  { checkBox9.Checked  = true; }
            if (Properties.Settings.Default.blocked_websites.Contains("spotify"))   { checkBox10.Checked = true; }

            //this loads the value so that websites added with textbox stay then when you go back
            //if you do something like checkbox->textbox->checkbox->textbox
            blocked_websites = Properties.Settings.Default.blocked_websites;
        }
    }
}
