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
    public partial class Emp_login : Form
    {
        OdbcConnection con;
        OdbcCommand cmd;
        public static String var1;
        public static String var2;
        public Emp_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OdbcConnection("DSN=salary");
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from login where Emp_id= '"+cmb_empid.Text+"'  ";
            
            OdbcDataReader rdr = cmd.ExecuteReader();

        
            if(rdr.HasRows)
        
            {      
              while(rdr.Read())
            {
                if ( rdr[0].ToString() ==cmb_empid.Text && rdr[1].ToString() == txtbox_Username.Text && rdr[2].ToString() == txtbox_Password.Text)
                {
                    var2 = rdr[0].ToString();
                    MDIParent1 mp = new MDIParent1();
                    var1 = rdr[3].ToString();
                    this.Hide();
                    mp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
          }
          }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
         
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtbox_Password.Text ="";
            txtbox_Username.Text ="";
            cmb_empid.Text = "";
        }

        private void Emp_login_Load(object sender, EventArgs e)
        {
            
            con = new OdbcConnection("DSN=salary");
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login";
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
