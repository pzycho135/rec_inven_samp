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
    public partial class ctrl_inventory : UserControl
    {
        db_con con = new db_con();

        public ctrl_inventory()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            label1.Hide();

            button_edit_exit.Hide();
            button_edit_exit.Enabled = false;
            button_edit_save.Hide();
            button_edit_save.Enabled = false;

            button_edit.Enabled = false; //--- comment to enable edit button

            dgv_refresh();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            add_entry();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            delete_entry();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            enter_edit();
        }

        private void button_edit_exit_Click(object sender, EventArgs e)
        {
            exit_edit();
        }

        private void button_edit_save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm Changes?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            switch (dr)
            {
                case DialogResult.OK:
                    MessageBox.Show("Changes Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case DialogResult.Cancel:
                    break;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString());
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

        private void add_entry()
        {

            open_form:
            add_test add_Test = new add_test();
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (add_Test.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.

                if (string.IsNullOrWhiteSpace(add_Test.textBox1.Text))
                {
                    MessageBox.Show("Textbox is empty!");
                    goto open_form;
                }
                else
                {
                    try
                    {
                        string sql1 = "insert into test_table (test_tablecol) values ('" + add_Test.textBox1.Text + "');";
                        con.mycon.Open();
                        using (con.cmd = new MySqlCommand(sql1, con.mycon))
                        {
                            con.cmd.ExecuteNonQuery();
                        }
                        con.mycon.Close();

                        string sql2 = "update test_table " +
                                      "set test_id = concat(coalesce(test_table.test_tablecol, ''), '-', coalesce(test_table.idtest_table, '')); ";
                        //---- MUST PUT WHERE CLAUSE
                        con.mycon.Open();
                        using (con.cmd = new MySqlCommand(sql2, con.mycon))
                        {
                            con.cmd.ExecuteNonQuery();
                        }
                        con.mycon.Close();

                        MessageBox.Show(add_Test.textBox1.Text);
                        dgv_refresh();
                        add_Test.Dispose();
                    }

                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                //this.txtResult.Text = "Cancelled";
            }
        }

        private void delete_entry()
        {
            string get_index = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("index is: " + get_index);

            try
            {
                string sql1 = "delete from test_table where idtest_table = '" + get_index + "';";

                //con.mycon.Open();
                using (con.cmd = new MySqlCommand(sql1, con.mycon))
                {
                    con.adapter = new MySqlDataAdapter(con.cmd);
                    con.ds = new DataSet();
                    con.adapter.Fill(con.ds);
                    //cmd.ExecuteNonQuery();
                }
                //con.mycon.Close();
                dgv_refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void enter_edit()
        {
            button_edit_exit.Show();
            button_edit_exit.Enabled = true;
            button_edit_save.Show();
            button_edit_save.Enabled = true;

            label1.Show();

            button_add.Enabled = false;
            button_delete.Enabled = false;

            dataGridView1.ReadOnly = false;
            dataGridView1.BackgroundColor = Color.LightYellow;

            Control ctrl = (Control)this.Parent; //--- panel containing usercontrol
            frm_main main = (frm_main)ctrl.Parent; //--- form containing panel

            foreach (Control bu in main.panel2.Controls)
            {
                if (bu is Button)
                {
                    bu.Enabled = false;
                }
            }
        }

        public void exit_edit()
        {
            DialogResult dr = MessageBox.Show("Exit Editing?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            switch (dr)
            {
                case DialogResult.Yes:
                    button_edit_exit.Hide();
                    button_edit_exit.Enabled = false;
                    button_edit_save.Hide();
                    button_edit_save.Enabled = false;

                    label1.Hide();

                    button_add.Enabled = true;
                    button_delete.Enabled = true;

                    dataGridView1.ReadOnly = true;
                    dataGridView1.BackgroundColor = Color.White;

                    Control ctrl = (Control)this.Parent; //--- panel containing usercontrol
                    frm_main main = (frm_main)ctrl.Parent; //--- form containing panel

                    foreach (Control bu in main.panel2.Controls)
                    {
                        if (bu is Button)
                        {
                            bu.Enabled = true;
                        }
                    }
                    break;

                case DialogResult.No:
                    break;
            }

        }
    }
}
