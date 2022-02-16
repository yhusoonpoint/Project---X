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
    public partial class appointment : Form
    {
        public appointment()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            decision_interface decision_interface = new decision_interface();
            decision_interface.ShowDialog();
            this.Close();
        }


        private void schedule_button_Click(object sender, EventArgs e)
        {
            if (schedule_button.Text.ToLower() != "photo")
            {
                schedule schedule = new schedule();
                schedule.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("SOON COME");}
        }
        private void other_button_Click(object sender, EventArgs e)
        {
            if (other_button.Text.ToLower() != "contact")
            {
                other other = new other();
                other.ShowDialog();
            }
            else
            {
                contact contact = new contact();
                contact.ShowDialog();
                this.Close();
            }
        }

        private void enrichment_button_Click(object sender, EventArgs e)
        {
            enrichment enrichment = new enrichment();
            enrichment.ShowDialog();
            this.Close();
        }

        private void Timetable_button_Click(object sender, EventArgs e)
        {
            if (Timetable_button.Text.ToLower() != "about")
            {
                subject subject = new subject();
                subject.ShowDialog();
                this.Close();
            }
            else
            {
                about about = new about();
                about.ShowDialog();
                this.Close();
            }
        }

        private void project_button_Click(object sender, EventArgs e)
        {
            project project = new project();
            project.ShowDialog();
            this.Close();
        }

        private void performance_button_Click(object sender, EventArgs e)
        {
            if (meeting_button.Text.ToLower() != "feedback")
            {
                performance performance = new performance();
                performance.ShowDialog();
                this.Close();
            }
            else
            {
                feedback feedback = new feedback();
                feedback.ShowDialog();
                this.Close();
            }
        }

        private void meeting_button_Click(object sender, EventArgs e)
        {
                meeting meeting = new meeting();
                meeting.ShowDialog();
                this.Close();
        }
        decision decision = new decision();
        private void appointment_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Opacity = 0;
            fade_in_timer.Enabled = true;
            string who_is_this = decision.main_screen_option;
            if (who_is_this == "visitor")
            {
                schedule_button.Text = "Photo";
                Timetable_button.Text = "About";
                performance_button.Text = "Feedback";
                other_button.Text = "Contact";
                enrichment_button.Visible = false;
                project_button.Visible = false;
                meeting_button.Visible = false;
            }
            else if (who_is_this == "swipe")
            { }
            else this.Close();

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

        private void first_left_button_Click(object sender, EventArgs e)
        {
            info_box.Text = "THIS IS APPOINTMENT ONE";
        }

        private void roundbutton3_Click(object sender, EventArgs e)
        {
        }

        private void scond_left_button_Click(object sender, EventArgs e)
        {
            info_box.Text = "THIS IS APPOINTMENT TWO";

        }

        private void third_left_button_Click(object sender, EventArgs e)
        {
            info_box.Text = "THIS APPOINTMENT IS EMPTY";
        }

        private void create_appointment_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOON COME");
        }

        private void roundbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOON COME");
        }
    }
}
