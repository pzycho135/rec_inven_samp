using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frm_add_nap3 : Form
    {
        db_con con = new db_con();

        private string office_fill = null;
        private string office_vm = null;
        private string office_dm = null;

        private string g1_entry_code = null;
        private string g1_rds_id = null;
        private string g1_item_name = null;
        private string g1_loc = null;
        private string g1_vol = null;
        private string g1_time_val = null;
        private string g1_util_val = null;
        private string g1_use_freq = null;
        private string g1_dup = null;
        private string g1_period_start = null;
        private string g1_period_end = null;

        private string g2_entry_code = null;
        private string g2_rds_id = null;
        private string g2_item_name = null;
        private string g2_loc = null;
        private string g2_vol = null;
        private string g2_time_val = null;
        private string g2_util_val = null;
        private string g2_use_freq = null;
        private string g2_dup = null;
        private string g2_period_start = null;
        private string g2_period_end = null;

        DataTable dtable = new DataTable();

        int wc = 0;

        public frm_add_nap3()
        {
            InitializeComponent();

            _grid_column();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmb_office_categ_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //--- might need to re-code for latest submission only (current shows all submission)

            cmb_office.DataSource = null;
            cmb_office.Items.Clear();

            switch (cmb_office_categ.Text)
            {
                case "DIVISION":
                    office_fill = "select office_name as ofis, nap1_code from (select * from nap1_identifier as t1" +
                                  " join list_office using (office_code)) as t order by ofis ASC";
                    office_vm = "nap1_code";
                    office_dm = "ofis";
                    _fill_office();
                    break;

                case "DISTRICT":
                    office_fill = "select district_name as ofis, nap1_code from (select * from nap1_identifier as t1" +
                                  " join list_district using (office_code)) as t order by ofis ASC";
                    office_vm = "nap1_code";
                    office_dm = "ofis";
                    _fill_office();
                    break;

                case "SCHOOL":
                    office_fill = "select school_name as ofis, nap1_code from (select * from nap1_identifier as t1" +
                                  " join list_school using (office_code)) as t order by ofis ASC";
                    office_vm = "nap1_code";
                    office_dm = "ofis";
                    _fill_office();
                    break;
            }
        }

        private void _fill_office()
        {
            try
            {
                string sql1 = office_fill;

                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);

                    cmb_office.DataSource = con.ds.Tables[0];
                    cmb_office.ValueMember = office_vm;
                    cmb_office.DisplayMember = office_dm;
                }
                con.mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.mycon.Close();
            }

            cmb_office.SelectedIndex = -1;
            gridControl1.DataSource = null;
        }

        private void cmb_office_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;

            try
            {
                string sql1 = "select rds_id, item_name, record_loc, vol_cubic_meter, time_value, utility_value, use_frequency," +
                              " duplication, period_start, period_end, entry_code" +
                              " from nap1_entries join rds_list using (rds_id) where nap1_code = '" + cmb_office.SelectedValue + "'";

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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                /*
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                var str = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, info.Column));
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}. \n {2}", info.RowHandle + 1, info.Column.GetCaption(), str));

                //--- need to work this for edit and delete
                */

                MessageBox.Show(gridView1.GetFocusedRowCellValue("entry_code").ToString());

                wc = 1;
                _transfer();

                gridView1.DeleteSelectedRows();
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                MessageBox.Show(gridView2.GetFocusedRowCellValue("entry_code").ToString());

                wc = 2;
                _transfer();

                gridView2.DeleteSelectedRows();
            }
        }

        private void _transfer()
        {
            if (wc == 1)
            {
                //--- might not be a good way to do this, look for better alt

                g2_entry_code = gridView1.GetFocusedRowCellValue("entry_code").ToString();
                g2_rds_id = gridView1.GetFocusedRowCellValue("rds_id").ToString();
                g2_item_name = gridView1.GetFocusedRowCellValue("item_name").ToString();
                g2_loc = gridView1.GetFocusedRowCellValue("record_loc").ToString();
                g2_vol = gridView1.GetFocusedRowCellValue("vol_cubic_meter").ToString();
                g2_time_val = gridView1.GetFocusedRowCellValue("time_value").ToString();
                g2_util_val = gridView1.GetFocusedRowCellValue("utility_value").ToString();
                g2_use_freq = gridView1.GetFocusedRowCellValue("use_frequency").ToString();
                g2_dup = gridView1.GetFocusedRowCellValue("duplication").ToString();
                g2_period_start = gridView1.GetFocusedRowCellValue("period_start").ToString();
                g2_period_end = gridView1.GetFocusedRowCellValue("period_end").ToString();

                DataRow drow = dtable.NewRow();
                drow["entry_code"] = g2_entry_code;
                drow["rds_id"] = g2_rds_id;
                drow["item_name"] = g2_item_name;
                drow["record_loc"] = g2_loc;
                drow["vol_cubic_meter"] = g2_vol;
                drow["time_value"] = g2_time_val;
                drow["utility_value"] = g2_util_val;
                drow["use_frequency"] = g2_use_freq;
                drow["duplication"] = g2_dup;
                drow["period_start"] = g2_period_start;
                drow["period_end"] = g2_period_end;
                dtable.Rows.Add(drow);

                gridControl2.DataSource = dtable;
            }

            else if (wc == 2)
            {
                g1_entry_code = gridView2.GetFocusedRowCellValue("entry_code").ToString();
                g1_rds_id = gridView2.GetFocusedRowCellValue("rds_id").ToString();
                g1_item_name = gridView2.GetFocusedRowCellValue("item_name").ToString();
                g1_loc = gridView2.GetFocusedRowCellValue("record_loc").ToString();
                g1_vol = gridView2.GetFocusedRowCellValue("vol_cubic_meter").ToString();
                g1_time_val = gridView2.GetFocusedRowCellValue("time_value").ToString();
                g1_util_val = gridView2.GetFocusedRowCellValue("utility_value").ToString();
                g1_use_freq = gridView2.GetFocusedRowCellValue("use_frequency").ToString();
                g1_dup = gridView2.GetFocusedRowCellValue("duplication").ToString();
                g1_period_start = gridView2.GetFocusedRowCellValue("period_start").ToString();
                g1_period_end = gridView2.GetFocusedRowCellValue("period_end").ToString();

                DataRow drow = dtable.NewRow();
                drow["entry_code"] = g1_entry_code;
                drow["rds_id"] = g1_rds_id;
                drow["item_name"] = g1_item_name;
                drow["record_loc"] = g1_loc;
                drow["vol_cubic_meter"] = g1_vol;
                drow["time_value"] = g1_time_val;
                drow["utility_value"] = g1_util_val;
                drow["use_frequency"] = g1_use_freq;
                drow["duplication"] = g1_dup;
                drow["period_start"] = g1_period_start;
                drow["period_end"] = g1_period_end;
                dtable.Rows.Add(drow);

                gridControl1.DataSource = dtable;
            }
        }

        private void _grid_column()
        {
            dtable.Columns.Add("entry_code");
            dtable.Columns.Add("rds_id");
            dtable.Columns.Add("item_name");
            dtable.Columns.Add("record_loc");
            dtable.Columns.Add("vol_cubic_meter");
            dtable.Columns.Add("time_value");
            dtable.Columns.Add("utility_value");
            dtable.Columns.Add("use_frequency");
            dtable.Columns.Add("duplication");
            dtable.Columns.Add("period_start");
            dtable.Columns.Add("period_end");
        }
    }
}
