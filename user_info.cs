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
    public partial class login_info : Form
    {
        OdbcConnection con = new OdbcConnection("DSN=salary");

        public login_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox_uname.Text = "";
            txt_pss.Text = "";
            cmbbox_type.Text = "";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {  
           OdbcConnection con = new OdbcConnection("DSN=salary");
            con.Open();
            OdbcCommand cmd=con.CreateCommand();
            cmd.CommandText = "insert into login values('"+cmb_empid.Text+"','"+txtbox_uname.Text+"','"+txt_pss.Text+"','"+cmbbox_type.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Details Added sucessfully");
            con.Close();
        }

        private void login_info_Load(object sender, EventArgs e)
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
               cmb_empid.Items.Add(dt.Rows[loop]["Emp_id"].ToString());

            }
            con.Close();
        }

    }
}
