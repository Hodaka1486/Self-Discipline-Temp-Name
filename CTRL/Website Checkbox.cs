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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//YouTube
        {
            //  MainTimer.blocked_websites_list;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//Facebook
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)//Reddit
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)//Amazon
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)//Twitter
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)//Instagram
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)//Netflix
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)//eBay
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)//WhatsApp
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)//Spotify
        {

        }

        private void to_website_textboxes_button_Click(object sender, EventArgs e)//used when done with this form
        {
            Website_Textbox website_Textbox = new Website_Textbox();
            website_Textbox.Show();

            this.Close();

        }

        private void to_gather_time_data_button_Click(object sender, EventArgs e)//button to go back to the gather time data form
        {
            Gather_Time_Data gather_Time_Data = new Gather_Time_Data();

            gather_Time_Data.Show();

            this.Close();

        }
    }
}
