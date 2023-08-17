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

        private bool ch = false;

        public add_test()
        {
            InitializeComponent();

            //this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;

            fill_cmb();
            cmb_categ.SelectedIndex = -1;
            cmb_series.SelectedIndex = -1;
            cmb_office.SelectedIndex = -1;
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
                string sql2 = "select * from rds_grds_category order by category asc;";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql2, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);

                    cmb_categ.DataSource = con.ds.Tables[0];
                    cmb_categ.ValueMember = "idrds_grds_category";
                    cmb_categ.DisplayMember = "category";
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

            cmb_series_fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _checker();

            if (ch == true)
            {
                s_categ = cmb_categ.SelectedValue.ToString();
                s_series = cmb_series.SelectedValue.ToString();

                MessageBox.Show(categ_text + " - " + categ_value + "\n" +
                               series_text + " - " + series_value);

                button1.Enabled = true;
            }
        }

        private void _checker()
        {
            foreach (var c in Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<ComboBox>()))
            {
                if (string.IsNullOrEmpty(c.Text))
                {
                    MessageBox.Show(c.Name + " is empty");
                    c.Select();
                    ch = false;
                    break;
                }
                else
                {
                    ch = true;
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
                    string sql3 = "select rds_grds_id, item_name from rds_grds_list where category_id = '" + cmb_categ.SelectedValue + "' order by item_name asc;";

                    con.mycon.Open();
                    using (con.cmd = new MySqlCommand(sql3, con.mycon))
                    {
                        con.adapter = new MySqlDataAdapter(con.cmd);
                        con.ds = new DataSet();
                        con.adapter.Fill(con.ds);

                        cmb_series.DataSource = con.ds.Tables[0];
                        cmb_series.ValueMember = "rds_grds_id";
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
