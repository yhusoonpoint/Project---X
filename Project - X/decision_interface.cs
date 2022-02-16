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
    public partial class decision_interface : Form
    {

        decision decision = new decision();
      /*  [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );*/
        public decision_interface()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        private void decision_interface_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Opacity = 0;
            fade_in_timer.Enabled = true;
            string identify_person = decision.main_screen_option;
            if (identify_person == "visitor")
            {
                tittle_label.Text = "HELLO VISITOR";
                ss__button.Text = "PEN PHOTOS";
                about_or_home_button.Text = "ABOUT UTC";
                feedback_button.Text = "APPOINTMENT";
                session_button.Text = "FEEDBACK";
                contact_button.Text = "CONTACT";
                back_round_button.Text = "LOG OUT";
                other.Visible = false;

            }
            else if (identify_person == "swipe")
            {
                tittle_label.Text = "HELLO USER";
                ss__button.Text = "STUDENT SERVICES";
                about_or_home_button.Text = "PEN";
                feedback_button.Text = "EMAIL";
                session_button.Text = "SESSION";
                contact_button.Text = "FEEDBACK";
                back_round_button.Text = "LOG OUT";
            }
            else { MessageBox.Show(identify_person.ToString()); }
        }

        private void back_round_button_Click(object sender, EventArgs e)
        {
            this.Close();
            main_interface main_interface = new main_interface();
            main_interface.ShowDialog();
        }

        private void ss__button_Click(object sender, EventArgs e)
        {
            string identify_person = decision.main_screen_option;
            if (identify_person == "visitor")
            {
                MessageBox.Show("SOON FIX");

            }
            else if (identify_person == "swipe")
            {
                student_service student_service = new student_service();
                student_service.ShowDialog();   
                this.Close();
            }
            else { MessageBox.Show(identify_person.ToString()); }
       
        }

        private void about_or_home_button_Click(object sender, EventArgs e)
        {
            string identify_person = decision.main_screen_option;
            if (identify_person == "visitor")
            {
                about about = new about();
                about.ShowDialog();
                this.Close();

            }
            else if (identify_person == "swipe")
            {
                home home = new home();
                home.ShowDialog();
                this.Close();
            }
            else { this.Close(); }
        }

        private void feedback_button_Click(object sender, EventArgs e)
        {
            string identify_person = decision.main_screen_option;
            if (identify_person == "swipe")
            {
                email email = new email();
                email.ShowDialog();
                this.Close();
            }
            else if (identify_person == "visitor")
            {
                appointment appointment = new appointment();
                appointment.ShowDialog();
                this.Close();
            }
            else this.Close();

            
        }

        private void session_button_Click(object sender, EventArgs e)
        {
            string identify_person = decision.main_screen_option;
            if (identify_person == "swipe")
            {
                session session = new session();
                session.ShowDialog();
                this.Close();
            }
            else if (identify_person == "visitor")
            {
                feedback feedback = new feedback();
                feedback.ShowDialog();
                this.Close();
            }
            else this.Close();
        }

        private void contact_button_Click(object sender, EventArgs e)
        {
            string identify_person = decision.main_screen_option;
            if (identify_person == "swipe")
            {
                feedback feedback = new feedback();
                feedback.ShowDialog();
                this.Close();
            }
            else if (identify_person == "visitor")
            {
                contact contact = new contact();
                contact.ShowDialog();
                this.Close();
            }
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void other_Click(object sender, EventArgs e)
        {
            other other = new other();
            other.ShowDialog();
            this.Close();

        }
    }
}
