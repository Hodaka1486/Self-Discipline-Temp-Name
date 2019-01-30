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
        }
    }
}
