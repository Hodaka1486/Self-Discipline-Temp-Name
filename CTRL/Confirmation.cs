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
    public partial class Confirmation : Form
    {
        private bool confirm_go_back_button_pressed = false;

        public Form main_timer_reference { get; set; }//reference to the parent form which will be MainTimer

        public Confirmation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//I am sure
        {
            Properties.Settings.Default.initialized = true;//this value is so the program knows the user has gone through set up

            //these values are for remembering the time when the program is closed then opened
            Properties.Settings.Default.current_hours   = Properties.Settings.Default.initial_hours;
            Properties.Settings.Default.current_minutes = Properties.Settings.Default.initial_minutes;

            //these values are for knowing the max time the user has that day 
            Properties.Settings.Default.daily_max_hours = Properties.Settings.Default.initial_hours;
            Properties.Settings.Default.daily_max_minutes = Properties.Settings.Default.initial_minutes;

            //calculate the amount of time that must be subtracted each day
            int total_minutes_initial = (Properties.Settings.Default.initial_hours * 60) + Properties.Settings.Default.initial_minutes;
            int total_minutes_goal    = (Properties.Settings.Default.goal_hours * 60) + Properties.Settings.Default.goal_minutes;
            int difference = total_minutes_initial - total_minutes_goal;
            float minutes_subtracted_per_day = (difference / Properties.Settings.Default.goal_days);

            Properties.Settings.Default.daily_subtraction_minutes = (int)(Math.Ceiling(minutes_subtracted_per_day));

            Properties.Settings.Default.current_date = DateTime.Today.ToString("dd-MM-yyyy");//if you make it mm then it doesn't get month correct

            //need to know the original number of goal days, goal days will decrement to show user progress
            Properties.Settings.Default.original_goal_days = Properties.Settings.Default.goal_days;                                                                                                 

            Properties.Settings.Default.Save();//save all the values, these persist through closing the program

            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).unhide_main_timer();
            }

            confirm_go_back_button_pressed = true;

            this.Close();            
        }

        private void button2_Click(object sender, EventArgs e)//Let me go back
        {

            if (Application.OpenForms["MainTimer"] != null)
            {
                (Application.OpenForms["MainTimer"] as MainTimer).create_gather_time_data();
            }

            confirm_go_back_button_pressed = true;

            this.Close();

        }

        private void Confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirm_go_back_button_pressed)//if closing because of the confirm or go back buttons
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
