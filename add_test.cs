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
                string sql2 = "select distinct(category) from rds_grds_list;";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql2, con.mycon))
                {
                    //con.adapter = new MySqlDataAdapter(con.cmd);
                    //con.ds = new DataSet();
                    //con.adapter.Fill(con.ds);

                    MySqlDataReader drd = con.cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        comboBox1.Items.Add(drd[0].ToString());
                        comboBox1.ValueMember = drd[0].ToString();
                        comboBox1.DisplayMember = drd[0].ToString();
                    }
                }
                con.mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
