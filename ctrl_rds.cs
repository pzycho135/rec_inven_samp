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
    public partial class ctrl_rds : UserControl
    {
        db_con con = new db_con();

        public ctrl_rds()
        {
            InitializeComponent();

            _refresher();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                var str = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, info.Column));
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}. \n {2}", info.RowHandle + 1, info.Column.GetCaption(), str));
                
                //--- need to work this for viewing of rds
            }
        }

        public void _refresher()
        {
            _fill_grid();
        }

        private void _fill_grid()
        {
            try
            {
                string sql1 = "select rds_id, item_name, category, retention_total, remarks, add_info, time_value from rds_list" +
                              " join rds_category using (category_id)";

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

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {   //--- IN ORDER (not working if not in order)

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
