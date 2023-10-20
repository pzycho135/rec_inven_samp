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
    public partial class frm_main : Form
    {
        /* 
            ------ colors
        https://colorhunt.co/palettes/light
        https://www.w3schools.com/colors/colors_converter.asp

        green:
        #829460
        #dae2b6
        #7eca9c

        blue:
        #456268
        #579bb1
        #dceaef

        brown:
        #ad8b73
        #ece4df

        red:
        #cd5d7d
        #ffe6e6



        */


        ctrl_dashboard dash_control = new ctrl_dashboard();
        ctrl_report rep_control = new ctrl_report();
        ctrl_inventory inven_control = new ctrl_inventory();
        ctrl_disposal disp_control = new ctrl_disposal();
        ctrl_rds rds_list_control = new ctrl_rds();


        public frm_main()
        {
            InitializeComponent();

            panel3.Controls.Add(dash_control);

            // location inside panel 3
            // center alignment
            dash_control.Location = new Point((panel3.Width - dash_control.Width) / 2);
            inven_control.Location = new Point((panel3.Width - inven_control.Width) / 2);
            disp_control.Location = new Point((panel3.Width - disp_control.Width) / 2);
            //rep_control.Location = new Point((panel3.Width - rep_control.Width) / 2, (panel3.Height - rep_control.Height) / 2);
            rds_list_control.Location = new Point((panel3.Width - rds_list_control.Width) / 2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button bu in panel2.Controls)
            {
                bu.BackColor = Color.Transparent;
                bu.ForeColor = Color.FromArgb(130, 148, 96);
            }

            button1.BackColor = Color.FromArgb(130, 148, 96);
            button1.ForeColor = Color.White;
            label1.Text = button1.Text;
        }

        private void _btn_change(object sender)
        {
            foreach (Button bu in panel2.Controls)
            {
                bu.BackColor = Color.Transparent;
                bu.ForeColor = Color.FromArgb(130, 148, 96);
            }

            Control clk = (Control)sender;
            clk.BackColor = Color.FromArgb(130, 148, 96);
            clk.ForeColor = Color.White;
            label1.Text = clk.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _btn_change(sender);

            panel3.Controls.Clear();
            panel3.Controls.Add(dash_control);
            dash_control._refresher();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _btn_change(sender);

            panel3.Controls.Clear();
            panel3.Controls.Add(rep_control);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _btn_change(sender);

            panel3.Controls.Clear();
            panel3.Controls.Add(inven_control);
            inven_control._refresher();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _btn_change(sender);

            panel3.Controls.Clear();
            panel3.Controls.Add(disp_control);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _btn_change(sender);

            panel3.Controls.Clear();
            panel3.Controls.Add(rds_list_control);
            rds_list_control._refresher();
        }
    }
}
