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
    public partial class Attendence : Form
    {
        OdbcConnection con = new OdbcConnection(" DSN=salary");
        public Attendence()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int loop = 2000;loop<= DateTime.Now.Year; loop++)
            {
                cmbbox_year.Items.Add(loop);
            }

            for (int loop = 1; loop <= 31; loop++)
            {
                cmbbox_noofdays.Items.Add(loop);
            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox_empid.Text = "";
            //cmbbox_dept.Text = "";
            cmbbox_month.Text = "";
            cmbbox_year.Text = "";
            cmbbox_noofdays.Text = "";

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            cmd.CommandText = "select Dept_id from Employee where Emp_id='" + txtbox_empid.Text + "'";
            da.Fill(dt);
            cmd.ExecuteNonQuery();

            if (txtbox_empid.Text == "")
            {
                MessageBox.Show("Please Enter Valid Details ");
            }
            else
            {

            string a = dt.Rows[0]["Dept_id"].ToString();
            cmd.CommandText = "select Dept_name from Department where Dept_Id='" + a + "'";
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            string b = dt.Rows[1]["Dept_name"].ToString();

            
            cmd.CommandText =" insert into Attendence values('" + txtbox_empid.Text + "', '" + b + "' , '" + cmbbox_month.Text + "', '" + cmbbox_year.Text + "', '" + cmbbox_noofdays.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Submitted sucessfully");
            con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_empid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_empid_Enter(object sender, EventArgs e)
        {
            if (txtbox_empid.Text == "Enter  Employee  Id")
            {
                txtbox_empid.Text = "";
                txtbox_empid.ForeColor = Color.Black;
            }
        }

        private void cmbbox_month_Enter(object sender, EventArgs e)
        {
            if (cmbbox_month.Text == "Enter  a  month")
            {
                cmbbox_month.Text = "";
                cmbbox_month.ForeColor = Color.Black;
            }
        }

        private void cmbbox_year_Enter(object sender, EventArgs e)
        {
            if (cmbbox_year.Text == "Enter  a  year")
            {
                cmbbox_year.Text = "";
                cmbbox_year.ForeColor = Color.Black;
            }
        }

        private void cmbbox_noofdays_Enter(object sender, EventArgs e)
        {
            if (cmbbox_noofdays.Text == "Enter  total days emp worked in a month")
            {
                cmbbox_noofdays.Text = "";
                cmbbox_noofdays.ForeColor = Color.Black;
            }
        }

       

     
         }

     
}




