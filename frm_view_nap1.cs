using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
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
    public partial class frm_view_nap1 : Form
    {
        db_con con = new db_con();

        public string ofis { get; set; }

        public string code { get; set; }

        public frm_view_nap1()
        {
            InitializeComponent();

        }

        private void frm_view_nap1_Load(object sender, EventArgs e)
        {
            this.Text = ofis + " : " + code;

            _fill_grid();
            _encoder();
        }

        private void _fill_grid()
        {
            try
            {
                string sql1 = "select rds_id, item_name, record_loc, vol_cubic_meter, time_value, utility_value, use_frequency," +
                              " duplication, period_start, period_end" +
                              " from nap1_entries join rds_list using (rds_id) where nap1_code = '" + code + "'";

                //con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);
                    //cmd.ExecuteNonQuery();

                    gridControl1.DataSource = con.ds.Tables[0];
                }
                //con.mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _encoder()
        {
            try
            {
                string t1 = "select nap1_submit_name, office_name as ofis, nap1_submit_date from nap1_identifier" +
                              " join list_office using (office_code) where nap1_code = '" + code + "'";
                
                string t2 = "select nap1_submit_name, district_name as ofis, nap1_submit_date from nap1_identifier" +
                              " join list_district using (office_code) where nap1_code = '" + code + "'";

                string t3 = "select nap1_submit_name, school_name as ofis, nap1_submit_date from nap1_identifier" +
                              " join list_school using (office_code) where nap1_code = '" + code + "'";

                string sql1 = t1 + " union all " + t2 + " union all " + t3;

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    MySqlDataReader dr = con.cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txt_name.Text = dr["nap1_submit_name"].ToString();
                        txt_office.Text = dr["ofis"].ToString();

                        string dt_format = "yyyy, MMMM dd" + "\n" + "hh:mm:ss tt";
                        string dt = Convert.ToDateTime(dr["nap1_submit_date"]).ToString(dt_format);
                        lbl_dt.Text = dt;
                    }
                }
                con.mycon.Close();
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
