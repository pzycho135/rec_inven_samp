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
    public partial class frm_rds_edit : Form
    {
        public frm_rds_edit()
        {
            InitializeComponent();

            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox5.TextAlign = HorizontalAlignment.Center;

        }

        private void frm_rds_edit_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
