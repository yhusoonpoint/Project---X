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
    public partial class email : Form
    {
        List<Uri> HistoryStack;
        int HistoryStack_Index;
        bool fromHistory;
        public email()
        {            
            InitializeComponent();
            HistoryStack = new List<Uri>();
            HistoryStack_Index = 0;
            fromHistory = false;
            updateNavButtons();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {/*
            progressBar1.Maximum = (int)e.MaximumProgress;
            progressBar1.Minimum = 0;
            if ((e.CurrentProgress > 0) && (e.CurrentProgress < 100))
            {
                progressBar1.Value = (int)e.CurrentProgress;
            }*/
            if(e.CurrentProgress == 100)
            {
                progressBar1.Value = 0;
            }
            else if ((int)e.CurrentProgress > 0)
            {
                progressBar1.Maximum = (int)e.MaximumProgress;
                progressBar1.Value = (int)e.CurrentProgress;
            }
        }

        private void home_browser_button_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://fed.greenwichutc.com/adfs/ls/?username=1%40greenwichutc.com&wa=wsignin1.0&wtrealm=urn%3afederation%3aMicrosoftOnline&wctx=estsredirect%3d2%26estsrequest%3drQIIAbPSySgpKSi20tcvyC8qSczRy81MLsovzk8ryc_LycxL1UvOz9XLL0rPTAGxioS4BC5k1G7oXyrk3TyzS2Y2exvzKkZlwkboX2BkfMHIeItJ0L8o3TMlvNgtNSW1KLEkMz_vERNvaHFqkX9eTmVIfnZq3iRmvpz89My8-OKitPi0nPxyoADQhILE5JL4kszk7NSSXcwqycYmJoZJKYa6FobGKbomhkYWukmWlkAiMS0t0cIs1cA4JekCi8ABTkYA0&popupui=");
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            decision_interface home = new decision_interface();
            home.ShowDialog();
            this.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void updateNavButtons()
        {
            if (HistoryStack_Index > 1)
            {
                this.back_browser_button.Enabled = true;
            }
            else
            {
                this.back_browser_button.Enabled = false;
            }
            if (HistoryStack_Index < HistoryStack.Count)
            {
                this.forward_browser_button.Enabled = true;
            }
            else
            {
                this.forward_browser_button.Enabled = false;
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (!fromHistory)
            {
                if (HistoryStack_Index < HistoryStack.Count)
                {
                    HistoryStack.RemoveRange(HistoryStack_Index, HistoryStack.Count - HistoryStack_Index);
                }
                HistoryStack.Add(e.Url);
                HistoryStack_Index += 1;
                updateNavButtons();
            }
            fromHistory = false;
        }

        private void back_browser_button_Click(object sender, EventArgs e)
        {
            if (HistoryStack_Index > 1)
            {
                HistoryStack_Index -= 1;
                fromHistory = true;
                webBrowser1.Navigate(HistoryStack[HistoryStack_Index - 1]);
                updateNavButtons();
            }
        }

        private void forward_browser_button_Click(object sender, EventArgs e)
        {
            if (HistoryStack_Index < HistoryStack.Count)
            {
                HistoryStack_Index += 1;
                fromHistory = true;
                webBrowser1.Navigate(HistoryStack[HistoryStack_Index - 1]);
                updateNavButtons();
            }
        }

        private void email_Load(object sender, EventArgs e)
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

        private void logout_button_Click(object sender, EventArgs e)
        {
            main_interface mi = new main_interface();
            mi.ShowDialog();
            this.Close();
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            student_service ss = new student_service();
            ss.ShowDialog();
            this.Close();
        }

        private void performance_button_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.ShowDialog();
            this.Close();
        }

        private void appointment_button_Click(object sender, EventArgs e)
        {
            session session = new session();
            session.ShowDialog();
            this.Close();
        }

        private void other_button_Click(object sender, EventArgs e)
        {
            feedback feedback = new feedback();
            feedback.ShowDialog();
            this.Close();
        }
    }
}
