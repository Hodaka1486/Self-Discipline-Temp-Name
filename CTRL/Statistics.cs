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
    public partial class Statistics : Form
    {


        public Statistics()
        {

            InitializeComponent();

            this.Paint += new PaintEventHandler(Statistics_Paint);
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

        private void Statistics_Load(object sender, EventArgs e)
        {

            //setting the day counter to the correct number of days
            days_until_goal_number.Text = Properties.Settings.Default.goal_days.ToString();

            //setting the original max, current max and goal max to the proper HH:MM
            original_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.initial_hours, Properties.Settings.Default.initial_minutes);
            current_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.current_hours, Properties.Settings.Default.current_minutes);
            goal_max_time_value.Text = convert_hr_min_to_text(Properties.Settings.Default.goal_hours, Properties.Settings.Default.goal_minutes);

            total_days_label.Text = Properties.Settings.Default.total_days.ToString();

            //calculate the average daily leisure and productive time and set them to the labels
            if (Properties.Settings.Default.total_days != 0)//if the user hasn't go through a daily reset than total days is 0
            { 
                int avg_leisure_seconds = Properties.Settings.Default.total_leisure_time / Properties.Settings.Default.total_days;
                int avg_productive_seconds = Properties.Settings.Default.total_productive_time / Properties.Settings.Default.total_days;

                if (Application.OpenForms["MainTimer"] != null)
                {
                    avg_daily_leisure_time_label.Text = (Application.OpenForms["MainTimer"] as MainTimer).convert_seconds_to_HHMMSS(avg_leisure_seconds);
                }

                if (Application.OpenForms["MainTimer"] != null)
                {
                    avg_daily_productive_time_label.Text = (Application.OpenForms["MainTimer"] as MainTimer).convert_seconds_to_HHMMSS(avg_productive_seconds);
                }

                foreach (string x in Properties.Settings.Default.leisure_last_seven_days)
                {
                    listView1.Items.Add(x);
                }

                foreach (string x in Properties.Settings.Default.productivity_last_seven_days)
                {
                    listView2.Items.Add(x);
                }
            }
      

        }

        private void Statistics_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //draw center dividerline
            Color LightBlack = Color.FromArgb(64, 64, 64);
            Pen divider_pen = new Pen(LightBlack, 7);
            Point p1 = new Point(375, 50);
            Point p2 = new Point(375, 450);
            g.DrawLine(divider_pen, p1, p2);

            //draw horizontal seperater line at top
            Color LightningBlue = Color.FromArgb(82, 179, 240);
            Pen horizontal_divider_pen = new Pen(LightningBlue, 3);
            Point p3 = new Point(0, 25);
            Point p4 = new Point(450, 25);
            g.DrawLine(horizontal_divider_pen, p3, p4);

            //for some reason the line wont draw but the center divider line works with almost the same code

        }
    }
}
