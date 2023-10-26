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
    }
}
