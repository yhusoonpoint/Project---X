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
    public partial class main_interface : Form
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
        public main_interface()
        {

            InitializeComponent();
           /// Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        private void swipe_button_Click(object sender, EventArgs e)
        {
            decision_interface decision_interface_dialog = new decision_interface();
            decision.main_screen_option = "swipe";
            decision_interface_dialog.ShowDialog();
            this.Close();
        }

        private void visitor_button_Click(object sender, EventArgs e)
        {
            decision_interface decision_interface_dialog = new decision_interface();
            decision.main_screen_option = "visitor";
            decision_interface_dialog.ShowDialog();
            this.Close();
        }

        private void main_interface_Load(object sender, EventArgs e)
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
    }
}
