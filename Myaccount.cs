using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;


namespace Salary_Management
{
    public partial class Myaccount : Form
    {
        public Myaccount()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdbcConnection con = new OdbcConnection("DSN=salary");
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from login where Emp_id='" + Emp_login.var2 + "'";
            OdbcDataReader dr = cmd.ExecuteReader();
            dr.Read();
            label4.Text = dr[1].ToString();
            label2.Text = dr[0].ToString();
            label6.Text = dr[3].ToString();

            dr.Close();



            OdbcCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "Select * from Employee where Emp_id='" + Emp_login.var2 + "'";
            OdbcDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
            label8.Text = dr2[6].ToString();
            label10.Text = dr2[9].ToString() + " Year";


         //   pictureBox1.Image = loadphoto((byte[])dr2[10]);
            dr2.Close();


       
           
           con.Close();

        }

   /*     private Image loadphoto(byte[] p)
        {
            MemoryStream ms = new MemoryStream(p);
            return Image.FromStream(ms);
        }
        */



        private void button1_Click(object sender, EventArgs e)
        {

            Application.Restart();

        }


    }
}


