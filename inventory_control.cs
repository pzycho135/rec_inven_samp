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
    public partial class inventory_control : UserControl
    {
        public inventory_control()
        {
            InitializeComponent();

            button1.Hide();
            button1.Enabled = false;
            button2.Hide();
            button2.Enabled = false;
        }

        public void enter_edit()
        {
            button1.Show();
            button1.Enabled = true;
            button2.Show();
            button2.Enabled = true;

            button3.Enabled = false;
            button4.Enabled = false;

            dataGridView1.BackgroundColor = Color.LightYellow;

            Control ctrl = (Control)this.Parent; //--- panel containing usercontrol
            main_form main = (main_form)ctrl.Parent; //--- form containing panel

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
                    button1.Hide();
                    button1.Enabled = false;
                    button2.Hide();
                    button2.Enabled = false;

                    button3.Enabled = true;
                    button4.Enabled = true;

                    dataGridView1.BackgroundColor = Color.White;

                    Control ctrl = (Control)this.Parent; //--- panel containing usercontrol
                    main_form main = (main_form)ctrl.Parent; //--- form containing panel

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

        private void button5_Click(object sender, EventArgs e)
        {
            enter_edit();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            exit_edit();
        }
    }
}
