using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Salary_Management
{
    public partial class Department : Form
    {
        OdbcConnection con = new OdbcConnection("DSN=salary");
        public Department()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into  Department values('" + txtbox_Deptid.Text + "' , '" + txtbox_DeptName.Text + "' , '" + txtbox_DeptHead.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Submitted Sucessfully");
            con.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtbox_Deptid.Text = "";
            txtbox_DeptName.Text = "";
            txtbox_DeptHead.Text = "";
           
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_Deptid_Enter(object sender, EventArgs e)
        {
            if (txtbox_Deptid.Text == "Enter Dept_ID")
            {
                txtbox_Deptid.Text = "";
                txtbox_Deptid.ForeColor = Color.Black;
            }
        }

        private void txtbox_DeptName_Enter(object sender, EventArgs e)
        {
            if (txtbox_DeptName.Text == "Enter Dept_Name")
            {
                txtbox_DeptName.Text = "";
                txtbox_DeptName.ForeColor = Color.Black;
            }
        }

        private void txtbox_DeptHead_Enter(object sender, EventArgs e)
        {
            if (txtbox_DeptHead.Text == "Enter Head Of Department")
            {
                txtbox_DeptHead.Text = "";
                txtbox_DeptHead.ForeColor = Color.Black;
            }
        }

    }
}
