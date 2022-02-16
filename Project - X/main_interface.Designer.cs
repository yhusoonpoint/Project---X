namespace Project___X
{
    partial class main_interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.fade_in_timer = new System.Windows.Forms.Timer(this.components);
            this.time_timer = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rounded_edge_label2 = new Project___X.rounded_edge_label();
            this.time_and_date_label = new Project___X.rounded_edge_label();
            this.rounded_edge_picturebox1 = new Project___X.rounded_edge_picturebox();
            this.swipe_button = new Project___X.rounded_edge_button();
            this.visitor_button = new Project___X.rounded_edge_button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rounded_edge_picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(679, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 120);
            this.label1.TabIndex = 5;
            this.label1.Text = "OR";
            // 
            // fade_in_timer
            // 
            this.fade_in_timer.Interval = 1;
            this.fade_in_timer.Tick += new System.EventHandler(this.fade_in_timer_Tick);
            // 
            // time_timer
            // 
            this.time_timer.Enabled = true;
            this.time_timer.Interval = 1000;
            this.time_timer.Tick += new System.EventHandler(this.time_timer_Tick);
            // 
            // rounded_edge_label2
            // 
            this.rounded_edge_label2.AutoSize = true;
            this.rounded_edge_label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.rounded_edge_label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rounded_edge_label2.Location = new System.Drawing.Point(28, 24);
            this.rounded_edge_label2.MinimumSize = new System.Drawing.Size(100, 63);
            this.rounded_edge_label2.Name = "rounded_edge_label2";
            this.rounded_edge_label2.Size = new System.Drawing.Size(100, 63);
            this.rounded_edge_label2.TabIndex = 13;
            this.rounded_edge_label2.Text = "LOGO";
            this.rounded_edge_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_and_date_label
            // 
            this.time_and_date_label.AutoSize = true;
            this.time_and_date_label.BackColor = System.Drawing.Color.RoyalBlue;
            this.time_and_date_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.time_and_date_label.Location = new System.Drawing.Point(1475, 23);
            this.time_and_date_label.MinimumSize = new System.Drawing.Size(100, 63);
            this.time_and_date_label.Name = "time_and_date_label";
            this.time_and_date_label.Size = new System.Drawing.Size(100, 63);
            this.time_and_date_label.TabIndex = 12;
            this.time_and_date_label.Text = "TIME\r\nDATE";
            this.time_and_date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rounded_edge_picturebox1
            // 
            this.rounded_edge_picturebox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.rounded_edge_picturebox1.Location = new System.Drawing.Point(12, 12);
            this.rounded_edge_picturebox1.Name = "rounded_edge_picturebox1";
            this.rounded_edge_picturebox1.Size = new System.Drawing.Size(1576, 88);
            this.rounded_edge_picturebox1.TabIndex = 11;
            this.rounded_edge_picturebox1.TabStop = false;
            // 
            // swipe_button
            // 
            this.swipe_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.swipe_button.FlatAppearance.BorderSize = 0;
            this.swipe_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swipe_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.swipe_button.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.swipe_button.Location = new System.Drawing.Point(963, 370);
            this.swipe_button.Name = "swipe_button";
            this.swipe_button.Size = new System.Drawing.Size(300, 300);
            this.swipe_button.TabIndex = 1;
            this.swipe_button.Text = "PRESS TO SWIPE YOUR CARD";
            this.swipe_button.UseVisualStyleBackColor = false;
            this.swipe_button.Click += new System.EventHandler(this.swipe_button_Click);
            // 
            // visitor_button
            // 
            this.visitor_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.visitor_button.FlatAppearance.BorderSize = 0;
            this.visitor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.visitor_button.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.visitor_button.Location = new System.Drawing.Point(310, 370);
            this.visitor_button.Name = "visitor_button";
            this.visitor_button.Size = new System.Drawing.Size(300, 300);
            this.visitor_button.TabIndex = 0;
            this.visitor_button.Text = "TOUCH HERE TO LEARN MORE ABOUT GREENWICH UTC";
            this.visitor_button.UseVisualStyleBackColor = false;
            this.visitor_button.Click += new System.EventHandler(this.visitor_button_Click);
            // 
            // main_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::Project___X.Properties.Resources.bb_image;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.rounded_edge_label2);
            this.Controls.Add(this.time_and_date_label);
            this.Controls.Add(this.rounded_edge_picturebox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swipe_button);
            this.Controls.Add(this.visitor_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.main_interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rounded_edge_picturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rounded_edge_button visitor_button;
        private rounded_edge_button swipe_button;
        private System.Windows.Forms.Label label1;
        private rounded_edge_label rounded_edge_label2;
        private rounded_edge_label time_and_date_label;
        private rounded_edge_picturebox rounded_edge_picturebox1;
        private System.Windows.Forms.Timer fade_in_timer;
        private System.Windows.Forms.Timer time_timer;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}

