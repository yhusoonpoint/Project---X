﻿using System;
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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
       /*  appointment appointment = new appointment();
        meeting meeting = new meeting();
        home Home = new home();*/
        private void schedule_button_Click(object sender, EventArgs e)
        {
            schedule schedule = new schedule();
            schedule.ShowDialog();
            this.Close();
        }

        private void meeting_button_Click(object sender, EventArgs e)
        {
            meeting meeting = new meeting();
            meeting.ShowDialog();
            this.Close();
        }

        private void subject_button_Click(object sender, EventArgs e)
        {
            subject subject = new subject();
            subject.ShowDialog();
            this.Close();
        }

        private void appointment_button_Click(object sender, EventArgs e)
        {
            appointment appointment = new appointment();
            appointment.ShowDialog();
            this.Close();
        }

        private void project_button_Click(object sender, EventArgs e)
        {
            project project = new project();
            project.ShowDialog();
            this.Close();
        }

        private void other_button_Click(object sender, EventArgs e)
        {
            other other = new other();
            other.ShowDialog();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            decision_interface decision_interface = new decision_interface();
            decision_interface.ShowDialog();
            this.Close();
        }

        private void peformance_button_Click(object sender, EventArgs e)
        {
            performance performance = new performance();
            performance.ShowDialog();
            this.Close();
        }

        private void enrichment_button_Click(object sender, EventArgs e)
        {
            enrichment enrichment = new enrichment();
            enrichment.ShowDialog();
            this.Close();
        }

        private void home_Load(object sender, EventArgs e)
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

        private void two_curve_edge_button1_Click(object sender, EventArgs e)
        {
            other other = new other();
            other.ShowDialog();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            main_interface mi = new main_interface();
            mi.ShowDialog();
            this.Close();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            decision_interface di = new decision_interface();
            di.ShowDialog();
            this.Close();
        }
    }
}
