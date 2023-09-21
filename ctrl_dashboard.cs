using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rec_inven_samp
{
    public partial class ctrl_dashboard : UserControl
    {
        db_con con = new db_con();

        public ctrl_dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_control_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            _refresher();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    label7.Text = "Total";
                    break;
                case 1:
                    label7.Text = "Office of the Schools Division Superintendent";
                    break;
                case 2:
                    label7.Text = "School Governance and Operations Division";
                    break;
                case 3:
                    label7.Text = "Curriculum Implementation Division";
                    break;
                case 4:
                    label7.Text = "Central Butuan District I";
                    break;
                case 5:
                    label7.Text = "Central Butuan District II";
                    break;
                case 6:
                    label7.Text = "East Butuan District I";
                    break;
                case 7:
                    label7.Text = "East Butuan District II";
                    break;
                case 8:
                    label7.Text = "East Butuan District III";
                    break;
                case 9:
                    label7.Text = "North Butuan District";
                    break;
                case 10:
                    label7.Text = "Northwest Butuan District";
                    break;
                case 11:
                    label7.Text = "South Butuan District I";
                    break;
                case 12:
                    label7.Text = "South Butuan District II";
                    break;
                case 13:
                    label7.Text = "Southeast Butuan District I";
                    break;
                case 14:
                    label7.Text = "Southeast Butuan District II";
                    break;
                case 15:
                    label7.Text = "Southwest Butuan District";
                    break;
                case 16:
                    label7.Text = "West Butuan District I";
                    break;
                case 17:
                    label7.Text = "West Butuan District II";
                    break;
                case 18:
                    label7.Text = "West Butuan District III";
                    break;
            }
        }

        public void _refresher()
        {
            fill_grid();
            counter();
        }

        private void counter()
        {
            try
            {
                int div_cnt = 0;
                int dis_cnt = 0;
                int schl_cnt = 0;

                string sql1 = "select count(*) from test_nap1 as test join list_office on test.office_code = list_office.office_code";
                string sql2 = "select count(*) from test_nap1 as test join list_district on test.office_code = list_district.district_code";
                string sql3 = "select count(*) from test_nap1 as test join list_school on test.office_code = list_school.school_id_unique";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    int cnt = Convert.ToInt32(con.cmd.ExecuteScalar());
                    div_cnt = cnt;
                    label30.Text = div_cnt.ToString("000000");
                }

                using (con.cmd = new MySqlCommand(sql2, con.mycon))
                {
                    int cnt = Convert.ToInt32(con.cmd.ExecuteScalar());
                    dis_cnt = cnt;
                    label19.Text = dis_cnt.ToString("000000");
                }

                using (con.cmd = new MySqlCommand(sql3, con.mycon))
                {
                    int cnt = Convert.ToInt32(con.cmd.ExecuteScalar());
                    schl_cnt = cnt;
                    label22.Text = schl_cnt.ToString("000000");
                }
                con.mycon.Close();

                int total_cnt = div_cnt + dis_cnt + schl_cnt;
                label4.Text = total_cnt.ToString("000000"); //--- number of zeroes is number of digits to show using left align
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fill_grid()
        {
            try
            {
                //--- gridview
                string sql_office = "select " + con.div + ".office_name as office, test.submit_date, test.idtest_nap1 from " + con.nap1_table + " as test" +
                                    " join " + con.div + " on test.office_code = " + con.div + ".office_code" +
                                    " join(select office_code, max(submit_date) as date_submit from " + con.nap1_table + " group by office_code) gtest" +
                                    " on test.office_code = gtest.office_code" +
                                    " and test.submit_date = gtest.date_submit";

                string sql_district = "select " + con.district + ".district_name as office, test.submit_date, test.idtest_nap1 from " + con.nap1_table + " as test" +
                                      " join " + con.district + " on test.office_code = " + con.district + ".district_code" +
                                      " join(select office_code, max(submit_date) as date_submit from " + con.nap1_table + " group by office_code) gtest" +
                                      " on test.office_code = gtest.office_code" +
                                      " and test.submit_date = gtest.date_submit";

                string sql_school = "select " + con.school + ".school_name as office, test.submit_date, test.idtest_nap1 from " + con.nap1_table + " as test" +
                                    " join " + con.school + " on test.office_code = " + con.school + ".school_id_unique" +
                                    " join(select office_code, max(submit_date) as date_submit from " + con.nap1_table + " group by office_code) gtest" +
                                    " on test.office_code = gtest.office_code" +
                                    " and test.submit_date = gtest.date_submit";

                string sql1 = sql_office + " union all " + sql_district + " union all " + sql_school + " order by idtest_nap1 desc";


                //con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);
                    //cmd.ExecuteNonQuery();
                    
                    gridControl1.DataSource = con.ds.Tables[0];
                    gridControl2.DataSource = con.ds.Tables[0]; //--- depends on (field name -> table column name) for grid columns
                }
                //con.mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            //--- IN ORDER (not working if not in order)

            //--- add numbers to indicator row
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }

            //--- remove triangle in indicator row
            e.Info.ImageIndex = -1;  // <<< NEW LINE  
            e.Painter.DrawObject(e.Info);

            //--- add borders to indicator row
            GridView view = sender as GridView;
            var pen = view.PaintAppearance.HorzLine.GetBackPen(e.Cache);
            var startPoint = new Point(e.Bounds.Location.X, e.Bounds.Bottom - (int)pen.Width);
            var endPoint = new Point(e.Bounds.Right, e.Bounds.Bottom - (int)pen.Width);
            e.DefaultDraw();
            e.Cache.DrawLine(pen, startPoint, endPoint);
            e.Handled = true;
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            //--- set indicator row width according to # of char
            GridView gridView = ((GridView)sender);
            if (!gridView.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridView.GridControl.Handle);
            SizeF size = gr.MeasureString(gridView.RowCount.ToString(), gridView.PaintAppearance.Row.GetFont());
            gridView.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 5;
        }
    }
}
