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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            decision_interface decision_interface = new decision_interface();
            decision_interface.ShowDialog();
            this.Close();
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Opacity = 0;
            fade_in_timer.Enabled = true;
            string who_is_this = decision.main_screen_option;
            if (who_is_this == "visitor")
            {
                schedule_button.Text = "Photo";
                performance_button.Text = "Appointment";
                appointment_button.Text = "About UTC";
                other_button.Text = "Contact";
            }
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

        private void schedule_button_Click(object sender, EventArgs e)
        {
            if (schedule_button.Text.ToLower() != "photo")
            {
                student_service schedule = new student_service();
                schedule.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("soon come");
            }
        }

        private void timetable_button_Click(object sender, EventArgs e)
        {
            subject sub = new subject();
            sub.ShowDialog();
            this.Close();
        }

        private void performance_button_Click(object sender, EventArgs e)
        {
            if(performance_button.Text.ToLower() != "appointment")
            {
                home perf = new home();
                perf.ShowDialog();
                this.Close();
            }
            else
            {
                appointment app = new appointment();
                app.ShowDialog();
                this.Close();
            }
        }

        private void project__button_Click(object sender, EventArgs e)
        {
            project prject = new project();
            prject.Close();
            this.Close();
        }

        private void appointment_button_Click(object sender, EventArgs e)
        {
            if (appointment_button.Text.ToLower() == "appointment")
            {
                email app = new email();
                app.ShowDialog();
                this.Close();
            }
            else
            {
                about about = new about();
                about.ShowDialog();
                this.Close();
            }

        }

        private void meeting_button_Click(object sender, EventArgs e)
        {
            meeting meeting = new meeting();
            meeting.ShowDialog();
            this.Close();
        }

        private void other_button_Click(object sender, EventArgs e)
        {
            if(other_button.Text.ToLower() != "contact")
            {
                feedback other = new feedback();
                other.ShowDialog();
                this.Close();
            }
            else
            {
                contact contact = new contact();
                contact.ShowDialog();
                this.Close();
            }
        }
    }
}
