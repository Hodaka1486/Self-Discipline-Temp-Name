using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CTRL
{

    public partial class MainTimer : Form
    {
        //----------------------------------------------------------Variables--------------------------------------------------------
        // a bool that is true when the user is out of time
        private bool out_of_time = false;
            
        //for the timer, tracks how much time is left
        private int hours_left;
        private int minutes_left;
        private int seconds_left;

        //for the stopwatch, track how productive you are
        private int hours_productive;
        private int minutes_productive;
        private int seconds_productive;

        //-----------------------------------------------------------Functions-------------------------------------------------------

        //this is the constructor of the form
        public MainTimer()
        {
            InitializeComponent();
        }

        //used to convert hour/minute into a easy to view format (for displaying current/goal times)
        private string convert_hr_min_to_text(int hr, int min)
        {
            string hr_str = hr.ToString();
            string min_str = min.ToString();

            if (hr_str.Length == 1) { hr_str = "0" + hr_str; }
            if (min_str.Length == 1) { min_str = "0" + min_str; }

            return (hr_str + ":" + min_str);

        }

        //used to convert our hour/minute/seconds remaining into a easy to view format (for displaying the timer)
        private string convert_timer_to_text(int hr, int min, int sec)
        {
            string hr_str = hr.ToString();
            string min_str = min.ToString();
            string sec_str = sec.ToString();

            if (hr_str.Length == 1) { hr_str = "0" + hr_str; }
            if (min_str.Length == 1) { min_str = "0" + min_str; }
            if (sec_str.Length == 1) { sec_str = "0" + sec_str; }

            return hr_str + ":" + min_str + ":" + sec_str;

        }

        //this function initializes all the values on the MainTimer form like
        //the timer, day goals, original max time, current max time, goal time
        private void initialize_timer_values()
        {            
            //load the countdown timer values
            hours_left = Properties.Settings.Default.current_hours;
            minutes_left = Properties.Settings.Default.current_minutes;
            seconds_left = Properties.Settings.Default.current_seconds;//default is 0, will be not 0 if open the program the same day after a pause
            

            timer_label.Text = convert_timer_to_text(hours_left, minutes_left, seconds_left);//have the timer start at the a number rather than 00:00:00

            //load the stopwatch values
            this.hours_productive   = Properties.Settings.Default.hours_productive;
            this.minutes_productive = Properties.Settings.Default.minutes_productive;
            this.seconds_productive = Properties.Settings.Default.seconds_productive;

            stopwatch_label.Text = convert_timer_to_text(hours_productive, minutes_productive, seconds_productive);
        }

        //checks if it is a new day since last opening the program
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
            int year = Convert.ToInt32(date.Substring(6, 4));
            int year_now = Convert.ToInt32(date_now.Substring(6, 4));//the last 4 of the string in this case the year

            //check if the just checked day, month, year are higher than the saved ones
            bool check_day_higher = day_now > day ? true : false;
            bool check_month_higher = month_now > month ? true : false;
            bool check_year_higher = year_now > year ? true : false;

            if (check_year_higher) { new_day = true; }//means we are in a new year
            else if (year_now == year)//means year is the same            
            {
                if (check_month_higher) { new_day = true; }//same year a higher month is a new day
                else if (month_now == month)//month is the same
                {
                    if (check_day_higher) { new_day = true; }//day is higher in same month and year
                    else { new_day = false; }//the day isn't higher so its the same day or lower
                }
                else { new_day = false; }
            }
            else { new_day = false; }//went back in years

            return new_day;
        }

        //this function resets the websites and programs that can be used
        //it also calculates how much the current timer for the day should be
        private void daily_Reset()
        {
            //--------------------------------Reseting Variables--------------------------------------------

            out_of_time = false;//reset this value because time is reset
            pause_resume_button.Enabled = true;//re-enable the button because it gets disable when you run out of time

            if(Properties.Settings.Default.tommorow_blocked_websites != null)//if the user changed what websites to block with Settings
            {
                //change the blocked websites to the user's new list, set tommorow_blocked_websites back to null
                Properties.Settings.Default.blocked_websites = Properties.Settings.Default.tommorow_blocked_websites;

                Properties.Settings.Default.tommorow_blocked_websites = null;
            }

            if (Properties.Settings.Default.goal_days != 0)//if we are at the goal day we won't want to go to -1 days
            {
                Properties.Settings.Default.goal_days = Properties.Settings.Default.goal_days - 1;//subtract 1 day from the goal because we are on the next day
            }

            //----------------------------Calculating daily max time and reseting countdown and stopwatch--------------------

            //First calculate the original time in minutes
            int total_initial_minutes = (Properties.Settings.Default.initial_hours * 60) + Properties.Settings.Default.initial_minutes;
            int goal_days_difference = Properties.Settings.Default.original_goal_days - Properties.Settings.Default.goal_days;//find the amount of days difference

            //is a decimal for the floor function, also calculates the daily time remaining
            //it takes the original time and subtracts the time per day multiplied by the amount of days that occured
            decimal new_goal_minutes = total_initial_minutes - (Properties.Settings.Default.daily_subtraction_minutes * goal_days_difference);
            if (new_goal_minutes < 0) { new_goal_minutes = 0; }//if we get into negatives then just set it to 0

            //set the hours and minutes to the correct values
            Properties.Settings.Default.current_hours = (int)(Math.Floor(new_goal_minutes / 60));
            Properties.Settings.Default.current_minutes = (int)(new_goal_minutes) % 60;
            Properties.Settings.Default.current_seconds = 0;//if we are on a new day the seconds should be 0

            //set the stopwatch back to 0
            Properties.Settings.Default.hours_productive   = 0;
            Properties.Settings.Default.minutes_productive = 0;
            Properties.Settings.Default.seconds_productive = 0;

            Properties.Settings.Default.Save();

            //--------------------------------------Unblocking Websites--------------------------------------

            //this is where hosts and regedit will be reset to nothing blocked
            string hosts_path = Environment.GetEnvironmentVariable("systemroot") + "\\System32\\drivers\\etc\\hosts";
            string hosts_copy_path = Environment.GetEnvironmentVariable("systemroot") + "\\System32\\drivers\\etc\\hosts_original";

            if (!System.IO.File.Exists(hosts_copy_path))//if they don't have a backup hosts
            {

                System.IO.File.Create(hosts_copy_path).Close();//create a backup hosts

                //read the current hosts file into a list, find where our designated #appended by CTRL X
                //save that index and look through that line to get the number X, then delete that line and the X infront of it
                //write the hosts file to the backup
                List<string> linesList = System.IO.File.ReadAllLines(hosts_path).ToList();

                int index = linesList.FindIndex(s => new Regex(@"#appended by CTRL \d+").Match(s).Success);

                System.Diagnostics.Debug.WriteLine("index is " + index);

                //uses regex to find that number in the string, convert the match to a string and then that string to an -
                if (index != -1)//means we found our comment in the hosts file
                {
                    int number_of_websites = int.Parse(Regex.Match(linesList[index], @"\d+").ToString());

                    //need to remove the strings at index, index-1, index-2, index-3...index-numberofwebsites
                    //need to fix this entire following section

                    System.Diagnostics.Debug.WriteLine("number of websites is " + number_of_websites);

                    for (int i = 0; i < number_of_websites+1; i++)
                    {

                        System.Diagnostics.Debug.WriteLine(linesList[index-i] + " is removed");
                        linesList.RemoveAt(index - i);

                    }

                    //now we have our list of what the hosts file looks like without our website blocking
                    //make this the backup and the main hosts file because there should beno websites currently blocked
                    System.IO.File.WriteAllLines(hosts_path, linesList);
                    System.IO.File.WriteAllLines(hosts_copy_path, linesList);
                    
                }
                else//our comment isn't there, meaning either we hadn't edited the file or that the user deleted that comment.
                {
                    //copy the current hosts file and make it the backup and leave the hosts file where it is
                    System.IO.File.Copy(hosts_path, hosts_copy_path, true);
                }

            }
            else//they do still have the backup which is how it should be
            {

                System.IO.File.Copy(hosts_copy_path, hosts_path, true);//copying the original back to being hosts so that they are unblocked

            }


        }

        //this is the function that implements the blocking of websites and programs
        private void lockdown()
        {
            out_of_time = true;

            System.Collections.Specialized.StringCollection locked_sites = new System.Collections.Specialized.StringCollection();
            locked_sites = Properties.Settings.Default.blocked_websites;

            //System.Collections.Specialized.StringCollection locked_programs = new System.Collections.Specialized.StringCollection();
            //locked_programs = Properties.Settings.Default.blocked_programs;

            //trying to find a better way to find the hosts file then just assuming that it is always system32\drivers\etc
            string hosts_path = Environment.GetEnvironmentVariable("systemroot") + "\\System32\\drivers\\etc\\hosts";
            //another path that will allow me to copy the user's hosts file so that I can use it to unblock the sites when the day resets
            string hosts_copy_path = Environment.GetEnvironmentVariable("systemroot") + "\\System32\\drivers\\etc\\hosts_original";

            if (!System.IO.File.Exists(hosts_path))//if they don't have a hosts
            {
                System.IO.File.Create(hosts_path).Close();//this creates the file and them immediately closes it, leaving it blank

                System.Diagnostics.Debug.WriteLine("they don't have a hosts");
            }

            System.IO.File.Copy(hosts_path, hosts_copy_path, true);//copying the file

            //now modify the hosts file for blocking websites
            if (locked_sites != null)
            {

                System.IO.File.AppendAllText(hosts_path, Environment.NewLine);//add a newline so that we always start on an uncommented line

                //iterate through the list of websites that should be blocked and add them to the hosts file
                foreach (string x in locked_sites)
                {
                    System.IO.File.AppendAllText(hosts_path, "127.0.0.1     " + "www." + x + Environment.NewLine);
                    //System.Diagnostics.Debug.WriteLine("appeneded " + x);//this is for testing purposes
                }

            }
            int count = locked_sites.Count;

            System.IO.File.AppendAllText(hosts_path, "#appended by CTRL " + count);

        }

        //this function is called to unhide this form
        public void unhide_main_timer()
        {
            initialize_timer_values();

            this.Show();
        }

        //--------------------------------------------------Create Form Functions----------------------------------------------------
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

        //-------------------------------------------------------Form Events----------------------------------------------------------
        //things like on load or pressing a button

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

        private void MainTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //save the countdown timer
            Properties.Settings.Default.current_hours   = this.hours_left;
            Properties.Settings.Default.current_minutes = this.minutes_left;
            Properties.Settings.Default.current_seconds = this.seconds_left;
            //save the stopwatch
            Properties.Settings.Default.hours_productive   = this.hours_productive;
            Properties.Settings.Default.minutes_productive = this.minutes_productive;
            Properties.Settings.Default.seconds_productive = this.seconds_productive;

            Properties.Settings.Default.Save();
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

        //and HH:MM:SS countdown timer, if there is no time remaining then it calls a function to block websites and programs specified
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(seconds_left > 0)
            {
                seconds_left = seconds_left - 1;

                timer_label.Text = convert_timer_to_text(hours_left, minutes_left, seconds_left);

            }
            else//??:??:00
            {
                if(minutes_left == 0)//??:00:00
                {
                    if(hours_left == 0)//00:00:00
                    {
                        timer1.Stop();

                        pause_resume_button.Enabled = false;

                        //calls a function that implements the website and program blocking
                        lockdown();

                    }
                    else//XX:00:00
                    {
                        hours_left = hours_left - 1;

                        minutes_left = 59;

                        seconds_left = 59;

                        timer_label.Text = convert_timer_to_text(hours_left, minutes_left, seconds_left);
                    }

                }
                else//??:XX:00
                {
                    minutes_left = minutes_left - 1;

                    seconds_left = 59;

                    timer_label.Text = convert_timer_to_text(hours_left, minutes_left, seconds_left);
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds_productive += 1;

            if(seconds_productive == 60)
            {
                seconds_productive = 0;

                minutes_productive += 1;

                if(minutes_productive == 60)
                {
                    minutes_productive = 0;

                    hours_productive += 1;
                }

            }

           stopwatch_label.Text = convert_timer_to_text(hours_productive, minutes_productive, seconds_productive);

        }

        private void pause_resume_button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)//if paused then unpause
            {
               
                timer1.Enabled = true;

                pause_resume_button.Text = "Pause";
                
                if(timer2.Enabled)//if the stopwatch is counting up pause it
                {
                    timer2.Enabled = false;

                    productivity_stopwatch_button.Text = "Resume";
                }

            }
            else//if going then pause it
            {

                timer1.Enabled = false;

                pause_resume_button.Text = "Resume";

                if (!timer2.Enabled)//if the stopwatch is paused unpause it
                {
                    timer2.Enabled = true;

                    productivity_stopwatch_button.Text = "Pause";
                }

            }
        }

        private void productivity_stopwatch_button_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == false)//if not going then unpause
            {

                timer2.Enabled = true;

                productivity_stopwatch_button.Text = "Pause";

                if (timer1.Enabled)//if countdown is on then pause it
                {
                    timer1.Enabled = false;

                    pause_resume_button.Text = "Resume";
                }

            }
            else//if going then pause
            {
                timer2.Enabled = false;

                productivity_stopwatch_button.Text = "Resume";

                if (!timer1.Enabled)//if countdown off on then unpause it
                {

                    if (out_of_time == false)
                    {
                        timer1.Enabled = true;

                        pause_resume_button.Text = "Pause";

                    }
                   
                }

            }

        }

        //light brown - to minimize the program
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Red X button to close the window
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //clicking statistics in the tool bar
        private void statToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if there is a settings form open currently, if there is don't make another
            if ((Application.OpenForms["Statistics"] as Statistics) != null)
            {
                //Form is already open
            }
            else
            {
                Statistics statistics = new Statistics();
                statistics.Show();
            }
        }

        //clicking settings in the toolbar
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if there is a settings form open currently, if there is don't make another
            if ((Application.OpenForms["Settings"] as Settings) != null)
            {
                //Form is already open
            }
            else
            {
                Settings settings = new Settings();
                settings.Show();
            }
           
        }

        //when pressed it pauses both timers, for use when the user isn't using time but also isn't productive     
        private void double_pause_button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            pause_resume_button.Text = "Resume";
            productivity_stopwatch_button.Text = "Resume";
        }

        private void MainTimer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Control) double_pause_button_Click(sender, e);//ctrl+p pauses both timers shortcut   
        }

        //https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        //----------Moving the Form--------
        private bool mouseDown;
        private Point lastLocation;

        private void MainTimer_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainTimer_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void MainTimer_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //------------------------------------------------------Testing---------------------------------------------------

        //This entire section is for testing purposes

        private void reset_test_button_Click(object sender, EventArgs e)//reset button
        {
            Properties.Settings.Default.Reset();

            Properties.Settings.Default.Save();

            string hosts_copy_path = Environment.GetEnvironmentVariable("systemroot") + "\\System32\\drivers\\etc\\hosts_original";

            if (System.IO.File.Exists(hosts_copy_path))
            {
                System.IO.File.Delete(hosts_copy_path);
            }

            this.Close();
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            daily_Reset();
            initialize_timer_values();
        }

        private void button2_Click(object sender, EventArgs e)//lockdown test button
        {
            lockdown();
        }

    }
}
