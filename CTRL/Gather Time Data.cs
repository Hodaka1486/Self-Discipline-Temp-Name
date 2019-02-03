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
    public partial class Gather_Time_Data : Form
    {
        private bool next_button_clicked = false;//using this to see if form is closed through the next button or the X button

        public Gather_Time_Data()
        {
            InitializeComponent();
        }

        private bool goal_time_checker()
        {
            bool return_value;

            //compare the hours, then the minutes to see if the goal is a higher number than the inital 

            if (Decimal.ToInt32(goal_hours_updown.Value) > Decimal.ToInt32(initial_hours_updown.Value))
            {
                return_value = false;
            }
            else if (Decimal.ToInt32(goal_hours_updown.Value) == Decimal.ToInt32(initial_hours_updown.Value))
            {
                if (Decimal.ToInt32(goal_minutes_updown.Value) >= Decimal.ToInt32(initial_minutes_updown.Value))
                {
                    return_value = false;
                }
                else return_value = true;
             
            }
            else return_value = true;
 
            return return_value;
        }

        //button that beings you to the next form
        private void gather_time_data_next_button_Click(object sender, EventArgs e)
        {
            if(goal_time_checker())
            {
                //save all the values of the gather time data form
                Properties.Settings.Default.initial_hours = Decimal.ToInt32(initial_hours_updown.Value);
                Properties.Settings.Default.initial_minutes = Decimal.ToInt32(initial_minutes_updown.Value);
                Properties.Settings.Default.goal_hours = Decimal.ToInt32(goal_hours_updown.Value);
                Properties.Settings.Default.goal_minutes = Decimal.ToInt32(goal_minutes_updown.Value);
                Properties.Settings.Default.goal_days = Decimal.ToInt32(goal_days_updown.Value);

                Properties.Settings.Default.Save();

                if (Application.OpenForms["MainTimer"] != null)
                {
                    (Application.OpenForms["MainTimer"] as MainTimer).create_website_checkboxes();
                }

                next_button_clicked = true;

                this.Close();

            }
            else
            {
                MessageBox.Show("Your goal has to be lower than the time you spend currently.", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
          
        }

        //when you open this form load the values properly
        private void Gather_Time_Data_Load(object sender, EventArgs e)
        {

            initial_hours_updown.Value    = Properties.Settings.Default.initial_hours;

            initial_minutes_updown.Value = Properties.Settings.Default.initial_minutes;

            goal_hours_updown.Value      = Properties.Settings.Default.goal_hours;

            goal_minutes_updown.Value    = Properties.Settings.Default.goal_minutes;

            goal_days_updown.Value       = Properties.Settings.Default.goal_days;

        }

        private void Gather_Time_Data_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (next_button_clicked)//if closing because of the next/previous buttons
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
