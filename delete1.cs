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
    public partial class Delete : Form
    {
        OdbcConnection con = new OdbcConnection("DSN=Salary");
        public Delete()
        {
            InitializeComponent();
        }

     
        private void rdo_Employee_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            cmb1.Items.Clear();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            for (int loop = 0; loop < dt.Rows.Count; loop++)
            {
                cmb1.Items.Add(dt.Rows[loop]["Emp_id"].ToString());

            }
            con.Close();

        }

        private void rdo_Desig_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Designation_name";
            cmb1.Items.Clear();
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Designation";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            for (int loop = 0; loop < dt.Rows.Count; loop++)
            {
                cmb1.Items.Add(dt.Rows[loop]["Desi_name"].ToString());

            }
            con.Close();
        }

        private void rdo_department_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Department_name";
            cmb1.Items.Clear();
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Department";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            for (int loop = 0; loop < dt.Rows.Count; loop++)
            {
                cmb1.Items.Add(dt.Rows[loop]["Dept_name"].ToString());

            }
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (rdo_Employee.Checked == true)
            {
                con.Open();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Employee where Emp_id='"+cmb1.Text+"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted sucessfully ");
                con.Close();
            }

            if (rdo_department.Checked == true)
            {
                con.Open();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Department where Dept_name='" + cmb1.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Department Deleted sucessfully ");
                con.Close();
            }

            if (rdo_Desig.Checked == true)
            {
                con.Open();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Designation where Desi_name='" + cmb1.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Designation Deleted sucessfully ");
                con.Close();
            }

        }

       

        

    }
}
