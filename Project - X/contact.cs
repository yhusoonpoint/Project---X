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
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            decision_interface decision_interface = new decision_interface();
            decision_interface.ShowDialog();
            this.Close();
        }
        private void contact_Load(object sender, EventArgs e)
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

        private void first_right_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOON COME");
        }

        private void second_right_button_Click(object sender, EventArgs e)
        {
            appointment appointment = new appointment();
            appointment.ShowDialog();
            this.Close();
        }

        private void third_right_button_Click(object sender, EventArgs e)
        {
            feedback feedback = new feedback();
            feedback.ShowDialog();
            this.Close();
        }

        private void fourth_right_button_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog();
            this.Close();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            decision_interface home = new decision_interface();
            home.ShowDialog();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            main_interface mi = new main_interface();
            mi.ShowDialog();
            this.Close();
        }
    }
}
