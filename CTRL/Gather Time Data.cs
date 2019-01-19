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
        public Gather_Time_Data()
        {
            InitializeComponent();
        }

        //button that beings you to the next form
        private void gather_time_data_next_button_Click(object sender, EventArgs e)
        {
            //save all the values of the gather time data form
            Properties.Settings.Default.initial_hours   = Decimal.ToInt32(inital_hours_updown.Value);
            Properties.Settings.Default.initial_minutes = Decimal.ToInt32(initial_minutes_updown.Value);
            Properties.Settings.Default.goal_hours      = Decimal.ToInt32(goal_hours_updown.Value);
            Properties.Settings.Default.goal_minutes    = Decimal.ToInt32(goal_minutes_updown.Value);
            Properties.Settings.Default.goal_days       = Decimal.ToInt32(goal_days_updown.Value);

            Properties.Settings.Default.Save();

            Website_Checkbox website_Checkbox = new Website_Checkbox();
            website_Checkbox.Show();

            this.Close();
        }

        //when you open this form load the values properly
        private void Gather_Time_Data_Load(object sender, EventArgs e)
        {

            inital_hours_updown.Value    = Properties.Settings.Default.initial_hours;

            initial_minutes_updown.Value = Properties.Settings.Default.initial_minutes;

            goal_hours_updown.Value      = Properties.Settings.Default.goal_hours;

            goal_minutes_updown.Value    = Properties.Settings.Default.goal_minutes;

            goal_days_updown.Value       = Properties.Settings.Default.goal_days;

        }

    }
}
