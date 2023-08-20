using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rec_inven_samp
{
    public partial class add_test : Form
    {
        db_con con = new db_con();

        public string test_text
        {
            get => textBox1.Text; set => textBox1.Text = value;
        }
        public string categ_text
        {
            get => cmb_categ.Text; set => cmb_categ.Text = value;
        }
        public string categ_value
        {
            get => s_categ; set => s_categ = value;
        }
        public string series_text
        {
            get => cmb_series.Text; set => cmb_series.Text = value;
        }
        public string series_value
        {
            get => s_series; set => s_series = value;
        }

        private string s_categ = null;
        private string s_series = null;

        private bool ch_cmb = false;
        private bool ch_txt = false; //--- not used yet
        private bool ch_grp_encoder = false;
        private bool ch_grp_series = false;

        public add_test()
        {
            InitializeComponent();

            //this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;

            fill_cmb();
            cmb_categ.SelectedIndex = -1;
            cmb_series.SelectedIndex = -1;
            cmb_office.SelectedIndex = -1;
            cmb_util.SelectedIndex = -1;

            //dtp_start.Value = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //_checker();
            //_check2(this.Controls);
            _check3();

            if (ch_grp_encoder == true && ch_grp_series == true)
            {
                s_categ = cmb_categ.SelectedValue.ToString();
                s_series = cmb_series.SelectedValue.ToString();

                MessageBox.Show(categ_text + " - " + categ_value + "\n" +
                               series_text + " - " + series_value);

                button1.Enabled = true;
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

                    cmb_util.DataSource = con.ds.Tables[0];
                    cmb_util.ValueMember = "util_code";
                    cmb_util.DisplayMember = "util_value";
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

            txt_time.Text = null;
            txt_rds_id.Text = null;
            cmb_util.SelectedIndex = -1;

            cmb_series_fill();
        }

        private void cmb_series_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //--- time value
                if (cmb_series.SelectedValue != null)
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
                                txt_time.Text = "TEMPORARY";
                                break;

                            case "p":
                            case "P":
                                txt_time.Text = "PERMANENT";
                                break;
                        }

                        txt_rds_id.Text = cmb_series.SelectedValue.ToString();
                        cmb_util.SelectedIndex = -1;
                    }
                    con.mycon.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _check3()
        {
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
                _check4();
            }
        }

        private void _check4()
        {
            foreach (Control c in grp_series.Controls.Cast<Control>().OrderBy(x => x.TabIndex))
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

        private void _check2(Control.ControlCollection cn)
        {//--- simultaneous selection
            foreach (Control con in cn)
            {
                if (con.HasChildren)
                {
                    _check2(con.Controls);
                }
                else
                {
                    if (con is ComboBox)
                    {
                        if (string.IsNullOrEmpty(con.Text))
                        {
                            MessageBox.Show(con.Name + " is empty");
                            con.Select();
                            ch_cmb = false;
                            break;
                        }
                        else
                        {
                            ch_cmb = true;
                        }
                    }
                }
            }
        }

        private void _checker()
        {
            foreach (var c in Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<ComboBox>().OrderBy(c => c.TabIndex)))
            {
                if (string.IsNullOrEmpty(c.Text))
                {
                    MessageBox.Show(c.Name + " is empty");
                    c.Select();
                    ch_cmb = false;
                    break;
                }
                else
                {
                    ch_cmb = true;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
