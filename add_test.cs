using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rec_inven_samp
{
    public partial class add_test : Form
    {
        db_con con = new db_con();

        public string categ_text
        {
            get => cmb_categ.Text; set => cmb_categ.Text = value;
        }
        public string series_text
        {
            get => cmb_series.Text; set => cmb_series.Text = value;
        }

        private bool ch_grp_encoder = false;
        private bool ch_grp_series = false;
        private bool ch_grp_period = false;

        public add_test()
        {
            InitializeComponent();

            lbl_dt.Text = DateTime.Now.ToString("yyyy, MMMM dd" + "\n" + "hh:mm:ss tt");
            _dt_timer();

            fill_cmb();
            cmb_categ.SelectedIndex = -1;
            cmb_series.SelectedIndex = -1;
            cmb_office.SelectedIndex = -1;
            cmb_util_val.SelectedIndex = -1;
        }

        private void _dt_timer()
        {
            Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(_dt_timer_tick);
            timer1.Enabled = true;
        }

        private void _dt_timer_tick(object sender, EventArgs e)
        {
            lbl_dt.Text = DateTime.Now.ToString("yyyy, MMMM dd" + "\n" + "hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _check1();

            if (ch_grp_encoder == true && ch_grp_series == true && ch_grp_period == true)
            {
                save_entry();
            }
        }

        private void save_entry()
        {
            //--- encoder details
            string s_encoder = txt_name.Text;
            string s_office = cmb_office.SelectedValue.ToString();

            string s_date = Convert.ToDateTime(lbl_dt.Text).ToString();

            //--- records series details
            string s_rds_id = txt_rds_id.Text;

            string s_location = txt_location.Text;
            string s_volume = txt_vol.Text;
            string s_utility = cmb_util_val.Text;
            string s_use_frequency = txt_use_freq.Text;
            string s_duplication = txt_dup.Text;

            string s_start_period = dtp_start.Value.ToShortDateString();
            string s_end_period = dtp_end.Value.ToShortDateString();

            //--- not needed ???
            string s_category = cmb_categ.Text;
            string s_series = cmb_series.Text;
            string s_add_info = txt_add_info.Text;
            string s_time_value = txt_time_val.Text;

            try
            {
                string sql1 = "insert into test_nap1_div(rds_id, office_code, record_loc, vol_cubic_meter," +
                                " utility_value, use_frequency, duplication, period_start, period_end," +
                                " submit_name, submit_date) values ('" + s_rds_id + "', '" + s_office + "', '" + s_location + "', '" + s_volume + "'," +
                                " '" + s_utility + "', '" + s_use_frequency + "', '" + s_duplication + "', str_to_date('" + s_start_period + "', '%d/%m/%Y')," +
                                " str_to_date('" + s_end_period + "', '%d/%m/%Y'), '" + s_encoder + "', str_to_date('" + s_date + "', '%d/%m/%Y %I:%i:%s %p'))";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    int a = con.cmd.ExecuteNonQuery();

                    if (a == 0)
                    {
                        //--- update failed
                        MessageBox.Show("please check query");
                    }
                    else
                    {
                        //--- update success
                        MessageBox.Show("SUCCESS!");

                        _clear();
                    }
                }
                con.mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _clear()
        {
            foreach (Control c1 in grp_encoder.Controls)
            {
                if (c1 is TextBox)
                {
                    TextBox txtbox = (TextBox)c1;
                    txtbox.Text = null;
                }
                else if (c1 is ComboBox)
                {
                    ComboBox cmbox = (ComboBox)c1;
                    cmbox.SelectedIndex = -1;
                }
            }

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
                //--- office
                string sql1 = "select * from list_office;";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);

                    cmb_office.DataSource = con.ds.Tables[0];
                    cmb_office.ValueMember = "office_code";
                    cmb_office.DisplayMember = "office_short";
                }
                con.mycon.Close();

                //--- category
                string sql2 = "select * from rds_category order by category asc;";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql2, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);

                    cmb_categ.DataSource = con.ds.Tables[0];
                    cmb_categ.ValueMember = "idrds_category";
                    cmb_categ.DisplayMember = "category";
                }
                con.mycon.Close();

                //--- utility value
                string sql3 = "select * from rds_util_value;";

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
                string sql1 = "select time_value from rds_list where rds_id = '" + cmb_series.SelectedValue + "';";

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
                string sql2 = "select add_info from rds_list where rds_id = '" + cmb_series.SelectedValue + "';";

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

        private void _check1()
        {//--- for encoder details
            foreach (Control c in grp_encoder.Controls.Cast<Control>().OrderBy(x => x.TabIndex))
            {
                if (string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show(c.Name + " is empty");
                    c.Select();
                    ch_grp_encoder = false;
                    break;
                }
                else
                {
                    ch_grp_encoder = true;
                }
            }

            if (ch_grp_encoder == true)
            {
                _check2();
            }
        }

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
                    string sql3 = "select rds_id, item_name from rds_list where category_id = '" + cmb_categ.SelectedValue + "' order by item_name asc;";

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
