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
    public partial class Form1 : Form
    {
        dashboard_control dash_control = new dashboard_control();
        report_control rep_control = new report_control();
        inventory_control inven_control = new inventory_control();
        disposal_control disp_control = new disposal_control();


        public Form1()
        {
            InitializeComponent();

            panel3.Controls.Add(dash_control);


            // location inside panel 3
            

            // center alignment
            dash_control.Location = new Point((panel3.Width - dash_control.Width) / 2);
            //rep_control.Location = new Point((panel3.Width - rep_control.Width) / 2, (panel3.Height - rep_control.Height) / 2);
            //inven_control.Location = new Point((panel3.Width - inven_control.Width) / 2, (panel3.Height - inven_control.Height) / 2);
            //disp_control.Location = new Point((panel3.Width - disp_control.Width) / 2, (panel3.Height - disp_control.Height) / 2);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;

            panel3.Controls.Clear();
            panel3.Controls.Add(dash_control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;

            panel3.Controls.Clear();
            panel3.Controls.Add(rep_control);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;

            panel3.Controls.Clear();
            panel3.Controls.Add(inven_control);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;

            panel3.Controls.Clear();
            panel3.Controls.Add(disp_control);
        }
    }
}
