using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHEXC
{
    public partial class FrmCheckout : Form
    {
        public FrmCheckout()
        {
            InitializeComponent();
        }

       
            private void timer2_Tick(object sender, EventArgs e)
            {

                this.statusTime.Text = "当前时间：" + DateTime.Now.ToString();
            }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {

        }
    }
}
