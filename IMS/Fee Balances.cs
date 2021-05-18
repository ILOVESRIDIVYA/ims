using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class Fee_Balances : Form
    {
        public Fee_Balances()
        {
            InitializeComponent();
        }

        private void Fee_Balances_Load(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
