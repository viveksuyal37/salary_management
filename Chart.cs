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
    public partial class Chart : Form
    {
        OdbcConnection con = new OdbcConnection("DSN=Salary");

        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
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
                cmbbox_empid.Items.Add(dt.Rows[loop]["Emp_id"].ToString());

            }

            con.Close();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            chart1.Series["Total_Salary"].Points.Clear();
            chart1.Series["Gross_Salary"].Points.Clear();
            con.Open();
            OdbcCommand cmd = new OdbcCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from calculate_salary where Emp_id='"+cmbbox_empid.Text+"'";
            OdbcDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                chart1.Series["Total_Salary"].Points.AddXY(rdr[1].ToString(),rdr[8].ToString());
                chart1.Series["Gross_Salary"].Points.AddXY(rdr[1].ToString(), rdr[7].ToString());
            }
       
            con.Close();
        }

      
    }
}
