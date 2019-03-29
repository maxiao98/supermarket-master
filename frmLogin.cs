using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CHEXC.GoodMenhod;
namespace CHEXC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _EmpInfoMenthod tbEmp = new _EmpInfoMenthod();
            if (txtID.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (tbEmp.tb_EmpInfoFind(txtID.Text, txtPwd.Text, 2) == 1)
            {
                frmMain frm = new frmMain(txtID.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}