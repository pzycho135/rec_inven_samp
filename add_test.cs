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

        public add_test()
        {
            InitializeComponent();

            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;

            fill_cmb();
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
                    //con.adapter = new MySqlDataAdapter(con.cmd);
                    //con.ds = new DataSet();
                    //con.adapter.Fill(con.ds);

                    MySqlDataReader drd = con.cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        comboBox3.Items.Add(drd[2].ToString()); //--- column office_short
                        comboBox3.ValueMember = drd[3].ToString(); //--- column office_code
                        comboBox3.DisplayMember = drd[2].ToString();
                    }
                }
                con.mycon.Close();

                //--- category
                string sql2 = "select * from rds_grds_category;";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql2, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);

                    comboBox1.ValueMember = "idrds_grds_category";
                    comboBox1.DisplayMember = "category";
                    comboBox1.DataSource = con.ds.Tables[0];
                    comboBox1.BindingContext = this.BindingContext;

                    /*
                    MySqlDataReader drd = con.cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        comboBox1.Items.Add(drd[1].ToString());
                        comboBox1.ValueMember = drd[0].ToString();
                        comboBox1.DisplayMember = drd[1].ToString();
                    }*/
                }
                con.mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString() + '\n' + comboBox1.SelectedValue.ToString()); //--- still not working properly

            /*
            try
            {
                //--- records series
                if (comboBox1.SelectedValue != null)
                {
                    string sql3 = "select id, item_name from rds_grds_list where category_id = '5';";

                    con.mycon.Open();
                    using (con.cmd = new MySqlCommand(sql3, con.mycon))
                    {
                        //con.adapter = new MySqlDataAdapter(con.cmd);
                        //con.ds = new DataSet();
                        //con.adapter.Fill(con.ds);

                        MySqlDataReader drd = con.cmd.ExecuteReader();
                        while (drd.Read())
                        {
                            comboBox2.Items.Add(drd[1].ToString());
                            comboBox2.ValueMember = drd[0].ToString();
                            comboBox2.DisplayMember = drd[1].ToString();
                        }
                    }
                    con.mycon.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
