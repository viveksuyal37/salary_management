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
    public partial class Cal_salary : Form
    {
        OdbcConnection con = new OdbcConnection("DSN=salary");
        double Basic;
        double N_Basic;
        public Cal_salary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int loop = 2000; loop <= DateTime.Now.Year; loop++)
            {
                cmbbox_year.Items.Add(loop);
            }

        }

        private void txtbox_Empid_Enter(object sender, EventArgs e)
        {
            if (txtbox_Empid.Text == "Enter Employee Id")
            {
                txtbox_Empid.Text = "";
                txtbox_Empid.ForeColor = Color.Black;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtbox_Empid.Text = "";
            txtbox_Basic.Text = "";
            txtbox_HRA.Text = "";
            txtbox_PF.Text = "";
            txtbox_DA.Text = "";
            txtbox_GrossSalary.Text = "";
            txtbox_TotalSalary.Text = "";
            cmbbox_year.Text = "";
            cmbbox_month.Text = "";
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        { 
            OdbcConnection con = new OdbcConnection("DSN=salary");
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);


            cmd.CommandText = "select no_of_days from Attendence where Emp_id='" + txtbox_Empid.Text + "' And month='"+cmbbox_month.Text+"' And year='"+cmbbox_year.Text+"'"; //fetching no of days employee worked in a month from attendence table.//
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            string no_of_days = dt.Rows[0]["no_of_days"].ToString();
            

            cmd.CommandText = "Select * from Salary_Component where Emp_id='"+ txtbox_Empid.Text+"'";
            OdbcDataReader dr = cmd.ExecuteReader();
            dr.Read();
            String Bs = dr[2].ToString();
            String Pf = dr[3].ToString();
            String Hra = dr[4].ToString();
            String Da = dr[5].ToString();
            
            dr.Close();
            
            cmd.CommandText = "Select Experience from Employee where Emp_id='" + txtbox_Empid.Text + "'";
            OdbcDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            String Exp = rdr[0].ToString();
            
            if (double.Parse(Exp)<1)        
            {
                Basic = int.Parse(Bs);
                N_Basic = (Basic / 30) * int.Parse(no_of_days);
                txtbox_Basic.Text = Convert.ToString(Basic);  
            }
            else if (double.Parse(Exp) >= 1 && double.Parse(Exp) < 5)
            {
                 Basic = int.Parse(Bs)+ 5000;                         //calculating basic salary acc to experience and no of days employee worked.
                 N_Basic = (Basic / 30) * int.Parse(no_of_days);
                txtbox_Basic.Text = Convert.ToString(Basic);
                
            }
            else if (double.Parse(Exp) >= 5 && double.Parse(Exp) < 10)
            {
                 Basic = int.Parse(Bs) + 15000;
                 N_Basic = (Basic / 30) * int.Parse(no_of_days);
                txtbox_Basic.Text = Convert.ToString(Basic);
            }

            else if (double.Parse(Exp) >= 10)
            {
                Basic = int.Parse(Bs) + 25000;
                N_Basic = (Basic / 30) * int.Parse(no_of_days);
                txtbox_Basic.Text = Convert.ToString(Basic);
            }


            


            double c_pf = (int.Parse(Pf) * Basic)/100;
            txtbox_PF.Text = Convert.ToString(c_pf);

            double c_hra = (int.Parse(Hra) * Basic) / 100;
            txtbox_HRA.Text = Convert.ToString(c_hra);

            double c_da = (int.Parse(Da) * Basic) / 100;
            txtbox_DA.Text = Convert.ToString(c_da);

            double gross = N_Basic + c_hra + c_da;
            txtbox_GrossSalary.Text = Convert.ToString(gross);


            double Total = gross -(c_pf);
            txtbox_TotalSalary.Text = Convert.ToString(Total);

            cmd = con.CreateCommand();
            cmd.CommandText = "insert into calculate_salary values('"+txtbox_Empid.Text+"','"+cmbbox_month.Text+"','"+cmbbox_year.Text+"','"+txtbox_Basic.Text+"','"+txtbox_PF.Text+"','"+txtbox_HRA.Text+"','"+txtbox_DA.Text+"','"+gross+"','"+Total+"')";
            cmd.ExecuteNonQuery();
 
            con.Close();
        }

        private void cmbbox_month_Enter(object sender, EventArgs e)
        {
            if (cmbbox_month.Text == "Choose  a  month")
            {
                cmbbox_month.Text = "";
                cmbbox_month.ForeColor = Color.Black;
            }
        }

        private void cmbbox_year_Enter(object sender, EventArgs e)
        {
            if (cmbbox_year.Text == "Choose  a  year")
            {
                cmbbox_year.Text = "";
                cmbbox_year.ForeColor = Color.Black;
            }
        }

    }
}
