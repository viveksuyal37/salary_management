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
    public partial class Salary_comp : Form
    {
        OdbcConnection con = new OdbcConnection("DSN=salary");
        int count = 0;
        public Salary_comp()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtbox_empid.Text = "";
            txtbox_desi.Text = "";
            txtbox_bs.Text = "Enter  amount  in  rupees";
            txtbox_pf.Text = "Enter  in  %";
            txtbox_hra.Text = "Enter  in  %";
            txtbox_da.Text = "Enter  in  %";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
             OdbcDataAdapter da = new OdbcDataAdapter(cmd);
          
            cmd.CommandText = "select Desi_id from Designation where Desi_name= '" + txtbox_desi.Text + "'";
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            
            string a = dt.Rows[0]["Desi_id"].ToString();

            if (txtbox_bs.Text == "Enter  amount  in  rupees" )
            {
                count++;
            }

            if (txtbox_da.Text == "Enter  in  %" )
            {
                count++;
            }

            if (txtbox_hra.Text == "Enter  in  %")
            {
                count++;
            }

            if (txtbox_pf.Text == "Enter  in  %")
            {
                count++;
            }
            if (count > 0)
            {
                MessageBox.Show("Enter Complete data");
            }
            if (count == 0)
            {
                cmd.CommandText = "insert into Salary_component values('" + txtbox_empid.Text + "','" + a + "', '" + txtbox_bs.Text + "', '" + txtbox_pf.Text + "', '" + txtbox_hra.Text + "', '" + txtbox_da.Text + "')";
                
          
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Submitted Sucessfully");

            } con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void cmbbox_desi_Enter(object sender, EventArgs e)
        {
            if (txtbox_desi.Text == "Select  a  Designation")     // placeholder//
            {
                txtbox_desi.Text = "";
                txtbox_desi.ForeColor = Color.Black;
            }
        }

        private void txtbox_bs_Enter(object sender, EventArgs e)
        {
            if (txtbox_bs.Text == "Enter  amount  in  rupees")
            {
                txtbox_bs.Text = "";
                txtbox_bs.ForeColor = Color.Black;
            }
        }

        private void txtbox_pf_Enter(object sender, EventArgs e)
        {
            if (txtbox_pf.Text == "Enter  in  %")
            {
                txtbox_pf.Text = "";
                txtbox_pf.ForeColor = Color.Black;
            }
        }

        private void txtbox_hra_Enter(object sender, EventArgs e)
        {
            if (txtbox_hra.Text == "Enter  in  %")
            {
                txtbox_hra.Text = "";
                txtbox_hra.ForeColor = Color.Black;
            }
        }

        private void txtbox_da_Enter(object sender, EventArgs e)
        {
            if (txtbox_da.Text == "Enter  in  %")
            {
                txtbox_da.Text = "";
                txtbox_da.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
           con.Open();
            OdbcCommand cmd = con.CreateCommand();
            
            cmd.CommandText = "select Desi_name from Designation where Desi_id=any(select Desi_id from Employee where Emp_id= '" + txtbox_empid.Text  + "')";
            // da.Fill(dt);
            
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtbox_desi.Text = dr[0].ToString();

                }
            }
            else {
                MessageBox.Show("This is Employee is not registered ");
            }
            con.Close();
        }


    }
}
