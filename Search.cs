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
    public partial class Search : Form
    {
        OdbcConnection con = new OdbcConnection("DSN=salary");
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            if (rdo_Employee.Checked == false && rdo_component.Checked == false && rdo_department.Checked == false && rdo_attendence.Checked == false)
            {
                MessageBox.Show("Please Choose a Option");
            }

            if (rdo_Employee.Checked == true)
            {

                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandText = "select Emp_name,gender,Address,Mobile,Date_of_joining,Email_id,Experience from Employee where Emp_id='" + cmb_1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

             }

            if (rdo_attendence.Checked == true)
            {
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from Attendence where Emp_id='" + cmb_1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            if (rdo_department.Checked == true)
            { 
            OdbcCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from Department where Dept_id='" + cmb_1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            
            }

            if (rdo_component.Checked == true)

            {

                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from Salary_component where Emp_id='" + cmb_1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
 
            con.Close();
        }

        private void rdo_Employee_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Employee.Checked == true)
            {
                label1.Text = "Employee_id";
            }
        }

        private void rdo_attendence_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_attendence.Checked == true)
            {
                label1.Text = "Employee_id";
            }
        }

        private void rdo_department_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_department.Checked == true)
            {
                label1.Text = "Department_id";
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            for (int loop = 0; loop < dt.Rows.Count; loop++)
            {
                cmb_1.Items.Add(dt.Rows[loop]["Emp_id"].ToString());

            }

            con.Close();
        }

        private void rdo_component_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_component.Checked == true)
            {
                label1.Text = "Employee_id";
            }
        }
    }
}
