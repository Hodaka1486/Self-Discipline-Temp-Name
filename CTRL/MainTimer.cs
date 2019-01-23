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

                Gather_Time_Data gather_Time_Data = new Gather_Time_Data();
                gather_Time_Data.Show();//show the GTD form

                //the main form is hidden in a shown event because load happens before shown

            }
            else
            {
                //check if it is a new day or not
                if( new_Day() ) { daily_Reset(); }

                //this function initializes all the values on the MainTimer form like
                //the timer, day goals, original max time, current max time, goal time
                initialize_timer_values();

            }

        }

        //this event happens when the form is shown, we have to hide it here because form load happens before the form is shown
        //meaning that it hides it while loading and then reveals it anyway because once it is done loading it is shown
        private void MainTimer_Shown(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.initialized)//first time set up
            {
                Hide();
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
        private void daily_Reset()
        {
            //First reduce the value of current max time
            int total_current_minutes = (Properties.Settings.Default.current_hours * 60) + Properties.Settings.Default.current_minutes;

            decimal new_current_minutes = total_current_minutes - Properties.Settings.Default.daily_subtraction_minutes;//is a decimal for the floor function, also subtracts the daily time
            if(new_current_minutes < 0) { new_current_minutes = 0; }//if we get into negatives then just set it to 0
 
            //set the hours and minutes to the correct values
            Properties.Settings.Default.current_hours   = (int)(Math.Floor(new_current_minutes / 60));
            Properties.Settings.Default.current_minutes = (int)(new_current_minutes) % 60;

            Properties.Settings.Default.Save();

            //this is where hosts and regedit will be reset to nothing blocked
            //actually, compare what is on those lists and take off what is on our list, so you don't remove the user's if they manually inserted them

        }

        //this is the function that implements the blocking of websites and programs
        private void lockdown()
        {
           System.Collections.Specialized.StringCollection locked_sites = new System.Collections.Specialized.StringCollection();

            locked_sites = Properties.Settings.Default.blocked_websites;

            //trying to find a better way to find the hosts file then just assuming that it is always system32\drivers\etc
            string hosts_path = Environment.GetEnvironmentVariable("systemroot") + "System32\\drivers\\etc\\hosts";
       

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

        //this function initializes all the values on the MainTimer form like
        //the timer, day goals, original max time, current max time, goal time
        private void initialize_timer_values()
        {
            //loading the previously saved values
            days_until_goal_number.Text = Properties.Settings.Default.goal_days.ToString();

            //setting the original max, current max and goal max to the proper HH:MM
            original_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.initial_hours, Properties.Settings.Default.initial_minutes);
            current_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.current_hours, Properties.Settings.Default.current_minutes);
            goal_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.goal_hours, Properties.Settings.Default.goal_minutes);

            hours_left = Properties.Settings.Default.current_hours;
            minutes_left = Properties.Settings.Default.current_minutes;
            seconds_left = Properties.Settings.Default.current_seconds;//default is 0, will be not 0 if open the program the same day after a pause

            convert_timer_to_text(hours_left, minutes_left, seconds_left);//have the timer start at the a number rather than 00:00:00

        }

        //this function is called to unhide this form
        public void unhide_main_timer()
        {
            initialize_timer_values();

            this.Show();
        }
        
        //----------------create form functions------------
        //These functions all create different forms in the intialization process. They are used so that each form can
        //create the next form in the list, but I need the main form (MainTimer) to be the on to do so
        //because it needs to be unhidden at the end of the initalization process
        public void create_gather_time_data()
        {
            Gather_Time_Data gather_Time_Data = new Gather_Time_Data();
                gather_Time_Data.Show();//show the GTD form
        }

        public void create_website_checkboxes()
        {
            Website_Checkbox website_Checkbox = new Website_Checkbox();
            website_Checkbox.Show();
        }

        public void create_website_textboxes()
        {
            Website_Textbox website_Textbox = new Website_Textbox();
            website_Textbox.Show();
        }

        public void create_program_textboxes()
        {
            Program_Textbox program_Textbox = new Program_Textbox();
            program_Textbox.Show();
        }

        public void create_confirmation()
        {
            Confirmation confirmation = new Confirmation();
            confirmation.Show();
        }
        //-------------end create form functions----------

        //This entire section is for testing purposes
        private void button1_Click(object sender, EventArgs e)//go to settings
        {
            Settings settings = new Settings();
            settings.Show();
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
            Properties.Settings.Default.blocked_websites.Clear();//removes everything from the string collection

            Properties.Settings.Default.Save();
        }

        private void MainTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //was going to save the value of the timer so that it can open later but need
            //to figure out how to save them without disruption the day's current timer
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
