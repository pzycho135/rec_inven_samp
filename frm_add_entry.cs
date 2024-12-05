using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//sample

namespace rec_inven_samp
{
    public partial class frm_add_entry : Form
    {
        db_con con = new db_con();

        public string rds_id
        {
            get => txt_rds_id.Text; set => txt_rds_id.Text = value;
        }
        public string rec_series
        {
            get => cmb_series.Text; set => cmb_series.Text = value;
        }
        public string location
        {
            get => txt_location.Text; set => txt_location.Text = value;
        }
        public string volume
        {
            get => txt_vol.Text; set => txt_vol.Text = value;
        }
        public string time_val
        {
            get => txt_time_val.Text; set => txt_time_val.Text = value;
        }
        public string util_val
        {
            get => cmb_util_val.Text; set => cmb_util_val.Text = value;
        }
        public string use_freq
        {
            get => txt_use_freq.Text; set => txt_use_freq.Text = value;
        }
        public string duplication
        {
            get => txt_dup.Text; set => txt_dup.Text = value;
        }
        public string period_start
        {
            get; set;
        }
        public string period_end
        {
            get; set;
        }

        private bool ch_grp_encoder = true; //--- delete this
        private bool ch_grp_series = false;
        private bool ch_grp_period = false;

        private string datetime_format = "dd/MM/yyyy hh:mm:ss tt";
        private string date_format = "dd/MM/yyyy";

        public frm_add_entry()
        {
            InitializeComponent();

            fill_cmb();
            cmb_categ.SelectedIndex = -1;
            cmb_series.SelectedIndex = -1;
            cmb_util_val.SelectedIndex = -1;

            dtp_start.MaxDate = DateTime.Now;
            dtp_end.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save_entry();
        }

        private void save_entry()
        {
            _check2();

            string s_start_period = dtp_start.Value.ToString(date_format);
            string s_end_period = dtp_end.Value.ToString(date_format);

            period_start = s_start_period;
            period_end = s_end_period;

            if (ch_grp_encoder == true && ch_grp_series == true && ch_grp_period == true)
            {
                //save_entry();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void _clear()
        {
            foreach (Control c2 in grp_series.Controls)
            {
                if (c2 is TextBox)
                {
                    TextBox txtbox = (TextBox)c2;
                    txtbox.Text = null;
                }
                else if (c2 is ComboBox)
                {
                    ComboBox cmbox = (ComboBox)c2;
                    cmbox.SelectedIndex = -1;
                }
                else if (c2 is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)c2;
                    chkbox.Checked = false;
                }
            }

            foreach (Control c3 in grp_period.Controls)
            {
                if (c3 is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c3;
                    dtp.Value = DateTime.Now;
                    dtp.Checked = false;
                }
            }
        }

        private void fill_cmb()
        {
            try
            {
                //--- category
                string sql2 = "select * from " + con.rds_categ_table + " order by category asc;";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql2, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);

                    cmb_categ.DataSource = con.ds.Tables[0];
                    cmb_categ.ValueMember = "category_id";
                    cmb_categ.DisplayMember = "category";
                }
                con.mycon.Close();

                //--- utility value
                string sql3 = "select * from " + con.rds_util_table;

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql3, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);

                    cmb_util_val.DataSource = con.ds.Tables[0];
                    cmb_util_val.ValueMember = "util_code";
                    cmb_util_val.DisplayMember = "util_value";
                }
                con.mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_categ_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_series.DataSource = null;
            cmb_series.Items.Clear();

            txt_rds_id.Text = null;
            txt_add_info.Text = null;
            txt_time_val.Text = null;

            txt_location.Text = null;
            txt_vol.Text = null;
            txt_use_freq.Text = null;
            txt_dup.Text = null;

            cmb_util_val.SelectedIndex = -1;

            dtp_start.Checked = false;
            dtp_end.Checked = false;
            chb_no_time_val.Checked = false;

            cmb_series_fill();
        }

        private void _time_value()
        {//--- time value
            try
            {
                string sql1 = "select time_value from " + con.rds_table + " where rds_id = '" + cmb_series.SelectedValue + "';";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    string t = con.cmd.ExecuteScalar().ToString();

                    switch (t)
                    {
                        case "t":
                        case "T":
                            txt_time_val.Text = "TEMPORARY";
                            chb_no_time_val.Checked = false;
                            break;

                        case "p":
                        case "P":
                            txt_time_val.Text = "PERMANENT";
                            chb_no_time_val.Checked = false;
                            break;

                        case "":
                            txt_time_val.Text = null;
                            chb_no_time_val.Checked = true;
                            break;
                    }
                }
                con.mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _add_info()
        {//--- additional info
            try
            {
                string sql2 = "select add_info from " + con.rds_table + " where rds_id = '" + cmb_series.SelectedValue + "';";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql2, con.mycon))
                {
                    string t = con.cmd.ExecuteScalar().ToString();

                    if (t is null || t == "")
                    {
                        txt_add_info.Text = "-- NONE --";
                    }
                    else
                    {
                        txt_add_info.Text = t;
                    }
                }
                con.mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_series_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_series.SelectedValue != null)
            {
                _time_value();
                _add_info();

                txt_rds_id.Text = cmb_series.SelectedValue.ToString();

                txt_location.Text = null;
                txt_vol.Text = null;
                txt_use_freq.Text = null;
                txt_dup.Text = null;

                cmb_util_val.SelectedIndex = -1;

                dtp_start.Checked = false;
                dtp_end.Checked = false;
            }
        }

        //--- set as 1st checker
        private void _check2()
        {//--- for records series details
            foreach (Control c in grp_series.Controls.Cast<Control>().OrderBy(x => x.TabIndex))
            {
                if(c.Name != "txt_rds_id" && c.Name != "txt_add_info" && c.Name != "txt_time_val" && c.Name != "chb_no_time_val")
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        MessageBox.Show(c.Name + " is empty");
                        c.Select();
                        ch_grp_series = false;
                        break;
                    }
                    else
                    {
                        ch_grp_series = true;
                    }
                }
            }

            if (ch_grp_encoder == true && ch_grp_series == true)
            {
                _check3();
            }
        }

        private void _check3()
        {//--- for start date & end date of records series
            foreach (var c in grp_period.Controls.OfType<DateTimePicker>().OrderBy(x => x.TabIndex))
            {
                if (c.Checked == false)
                {
                    MessageBox.Show(c.Name + " is empty");
                    c.Select();
                    ch_grp_period = false;
                    break;
                }
                else
                {
                    ch_grp_period = true;
                }
            }
        }

        private void cmb_series_fill()
        {
            try
            {
                //--- records series
                if (cmb_categ.SelectedValue != null)
                {
                    string sql3 = "select rds_id, item_name from " + con.rds_table + " where category_id = '" + cmb_categ.SelectedValue + "' order by item_name asc;";

                    con.mycon.Open();
                    using (con.cmd = new MySqlCommand(sql3, con.mycon))
                    {
                        con.adapter = new MySqlDataAdapter(con.cmd);
                        con.ds = new DataSet();
                        con.adapter.Fill(con.ds);

                        cmb_series.DataSource = con.ds.Tables[0];
                        cmb_series.ValueMember = "rds_id";
                        cmb_series.DisplayMember = "item_name";
                    }
                    con.mycon.Close();
                    cmb_series.SelectedIndex = -1;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
