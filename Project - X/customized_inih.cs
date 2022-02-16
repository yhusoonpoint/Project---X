using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
namespace Project___X
{
    class roundbutton : Button
    {
        public roundbutton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(grPath);
        }
    }
    class rounded_edge_button : Button
    {
        public rounded_edge_button()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            this.Region = new Region(GraphPath);
        }
    }
    class all_rounded_edge_picturebox : PictureBox
    {
        public all_rounded_edge_picturebox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 80, 80, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 80, Rect.Y, 80, 80, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 80, Rect.Y + Rect.Height - 80, 80, 80, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 80, 80, 80, 90, 90);
            this.Region = new Region(GraphPath);
        }
    }
    class all_rounded_edge_RichTextBox : RichTextBox
    {
        public all_rounded_edge_RichTextBox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 80, 80, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 80, Rect.Y, 80, 80, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 80, Rect.Y + Rect.Height - 80, 80, 80, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 80, 80, 80, 90, 90);
            this.Region = new Region(GraphPath);
        }
    }
    class rounded_edge_picturebox : PictureBox
    {
        public rounded_edge_picturebox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            var path = new GraphicsPath();
            Point[] points =
            {
                new Point( 10, 0),
                new Point(0, 10),
                new Point(0 , ClientSize.Height),
                new Point(ClientSize.Width, ClientSize.Height),
                new Point(ClientSize.Width, 10),
                new Point(ClientSize.Width - 10, 0)
            };
            path.AddPolygon(points);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);
        }
    }
    class curve_and_straight_edge_picturebox : PictureBox
    {
        public curve_and_straight_edge_picturebox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.FillMode = FillMode.Winding;

            int cut = 80;
            Rectangle cr = this.ClientRectangle;

            Point[] points =
                {
                new Point(0, cr.Height - cut),
                new Point(0, 0),
                new Point(cr.Width, 0),
                new Point(cr.Width, cr.Height - cut),
                new Point(cr.Width - cut, cr.Height),
                new Point(cut, cr.Height),
                new Point(0, cr.Height - cut),
                 };
            path.AddPolygon(points);

            Rectangle arcRect = new Rectangle(0, cr.Height - 2 * cut, 2 * cut, 2 * cut);
            path.AddArc(arcRect, 90f, 90f);
            this.Region = new Region(path);
        }
    }
    class curve_and_straight_edge_listbox : ListBox
    {
        public curve_and_straight_edge_listbox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.FillMode = FillMode.Winding;

            int cut = 80;
            Rectangle cr = this.ClientRectangle;

            Point[] points =
                {
                new Point(0, cr.Height - cut),
                new Point(0, 0),
                new Point(cr.Width, 0),
                new Point(cr.Width, cr.Height - cut),
                new Point(cr.Width - cut, cr.Height),
                new Point(cut, cr.Height),
                new Point(0, cr.Height - cut),
                 };
            path.AddPolygon(points);

            Rectangle arcRect = new Rectangle(0, cr.Height - 2 * cut, 2 * cut, 2 * cut);
            path.AddArc(arcRect, 90f, 90f);
            this.Region = new Region(path);
        }
    }
    class two_curve_edge_picturebox : PictureBox
    {
        public two_curve_edge_picturebox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.FillMode = FillMode.Winding;

            int cut = 30;
            Rectangle cr = this.ClientRectangle;

            Point[] points =
                {
                new Point(0, cr.Height),
                new Point(0, cut),
                new Point(cut, 0),
                new Point(cr.Width, 0),
                new Point(cr.Width, cr.Height - cut),
                new Point(cr.Width - cut, cr.Height),
                new Point(0, cr.Height),
                 };
            path.AddPolygon(points);

            // Rectangle arcRect = new Rectangle(0, cr.Height - 2 * cut, 2 * cut, 2 * cut);
            Rectangle arcRectTL = new Rectangle(0, 0, 2 * cut, 2 * cut);
            // Rectangle arcRectTR = new Rectangle(cr.Width - 2 * cut, 0, 2 * cut, 2 * cut);
            Rectangle arcRectBR = new Rectangle(cr.Width - 2 * cut, cr.Height - 2 * cut, 2 * cut, 2 * cut);
            // path.AddArc(arcRect, 90f, 90f);
            path.AddArc(arcRectTL, 180f, 90f);
            // path.AddArc(arcRectTR, 90f, 90f);
            path.AddArc(arcRectBR, 360f, 90f);
            this.Region = new Region(path);


        }
    }
    class two_curve_edge_button : Button
    {
        public two_curve_edge_button()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.FillMode = FillMode.Winding;

            int cut = 10;
            Rectangle cr = this.ClientRectangle;

            Point[] points =
                {
                new Point(0, cr.Height),
                new Point(0, cut),
                new Point(cut, 0),
                new Point(cr.Width, 0),
                new Point(cr.Width, cr.Height - cut),
                new Point(cr.Width - cut, cr.Height),
                new Point(0, cr.Height),
                 };
            path.AddPolygon(points);

            // Rectangle arcRect = new Rectangle(0, cr.Height - 2 * cut, 2 * cut, 2 * cut);
            Rectangle arcRectTL = new Rectangle(0, 0, 2 * cut, 2 * cut);
            // Rectangle arcRectTR = new Rectangle(cr.Width - 2 * cut, 0, 2 * cut, 2 * cut);
            Rectangle arcRectBR = new Rectangle(cr.Width - 2 * cut, cr.Height - 2 * cut, 2 * cut, 2 * cut);
            // path.AddArc(arcRect, 90f, 90f);
            path.AddArc(arcRectTL, 180f, 90f);
            // path.AddArc(arcRectTR, 90f, 90f);
            path.AddArc(arcRectBR, 360f, 90f);
            this.Region = new Region(path);


        }
    }
    class two_curve_edge_label : Label
    {
        public two_curve_edge_label()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.FillMode = FillMode.Winding;

            int cut = 10;
            Rectangle cr = this.ClientRectangle;

            Point[] points =
                {
                new Point(0, cr.Height),
                new Point(0, cut),
                new Point(cut, 0),
                new Point(cr.Width, 0),
                new Point(cr.Width, cr.Height - cut),
                new Point(cr.Width - cut, cr.Height),
                new Point(0, cr.Height),
                 };
            path.AddPolygon(points);

            // Rectangle arcRect = new Rectangle(0, cr.Height - 2 * cut, 2 * cut, 2 * cut);
            Rectangle arcRectTL = new Rectangle(0, 0, 2 * cut, 2 * cut);
            // Rectangle arcRectTR = new Rectangle(cr.Width - 2 * cut, 0, 2 * cut, 2 * cut);
            Rectangle arcRectBR = new Rectangle(cr.Width - 2 * cut, cr.Height - 2 * cut, 2 * cut, 2 * cut);
            // path.AddArc(arcRect, 90f, 90f);
            path.AddArc(arcRectTL, 180f, 90f);
            // path.AddArc(arcRectTR, 90f, 90f);
            path.AddArc(arcRectBR, 360f, 90f);
            this.Region = new Region(path);


        }
    }           
    class straight__line_edge_button : Button
    {
        public straight__line_edge_button()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            var path = new GraphicsPath();
            Point[] points =
            {
                new Point( 0, 0),
                new Point(0, ClientSize.Height - 10),
                new Point(10, ClientSize.Height),
                new Point(ClientSize.Width, ClientSize.Height),
                new Point(ClientSize.Width, 10),
                new Point(ClientSize.Width - 10, 0)
            };
            path.AddPolygon(points);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);
        }
    }
    class straight__line_edge_picturebox: PictureBox
    {
        public straight__line_edge_picturebox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            var path = new GraphicsPath();
            Point[] points =
            {
                new Point( 0, 0),
                new Point(0, ClientSize.Height - 10),
                new Point(10, ClientSize.Height),
                new Point(ClientSize.Width, ClientSize.Height),
                new Point(ClientSize.Width, 10),
                new Point(ClientSize.Width - 10, 0)
            };
            path.AddPolygon(points);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);
        }
    }
    class arrow_head_picturebox : PictureBox
    {
        public arrow_head_picturebox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            var path = new GraphicsPath();
            Point[] points =
            {
                new Point( 0, 0),
                new Point(ClientSize.Width/2, ClientSize.Height /2),
                new Point(0, ClientSize.Height),
                new Point(ClientSize.Width/2, ClientSize.Height),
                new Point(ClientSize.Width, ClientSize.Height/2),
                new Point(ClientSize.Width /2, 0)
            };
            path.AddPolygon(points);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);
        }
    }
    class rounded_edge_label : Label
    {
        public rounded_edge_label()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            var path = new GraphicsPath();
            Point[] points =
            {
                new Point( 0, 0),
                new Point(0, ClientSize.Height - 10),
                new Point(10, ClientSize.Height),
                new Point(ClientSize.Width, ClientSize.Height),
                new Point(ClientSize.Width, 10),
                new Point(ClientSize.Width - 10, 0)
            };
            path.AddPolygon(points);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);
        }
    }
    class triangle_picturebox : PictureBox
    {
        public triangle_picturebox()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Size = new Size(100, 100);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.UpdateRegion();
            base.OnPaint(pevent);
        }
        protected void UpdateRegion()
        {
            var path = new GraphicsPath();
            Point[] points =
            {
                new Point(ClientSize.Width-2, 0),
                new Point((ClientSize.Width/2)- 20, (ClientSize.Height /2 )-20),
                new Point(0, ClientSize.Height),
            };
            path.AddPolygon(points);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);
        }
    }
}
