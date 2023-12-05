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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_nap3();
        }

        private void add_nap3()
        {
            frm_add_nap3 nap3 = new frm_add_nap3();
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (nap3.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("done"); //--- must check if success insert
                //_refresher();

                gridView1.MoveLast();
            }
            else
            {
                //this.txtResult.Text = "Cancelled";
            }

        }
    }
}
