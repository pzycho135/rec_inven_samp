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
        public string nap1_identifier = "nap1_identifier";
        public string nap1_entries = "nap1_entries";
        public string div = "list_office";
        public string district = "list_district";
        public string school = "list_school";

        //--- unused yet
        //--- nest in outside select for specific columns
        public string q_div = "select * from nap1_identifier as t1" +
                              " join nap1_entries using (nap1_code)" +
                              " join list_office using (office_code)" +
                              " join rds_list using (rds_id)";

        public string q_district = "select * from nap1_identifier as t1" +
                              " join nap1_entries using (nap1_code)" +
                              " join list_district using (office_code)" +
                              " join rds_list using (rds_id)";

        public string q_school = "select * from nap1_identifier as t1" +
                              " join nap1_entries using (nap1_code)" +
                              " join list_school using (office_code)" +
                              " join rds_list using (rds_id)";
    }
}
