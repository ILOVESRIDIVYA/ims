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
    public partial class fees_payment : Form
    {
        public fees_payment()
        {
            InitializeComponent();
        }

        private void fees_payment_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Now.ToLongDateString();
            label_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
