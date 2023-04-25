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
        }

        public void _btn_district(object sender)
        {
            Control clk = (Control)sender;

            switch(clk.Text)
            {
                case "CBD I":
                    label7.Text = "Central Butuan District I";
                    break;

                case "CBD II":
                    label7.Text = "Central Butuan District II";
                    break;

                case "EAST I":
                    label7.Text = "East Butuan District I";
                    break;

                case "EAST II":
                    label7.Text = "East Butuan District II";
                    break;

                case "EAST III":
                    label7.Text = "East Butuan District III";
                    break;

                case "NORTH":
                    label7.Text = "North Butuan District";
                    break;

                case "NORTHWEST":
                    label7.Text = "Northwest Butuan District";
                    break;

                case "SOUTH I":
                    label7.Text = "South Butuan District I";
                    break;

                case "SOUTH II":
                    label7.Text = "South Butuan District II";
                    break;

                case "SE I":
                    label7.Text = "Southeast Butuan District I";
                    break;

                case "SE II":
                    label7.Text = "Southeast Butuan District II";
                    break;

                case "SOUTHWEST":
                    label7.Text = "Southwest Butuan District";
                    break;

                case "WEST I":
                    label7.Text = "West Butuan District I";
                    break;

                case "WEST II":
                    label7.Text = "West Butuan District II";
                    break;

                case "WEST III":
                    label7.Text = "West Butuan District III";
                    break;

                case "OSDS":
                    label7.Text = "Office of the Schools Division Superintendent";
                    break;

                case "SGOD":
                    label7.Text = "School Governance and Operations Division";
                    break;

                case "CID":
                    label7.Text = "Curriculum Implementation Division";
                    break;

                case "ALL":
                    label7.Text = "Total";
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _btn_district(sender);
        }
    }
}
