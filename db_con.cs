using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rec_inven_samp
{
    class db_con
    {
        public static string con = "server=localhost;uid=root;" +
                                      "pwd=root;database=records_inventory;" +
                                        "allow zero datetime=true;Allow User Variables=true";

        public MySqlConnection mycon = new MySqlConnection(con);
        public MySqlCommand cmd;
        public MySqlDataAdapter adapter;
        public DataSet ds;


        //--- tables
        public string rds_table = "rds_list";
        public string rds_categ_table = "rds_category";
        public string rds_util_table = "rds_util_value";
        public string nap1_table = "test_nap1";
        public string div = "list_office";
        public string district = "list_district";
        public string school = "list_school";

    }
}
