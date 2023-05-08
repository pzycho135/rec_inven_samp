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
    public partial class dashboard_control : UserControl
    {
        public dashboard_control()
        {
            InitializeComponent();
        }

        private void dashboard_control_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    label7.Text = "TOTAL";
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
    }
}
