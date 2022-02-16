using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___X
{
    public partial class session : Form
    {
        public session()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            decision_interface decision_interface = new decision_interface();
            decision_interface.ShowDialog();
            this.Close();
        }

        private void session_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Opacity = 0;
            fade_in_timer.Enabled = true;

        }

        private void fade_in_timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
            if (this.Opacity >= 1)
            {
                fade_in_timer.Enabled = false;
            }
        }

        private void time_timer_Tick(object sender, EventArgs e)
        {

            time_and_date_label.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year + "\r\n" + "\r\n" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

        }

        private void Timetable_button_Click(object sender, EventArgs e)
        {
            subject s = new subject();
            s.ShowDialog();
            this.
                Close();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            decision_interface di = new decision_interface();
            di.ShowDialog();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            main_interface mi = new main_interface();
            mi.ShowDialog();
            this.Close();
        }

        private void other_button_Click(object sender, EventArgs e)
        {
            feedback other = new feedback();
            other.ShowDialog();
            this.Close();
        }

        private void meeting_button_Click(object sender, EventArgs e)
        {
            meeting m = new meeting();
            m.ShowDialog();
            this.Close();
        }

        private void appointment_button_Click(object sender, EventArgs e)
        {
            email a = new email();
            a.ShowDialog();
            this.Close();
        }

        private void performance_button_Click(object sender, EventArgs e)
        {
            performance p = new performance();
            p.ShowDialog();
            this.Close();
        }

        private void project_button_Click(object sender, EventArgs e)
        {
            student_service p = new student_service();
                p.ShowDialog();
            this.Close();
        }

        private void enrichment_button_Click(object sender, EventArgs e)
        {
            home ee = new home();
            ee.ShowDialog();
            this.Close();
        }
    }
}
