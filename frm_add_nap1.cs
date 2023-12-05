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
    public partial class frm_add_nap1 : Form
    {
        db_con con = new db_con();

        private string office_fill = null;
        private string office_vm = null;
        private string office_dm = null;

        private string datetime_format = "dd/MM/yyyy hh:mm:ss tt";
        private string date_format = "dd/MM/yyyy";

        private string rds_id = null;
        private string rec_series = null;
        private string loc = null;
        private string volume = null;
        private string time_val = null;
        private string util_val = null;
        private string use_freq = null;
        private string duplication = null;
        private string period_start = null;
        private string period_end = null;

        private bool _check_encoder = false;
        private bool _check = false;

        DataTable dtable = new DataTable();

        public frm_add_nap1()
        {
            InitializeComponent();

            button2.Enabled = false;

            _grid_column();

            dtp_submit_date.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            _checker();

            if (_check == true)
            {
                _add_form();
            }
        }

        private void _checker()
        {
            foreach (Control c in grp_encoder.Controls.Cast<Control>().OrderBy(x => x.TabIndex))
            {
                if (string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show(c.Name + " is empty");
                    _check_encoder = false;
                    c.Select();
                    break;
                }
                else
                {
                    _check_encoder = true;
                }
            }

            if (_check_encoder == true)
            {
                _date_checker();
            }
        }

        private void _date_checker()
        {
            if (dtp_submit_date.Checked == false)
            {
                MessageBox.Show(dtp_submit_date.Name + " is empty");
                dtp_submit_date.Select();
                _check = false;
            }
            else
            {
                _check = true;
            }
        }

        private void _add_form()
        {
            frm_add_entry add_entry = new frm_add_entry();
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (add_entry.ShowDialog(this) == DialogResult.OK)
            {
                rds_id = add_entry.rds_id;
                rec_series = add_entry.rec_series;
                loc = add_entry.location;
                volume = add_entry.volume;
                time_val = add_entry.time_val;
                util_val = add_entry.util_val;
                use_freq = add_entry.use_freq;
                duplication = add_entry.duplication;
                period_start = add_entry.period_start;
                period_end = add_entry.period_end;

                DataRow drow = dtable.NewRow();
                drow["rds_id"] = rds_id;
                drow["rec_series"] = rec_series;
                drow["location"] = loc;
                drow["volume"] = volume;
                drow["time_val"] = time_val;
                drow["util_val"] = util_val;
                drow["use_freq"] = use_freq;
                drow["duplication"] = duplication;
                drow["period_start"] = period_start;
                drow["period_end"] = period_end;
                dtable.Rows.Add(drow);

                gridControl1.DataSource = dtable;

                MessageBox.Show("done");
                gridView1.MoveLast();
            }
            else
            {
                //this.txtResult.Text = "Cancelled";
            }
        }

        private int _iden_code(int res)
        {
            string office = cmb_office.SelectedValue.ToString();
                
            string sql1 = "select count(distinct(nap1_code)) from nap1_identifier where nap1_code like '%" + office + "%'";

            try
            {
                con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    res = Convert.ToInt32(con.cmd.ExecuteScalar());
                }
                con.mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _checker();

            if (_check == true)
            {
                int _count = 0;
                string office_code = cmb_office.SelectedValue.ToString();
                string iden = office_code + "_" + (_iden_code(_count) + 1).ToString("0000");

                try
                {
                    //--- nap1
                    string name = txt_name.Text;
                    string office = cmb_office.SelectedValue.ToString();
                    
                    //string date = Convert.ToDateTime(lbl_dt.Text).ToString(datetime_format);

                    string date = dtp_submit_date.Value.ToString(date_format);

                    string sql1 = "insert into nap1_identifier(office_code, nap1_submit_name, nap1_submit_date, nap1_code)" +
                                  " values ('" + office + "', '" + name + "', str_to_date('" + date + "', '%d/%m/%Y %I:%i:%s %p'), '" + iden + "')";

                    con.mycon.Open();
                    using (con.cmd = new MySqlCommand(sql1, con.mycon))
                    {
                        con.cmd.ExecuteNonQuery();
                    }
                    con.mycon.Close();

                    //--- items on nap1
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        string id = gridView1.GetRowCellValue(i, "rds_id").ToString();
                        string rec = gridView1.GetRowCellValue(i, "rec_series").ToString();
                        string loc = gridView1.GetRowCellValue(i, "location").ToString();
                        string vol = gridView1.GetRowCellValue(i, "volume").ToString();

                        //string tv = gridView1.GetRowCellValue(i, "time_val").ToString();

                        string uv = gridView1.GetRowCellValue(i, "util_val").ToString();
                        string use = gridView1.GetRowCellValue(i, "use_freq").ToString();
                        string dup = gridView1.GetRowCellValue(i, "duplication").ToString();
                        string start = gridView1.GetRowCellValue(i, "period_start").ToString();
                        string end = gridView1.GetRowCellValue(i, "period_end").ToString();

                        string entry_code = iden + "_" + (i + 1).ToString("0000");

                        string sql2 = "insert into nap1_entries(rds_id, record_loc, vol_cubic_meter, utility_value," +
                                      " use_frequency, duplication, period_start, period_end, nap1_code, entry_code)" +
                                      " values ('" + id + "', '" + loc + "', '" + vol + "', '" + uv + "', '" + use + "'," +
                                      " '" + dup + "', str_to_date('" + start + "', '%d/%m/%Y'), str_to_date('" + end + "', '%d/%m/%Y')," +
                                      " '" + iden + "', '" + entry_code + "')";

                        con.mycon.Open();
                        using (con.cmd = new MySqlCommand(sql2, con.mycon))
                        {
                            con.cmd.ExecuteNonQuery();
                        }
                        con.mycon.Close();

                        //MessageBox.Show("row # " + i.ToString() + "\n" + id);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmb_office_categ_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_office.DataSource = null;
            cmb_office.Items.Clear();

            switch (cmb_office_categ.Text)
            {
                //--- office
                case "DIVISION":
                    office_fill = "list_office order by office_name ASC";
                    office_vm = "office_code";
                    office_dm = "office_name";
                    _fill_office();
                    break;

                case "DISTRICT":
                    office_fill = "list_district order by district_name ASC";
                    office_vm = "office_code";
                    office_dm = "district_name";
                    _fill_office();
                    break;

                case "SCHOOL":
                    office_fill = "list_school order by school_name ASC";
                    office_vm = "office_code";
                    office_dm = "school_name";
                    _fill_office();
                    break;
            }
        }

        private void _fill_office()
        {
            try
            {
                string sql1 = "select * from " + office_fill + ";";

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
        }

        private void _grid_column()
        {
            dtable.Columns.Add("rds_id");
            dtable.Columns.Add("rec_series");
            dtable.Columns.Add("location");
            dtable.Columns.Add("volume");
            dtable.Columns.Add("time_val");
            dtable.Columns.Add("util_val");
            dtable.Columns.Add("use_freq");
            dtable.Columns.Add("duplication");
            dtable.Columns.Add("period_start");
            dtable.Columns.Add("period_end");
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

                //--- need to work this for edit and delete
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

            button2.Enabled = true;
            gridView1.FocusInvalidRow();
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {//--- maybe show what entry to delete
                DialogResult d = MessageBox.Show("Do you wish to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    gridView1.DeleteSelectedRows();

                    if (gridView1.RowCount == 0)
                    {
                        button2.Enabled = false;
                    }
                }
            }

            gridView1.FocusInvalidRow();
            button3.Enabled = false;
        }

        private void gridControl1_Leave(object sender, EventArgs e)
        {//--- need to modify for click outside of grid
            gridView1.FocusInvalidRow();
            button3.Enabled = false;
        }
    }
}
