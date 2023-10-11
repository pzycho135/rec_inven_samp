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

        string _yr = null;
        string _qtr = null;

        public ctrl_dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_control_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(219, 240, 227);

            _refresher();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _btn_change(sender);

            gridControl1.DataSource = null;
            fill_submission();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _btn_change(sender);

            gridControl1.DataSource = null;
            fill_no_submission();
        }

        private void _btn_change(object sender)
        {
            Control bu = ((Control)sender);
            switch (bu.Name)
            {
                case "button1":
                    foreach (Button xbu in panel1.Controls)
                    {
                        xbu.BackColor = Color.Transparent;
                    }
                    bu.BackColor = Color.FromArgb(219, 240, 227);
                    break;

                case "button2":
                    foreach (Button xbu in panel1.Controls )
                    {
                        xbu.BackColor = Color.Transparent;
                    }
                    bu.BackColor = Color.FromArgb(255, 230, 230);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                _yr = "";
            }
            else
            {
                _yr = " where year(nap1_submit_date) = " + comboBox1.Text + "";
            }

            comboBox2.SelectedIndex = 0;
            counter();
            _btn_sub_change();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    _qtr = "";
                    break;
                case 1:
                    if (comboBox1.SelectedIndex == 0)
                    {
                        _qtr = " where quarter(nap1_submit_date) = 1";
                    }
                    else
                    {
                        _qtr = " and quarter(nap1_submit_date) = 1";
                    }
                    break;
                case 2:
                    if (comboBox1.SelectedIndex == 0)
                    {
                        _qtr = " where quarter(nap1_submit_date) = 2";
                    }
                    else
                    {
                        _qtr = " and quarter(nap1_submit_date) = 2";
                    }
                    break;
                case 3:
                    if (comboBox1.SelectedIndex == 0)
                    {
                        _qtr = " where quarter(nap1_submit_date) = 3";
                    }
                    else
                    {
                        _qtr = " and quarter(nap1_submit_date) = 3";
                    }
                    break;
                case 4:
                    if (comboBox1.SelectedIndex == 0)
                    {
                        _qtr = " where quarter(nap1_submit_date) = 4";
                    }
                    else
                    {
                        _qtr = " and quarter(nap1_submit_date) = 4";
                    }
                    break;
            }

            counter();
            _btn_sub_change();
        }

        public void _refresher()
        {
            _cmb_year();
            counter();

            _btn_sub_change();
        }

        private void _btn_sub_change()
        {
            if (button1.BackColor != Color.Transparent)
            {
                fill_submission();
            }
            else
            {
                fill_no_submission();
            }
        }

        private void _cmb_year()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ALL");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            try
            {
                string sql1 = "select distinct year(nap1_submit_date) as yr from  " + con.nap1_identifier + "";

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    MySqlDataReader dr = con.cmd.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["yr"].ToString());
                    }
                }
                con.mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void counter()
        {
            try
            {
                int div_cnt = 0;
                int dis_cnt = 0;
                int schl_cnt = 0;

                string sql1 = "select count(*) from " + con.nap1_identifier + " as test join list_office on test.office_code = " + con.div + ".office_code" + _yr + _qtr;
                string sql2 = "select count(*) from " + con.nap1_identifier + " as test join list_district on test.office_code = " + con.district + ".office_code" + _yr + _qtr;
                string sql3 = "select count(*) from " + con.nap1_identifier + " as test join list_school on test.office_code = " + con.school + ".office_code" + _yr + _qtr;

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
                label4.Text = total_cnt.ToString("000000"); //--- number of zeroes is number of digits to show in left align format
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fill_submission()
        {
            try
            {
                //--- gridview
                string sql_div = "(select office_name as ofis, max(nap1_submit_date) as submit_date from" +
                                 " (select * from nap1_identifier as t1 join list_office using" +
                                 "(office_code)) as t" + _yr + _qtr + " group by office_name)";

                string sql_district = "(select district_name as ofis, max(nap1_submit_date) as submit_date from" +
                                      " (select * from nap1_identifier as t1 join list_district using" +
                                      "(office_code)) as t" + _yr + _qtr + " group by district_name)";

                string sql_school = "(select school_name as ofis, max(nap1_submit_date) as submit_date from" +
                                    " (select * from nap1_identifier as t1 join list_school using" +
                                    "(office_code)) as t" + _yr + _qtr + " group by school_name)";

                string sql1 = sql_div + " union all " + sql_district + " union all " + sql_school + " order by submit_date desc";


                //con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);
                    //cmd.ExecuteNonQuery();

                    gridColumn5.Visible = true;
                    gridControl1.DataSource = con.ds.Tables[0]; //--- depends on (field name -> table column name) for grid columns
                }
                //con.mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fill_no_submission()
        {
            //--- determine yr and quarter no submission
            try
            {
                //--- gridview
                string sql_div = "select " + con.div + ".office_name as ofis from " + con.div + " where office_code not in (select office_code from " + con.nap1_identifier + ")";

                string sql_district = "select " + con.district + ".district_name as ofis from " + con.district + " where office_code not in (select office_code from " + con.nap1_identifier + ")";

                string sql_school = "select " + con.school + ".school_name as ofis from " + con.school + " where office_code not in (select office_code from " + con.nap1_identifier + ")";

                string sql1 = sql_div + " union all " + sql_district + " union all " + sql_school;


                //con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);
                    //cmd.ExecuteNonQuery();

                    gridColumn5.Visible = false;
                    gridControl1.DataSource = con.ds.Tables[0]; //--- depends on (field name -> table column name) for grid columns
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

        //--- test
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
