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
    public partial class student_service : Form
    {
        public student_service()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            decision_interface decision_interface = new decision_interface();
            decision_interface.ShowDialog();
            this.Close();
        }

        private void student_service_Load(object sender, EventArgs e)
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

        private void other_button_Click(object sender, EventArgs e)
        {
            feedback o = new feedback();
            o.ShowDialog();
            this.Close();
        }

        private void roundbutton2_Click(object sender, EventArgs e)
        {
            decision_interface di = new decision_interface();
            di.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_interface mi = new main_interface();
        }

        private void meeting_button_Click(object sender, EventArgs e)
        {
            meeting m = new meeting();
            m.ShowDialog();
            this.Close();
        }

        private void appointment_button_Click(object sender, EventArgs e)
        {
            session aa = new session();
            aa.ShowDialog();
            this.Close();
        }

        private void project__button_Click(object sender, EventArgs e)
        {
            project pp = new project();
            pp.ShowDialog();
            this.Close();
        }

        private void performance_button_Click(object sender, EventArgs e)
        {
            email p = new email();
            p.ShowDialog();
            this.Close();
        }

        private void timetable_button_Click(object sender, EventArgs e)
        {
            subject s = new subject();
                s.ShowDialog();
            this.Close();
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            home s = new home();
            s.ShowDialog();
            this.Close();
        }
    }
}
