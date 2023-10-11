
namespace rec_inven_samp
{
    partial class frm_add_entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_categ = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_series = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rds_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_vol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_use_freq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_dup = new System.Windows.Forms.TextBox();
            this.grp_series = new System.Windows.Forms.GroupBox();
            this.txt_add_info = new System.Windows.Forms.TextBox();
            this.chb_no_time_val = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_util_val = new System.Windows.Forms.ComboBox();
            this.grp_period = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_time_val = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grp_series.SuspendLayout();
            this.grp_period.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.button1.Location = new System.Drawing.Point(743, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_categ
            // 
            this.cmb_categ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_categ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_categ.DropDownHeight = 150;
            this.cmb_categ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.cmb_categ.FormattingEnabled = true;
            this.cmb_categ.IntegralHeight = false;
            this.cmb_categ.Location = new System.Drawing.Point(142, 66);
            this.cmb_categ.Name = "cmb_categ";
            this.cmb_categ.Size = new System.Drawing.Size(854, 29);
            this.cmb_categ.TabIndex = 2;
            this.cmb_categ.SelectionChangeCommitted += new System.EventHandler(this.cmb_categ_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Records Series:";
            // 
            // cmb_series
            // 
            this.cmb_series.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_series.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_series.DropDownHeight = 150;
            this.cmb_series.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_series.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.cmb_series.FormattingEnabled = true;
            this.cmb_series.IntegralHeight = false;
            this.cmb_series.ItemHeight = 21;
            this.cmb_series.Location = new System.Drawing.Point(142, 101);
            this.cmb_series.Name = "cmb_series";
            this.cmb_series.Size = new System.Drawing.Size(854, 29);
            this.cmb_series.TabIndex = 3;
            this.cmb_series.SelectionChangeCommitted += new System.EventHandler(this.cmb_series_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "RDS / GRDS ID:";
            // 
            // txt_rds_id
            // 
            this.txt_rds_id.BackColor = System.Drawing.Color.White;
            this.txt_rds_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.txt_rds_id.Location = new System.Drawing.Point(142, 25);
            this.txt_rds_id.MaxLength = 10;
            this.txt_rds_id.Name = "txt_rds_id";
            this.txt_rds_id.ReadOnly = true;
            this.txt_rds_id.Size = new System.Drawing.Size(126, 26);
            this.txt_rds_id.TabIndex = 1;
            this.txt_rds_id.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Volume in Cubic Meter:";
            // 
            // txt_location
            // 
            this.txt_location.BackColor = System.Drawing.Color.White;
            this.txt_location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.txt_location.Location = new System.Drawing.Point(141, 269);
            this.txt_location.MaxLength = 100;
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(410, 26);
            this.txt_location.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Location:";
            // 
            // txt_vol
            // 
            this.txt_vol.BackColor = System.Drawing.Color.White;
            this.txt_vol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.txt_vol.Location = new System.Drawing.Point(198, 314);
            this.txt_vol.MaxLength = 100;
            this.txt_vol.Name = "txt_vol";
            this.txt_vol.Size = new System.Drawing.Size(353, 26);
            this.txt_vol.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(593, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Use Frequency:";
            // 
            // txt_use_freq
            // 
            this.txt_use_freq.BackColor = System.Drawing.Color.White;
            this.txt_use_freq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.txt_use_freq.Location = new System.Drawing.Point(720, 294);
            this.txt_use_freq.MaxLength = 10;
            this.txt_use_freq.Name = "txt_use_freq";
            this.txt_use_freq.Size = new System.Drawing.Size(276, 26);
            this.txt_use_freq.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(593, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Duplication:";
            // 
            // txt_dup
            // 
            this.txt_dup.BackColor = System.Drawing.Color.White;
            this.txt_dup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.txt_dup.Location = new System.Drawing.Point(720, 334);
            this.txt_dup.MaxLength = 100;
            this.txt_dup.Name = "txt_dup";
            this.txt_dup.Size = new System.Drawing.Size(276, 26);
            this.txt_dup.TabIndex = 9;
            // 
            // grp_series
            // 
            this.grp_series.Controls.Add(this.txt_add_info);
            this.grp_series.Controls.Add(this.chb_no_time_val);
            this.grp_series.Controls.Add(this.label14);
            this.grp_series.Controls.Add(this.label13);
            this.grp_series.Controls.Add(this.cmb_util_val);
            this.grp_series.Controls.Add(this.grp_period);
            this.grp_series.Controls.Add(this.txt_rds_id);
            this.grp_series.Controls.Add(this.label1);
            this.grp_series.Controls.Add(this.label2);
            this.grp_series.Controls.Add(this.txt_dup);
            this.grp_series.Controls.Add(this.label15);
            this.grp_series.Controls.Add(this.label8);
            this.grp_series.Controls.Add(this.label3);
            this.grp_series.Controls.Add(this.txt_use_freq);
            this.grp_series.Controls.Add(this.cmb_categ);
            this.grp_series.Controls.Add(this.txt_time_val);
            this.grp_series.Controls.Add(this.txt_vol);
            this.grp_series.Controls.Add(this.cmb_series);
            this.grp_series.Controls.Add(this.txt_location);
            this.grp_series.Controls.Add(this.label10);
            this.grp_series.Controls.Add(this.label7);
            this.grp_series.Controls.Add(this.label9);
            this.grp_series.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_series.Location = new System.Drawing.Point(12, 12);
            this.grp_series.Name = "grp_series";
            this.grp_series.Size = new System.Drawing.Size(1019, 431);
            this.grp_series.TabIndex = 2;
            this.grp_series.TabStop = false;
            this.grp_series.Text = "Records Series Details";
            // 
            // txt_add_info
            // 
            this.txt_add_info.BackColor = System.Drawing.Color.White;
            this.txt_add_info.Location = new System.Drawing.Point(59, 170);
            this.txt_add_info.Multiline = true;
            this.txt_add_info.Name = "txt_add_info";
            this.txt_add_info.ReadOnly = true;
            this.txt_add_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_add_info.Size = new System.Drawing.Size(537, 81);
            this.txt_add_info.TabIndex = 11;
            // 
            // chb_no_time_val
            // 
            this.chb_no_time_val.AutoSize = true;
            this.chb_no_time_val.Enabled = false;
            this.chb_no_time_val.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_no_time_val.Location = new System.Drawing.Point(370, 361);
            this.chb_no_time_val.Name = "chb_no_time_val";
            this.chb_no_time_val.Size = new System.Drawing.Size(139, 21);
            this.chb_no_time_val.TabIndex = 10;
            this.chb_no_time_val.TabStop = false;
            this.chb_no_time_val.Text = "Not Applicable";
            this.chb_no_time_val.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 402);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Utility Value:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 362);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Time Value:";
            // 
            // cmb_util_val
            // 
            this.cmb_util_val.BackColor = System.Drawing.Color.White;
            this.cmb_util_val.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_util_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.cmb_util_val.FormattingEnabled = true;
            this.cmb_util_val.Location = new System.Drawing.Point(141, 396);
            this.cmb_util_val.Name = "cmb_util_val";
            this.cmb_util_val.Size = new System.Drawing.Size(223, 29);
            this.cmb_util_val.TabIndex = 7;
            // 
            // grp_period
            // 
            this.grp_period.Controls.Add(this.label11);
            this.grp_period.Controls.Add(this.label6);
            this.grp_period.Controls.Add(this.dtp_end);
            this.grp_period.Controls.Add(this.dtp_start);
            this.grp_period.Location = new System.Drawing.Point(676, 150);
            this.grp_period.Name = "grp_period";
            this.grp_period.Size = new System.Drawing.Size(320, 105);
            this.grp_period.TabIndex = 7;
            this.grp_period.TabStop = false;
            this.grp_period.Text = "Period Covered";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "From:";
            // 
            // dtp_end
            // 
            this.dtp_end.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.dtp_end.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.dtp_end.Checked = false;
            this.dtp_end.CustomFormat = "yyyy, MMM dd";
            this.dtp_end.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(86, 70);
            this.dtp_end.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.ShowCheckBox = true;
            this.dtp_end.Size = new System.Drawing.Size(200, 25);
            this.dtp_end.TabIndex = 2;
            this.dtp_end.TabStop = false;
            this.dtp_end.Value = new System.DateTime(2023, 8, 15, 15, 20, 21, 0);
            // 
            // dtp_start
            // 
            this.dtp_start.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.dtp_start.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.dtp_start.Checked = false;
            this.dtp_start.CustomFormat = "yyyy, MMM dd";
            this.dtp_start.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(86, 25);
            this.dtp_start.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.ShowCheckBox = true;
            this.dtp_start.Size = new System.Drawing.Size(200, 25);
            this.dtp_start.TabIndex = 1;
            this.dtp_start.TabStop = false;
            this.dtp_start.Value = new System.DateTime(2023, 8, 15, 15, 20, 21, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 150);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Additional Inormation:";
            // 
            // txt_time_val
            // 
            this.txt_time_val.BackColor = System.Drawing.Color.White;
            this.txt_time_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.txt_time_val.Location = new System.Drawing.Point(141, 356);
            this.txt_time_val.MaxLength = 50;
            this.txt_time_val.Name = "txt_time_val";
            this.txt_time_val.ReadOnly = true;
            this.txt_time_val.Size = new System.Drawing.Size(223, 26);
            this.txt_time_val.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(924, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_add_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grp_series);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entry";
            this.grp_series.ResumeLayout(false);
            this.grp_series.PerformLayout();
            this.grp_period.ResumeLayout(false);
            this.grp_period.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_categ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_series;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rds_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_vol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_use_freq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_dup;
        private System.Windows.Forms.GroupBox grp_series;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.GroupBox grp_period;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_util_val;
        private System.Windows.Forms.TextBox txt_time_val;
        private System.Windows.Forms.CheckBox chb_no_time_val;
        private System.Windows.Forms.TextBox txt_add_info;
        private System.Windows.Forms.Label label15;
    }
}