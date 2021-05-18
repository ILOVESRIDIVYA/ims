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
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToLongTimeString();
            
        }

       
    }
}
