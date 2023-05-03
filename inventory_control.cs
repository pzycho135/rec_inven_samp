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

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Show();
            button1.Enabled = true;
            button2.Show();
            button2.Enabled = true;
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
            DialogResult dr = MessageBox.Show("Exit Editing?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            switch (dr)
            {
                case DialogResult.Yes:
                    button1.Hide();
                    button1.Enabled = false;
                    button2.Hide();
                    button2.Enabled = false;
                    break;

                case DialogResult.No:
                    break;
            }
        }
    }
}
