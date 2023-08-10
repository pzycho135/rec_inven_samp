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
    public partial class ctrl_disposal : UserControl
    {
        db_con con = new db_con();

        public ctrl_disposal()
        {
            InitializeComponent();

            dgv_refresh();
        }

        private void dgv_refresh()
        {
            try
            {
                string sql1 = "select * from test_table;";

                //con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);
                    //cmd.ExecuteNonQuery();

                    dataGridView1.DataSource = con.ds.Tables[0];
                }
                //con.mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
