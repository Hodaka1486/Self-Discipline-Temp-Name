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
    public partial class MainTimer : Form
    {

        private int hours_left;
        private int minutes_left;
        private int seconds_left;

        //this list will keep track of all the blocked websites
        //will be called from the set up forms and the settings form
        //public List<string> blocked_websites_list = new List<string>();

        //this is the constructor of the form
        public MainTimer()
        {
            InitializeComponent();
        }

        //on opening the form check if initialized is true or false, if false open website checkboxes and hide this
        private void MainTimer_Load(object sender, EventArgs e)
        {

            if(!Properties.Settings.Default.initialized)//first time set up
            {
                var this_form = this;

                this_form.Hide();

                Gather_Time_Data gather_Time_Data = new Gather_Time_Data();
                gather_Time_Data.Show();     

            }
            else//if true then just load the values into the correct spots 
            {
                //check if it is a new day or not
                if(new_Day())
                {
                    daily_reset();

                }

                //loading the previously saved values
                days_until_goal_number.Text = Properties.Settings.Default.goal_days.ToString();

                //setting the original max, current max and goal max to the proper HH:MM
                original_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.initial_hours, Properties.Settings.Default.initial_minutes);
                current_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.current_hours, Properties.Settings.Default.current_minutes);
                goal_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.goal_hours, Properties.Settings.Default.goal_minutes);

                //make a check to see if it is a new day

                //this is function that resets the timer, and unblocks the websites and programs 
                //daily_reset();

            }

        }

        //used to convert hour/minute into a easy to view format
        private string convert_hr_min_to_text(int hr, int min)
        {
            string hr_str = hr.ToString();
            string min_str = min.ToString();

            if (hr_str.Length == 1) { hr_str = "0" + hr_str; }
            if (min_str.Length == 1) { min_str = "0" + min_str; }

            return(hr_str + ":" + min_str);

        }

        //used to convert our hour/minute/seconds remaining into a easy to view format
        private void convert_timer_to_text(int hr, int min, int sec)
        {
            string hr_str = hr.ToString();
            string min_str = min.ToString();
            string sec_str = sec.ToString();

            if (hr_str.Length  == 1) { hr_str  = "0" + hr_str;  }
            if (min_str.Length == 1) { min_str = "0" + min_str; }
            if (sec_str.Length == 1) { sec_str = "0" + sec_str; }

            timer_label.Text = hr_str + ":" + min_str + ":" + sec_str;

        }

        //and HH:MM:SS countdown timer, if there is no time remaining then it calls a function to block websites and programs specified
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(seconds_left > 0)
            {
                seconds_left = seconds_left - 1;

                convert_timer_to_text(hours_left, minutes_left, seconds_left);

            }
            else//??:??:00
            {
                if(minutes_left == 0)//??:00:00
                {
                    if(hours_left == 0)//00:00:00
                    {
                        timer1.Stop();

                        timer_label.Text = "Complete";//this is for testing purposes

                        //call a function that implements the website and program blocking

                    }
                    else//XX:00:00
                    {
                        hours_left = hours_left - 1;

                        minutes_left = 59;

                        seconds_left = 59;

                        convert_timer_to_text(hours_left, minutes_left, seconds_left);
                    }

                }
                else//??:XX:00
                {
                    minutes_left = minutes_left - 1;

                    seconds_left = 59;

                    convert_timer_to_text(hours_left, minutes_left, seconds_left);
                }

            }
        }

        //this function resets the websites and programs that can be used
        //it also calculates how much the current timer for the day should be
        private void daily_reset()
        {
            //First reduce the value of current max time
            int total_current_minutes = (Properties.Settings.Default.current_hours * 60) + Properties.Settings.Default.current_minutes;

            decimal new_current_minutes = total_current_minutes - Properties.Settings.Default.daily_subtraction_minutes;//is a decimal for the floor function, also subtracts the daily time
            if(new_current_minutes < 0) { new_current_minutes = 0; }//if we get into negatives then just set it to 0

            //set the hours and minutes to the correct values
            Properties.Settings.Default.current_hours   = (int)(Math.Floor(new_current_minutes / 60));
            Properties.Settings.Default.current_minutes = (int)(new_current_minutes) % 60;

            //this is where hosts and regedit will be reset to nothing blocked
            //actually, compare what is on those lists and take off what is on our list, so you don't remove the user's if they manually inserted them

        }

        private bool new_Day()
        {
            bool new_day = false;

            string date = Properties.Settings.Default.current_date;
            string date_now = DateTime.Today.ToString("dd-MM-yyyy");
            //string date_now = "18-01-2019"; //for testing, input your own date here

            //the days
            int day = Convert.ToInt32(date.Substring(0, 2));
            int day_now = Convert.ToInt32(date_now.Substring(0, 2));
            //the months
            int month = Convert.ToInt32(date.Substring(3, 2));
            int month_now = Convert.ToInt32(date_now.Substring(3, 2));
            //the years
            int year = Convert.ToInt32(date.Substring(6,4));
            int year_now = Convert.ToInt32(date_now.Substring(6,4));//the last 4 of the string in this case the year

            //check if the just checked day, month, year are higher than the saved ones
            bool check_day_higher   = day_now > day ? true : false;
            bool check_month_higher = month_now > month ? true : false;
            bool check_year_higher  = year_now > year ? true : false;

            if(check_year_higher){new_day = true;}//means we are in a new year
            else if(year_now == year)//means year is the same            
            {
                if (check_month_higher) { new_day = true; }//same year a higher month is a new day
                else if(month_now == month)//month is the same
                {
                    if (check_day_higher) { new_day = true; }//day is higher in same month and year
                    else { new_day = false; }//the day isn't higher so its the same day or lower
                }
                else { new_day = false; }
            }
            else { new_day = false; }//went back in years

            return new_day;
        }

        private void pause_resume_button_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {

                timer1.Enabled = true;

                pause_resume_button.Text = "Pause";

            }
            else
            {
                timer1.Enabled = false;

                pause_resume_button.Text = "Resume";


            }
        }

        private void test_button_1_Click(object sender, EventArgs e)//brings you to Website_Checkbox for testing
        {
            Website_Checkbox website_Checkbox = new Website_Checkbox();
            website_Checkbox.Show();
        }

        private void button1_Click(object sender, EventArgs e)//go to settings
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void button2_Click(object sender, EventArgs e)//go to gather_time_data
        {
            Gather_Time_Data gather_Time_Data = new Gather_Time_Data();
            gather_Time_Data.Show();
        }

        private void reset_test_button_Click(object sender, EventArgs e)//reset button
        {
            Properties.Settings.Default.initialized = false;
            Properties.Settings.Default.initial_hours = 0;
            Properties.Settings.Default.initial_minutes = 0;
            Properties.Settings.Default.goal_hours = 0;
            Properties.Settings.Default.goal_minutes = 0;
            Properties.Settings.Default.goal_days = 7;
            Properties.Settings.Default.current_hours = 0;
            Properties.Settings.Default.current_minutes = 0;
            Properties.Settings.Default.daily_subtraction_minutes = 0;

            Properties.Settings.Default.Save();
        }
    }
}
