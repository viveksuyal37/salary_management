using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Text.RegularExpressions;
using System.IO;

namespace Salary_Management
{
    public partial class Emp_reg : Form
    {
        OdbcConnection con = new OdbcConnection(" DSN=salary");
        string gender = "";
        double Exp;                   // variable used for calculating experience//
        string a;
        string b;
        int count;
        string Emp_id;
        
        public Emp_reg()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();



            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            cmd.CommandText = "select Dept_id from Department where Dept_name='" + cmb_dept.Text + "'"; //fetching dept_id from dept table where dept name is equal to value given in combobox_dept.//
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            a = dt.Rows[0]["Dept_id"].ToString();


            cmd.CommandText = "select Desi_id from Designation where Desi_name='" + cmbbox_desi.Text + "'";
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            b = dt.Rows[1]["Desi_id"].ToString();


            try
            {

                cmd.CommandText = "insert into Employee values('" + txtbox_Empname.Text + "','" + txtbox_Empid.Text + "','" + gender + "','" + txtbox_Address.Text + "','" + txtbox_mobile.Text + "','" + txtbox_Emailid.Text + "','" + Date_Dateofjoining.Text + "', '" + a + "', '" + b + "' , '" + Exp + "','"+savephoto()+"')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Registered Sucessfully");
            }
            catch (Exception)
            {
                MessageBox.Show("This employee is already registered");
            }



            con.Close();
        }

        private byte[] savephoto()    //C# binary data is stored in byte array.
        {
            MemoryStream ms = new MemoryStream();
            imgbox_image1.Image.Save(ms,imgbox_image1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // imgbox_image1="";
            txtbox_Empname.Text = "";
            txtbox_Empid.Text = "";
            cmbbox_desi.Text = "";
            txtbox_Address.Text = "";
            txtbox_mobile.Text = "";
            txtbox_Emailid.Text = "";
            Date_Dateofjoining.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cmb_dept.Text = "";
        }


       




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void Date_Dateofjoining_ValueChanged(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
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
                cmb_dept.Items.Add(dt.Rows[loop]["Dept_name"].ToString());

            }



            OdbcCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from Designation";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            OdbcDataAdapter da2 = new OdbcDataAdapter(cmd2);
            da2.Fill(dt2);
            for (int loop = 0; loop < dt2.Rows.Count; loop++)
            {

                cmbbox_desi.Items.Add(dt2.Rows[loop]["Desi_name"].ToString());

            }
            con.Close();
        }

        private void txtbox_Empname_Enter(object sender, EventArgs e)
        {
            if (txtbox_Empname.Text == "Enter Employee Name")
            {
                txtbox_Empname.Text = "";
                txtbox_Empname.ForeColor = Color.Black;
            }

        }



        private void cmbbox_desi_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbbox_desi.Text == "Select a Designation")
            {
                cmbbox_desi.Text = "";
                cmbbox_desi.ForeColor = Color.Black;
            }
        }

        private void txtbox_Emailid_Enter(object sender, EventArgs e)
        {
            if (txtbox_Emailid.Text == "Example@gmail.com")
            {
                txtbox_Emailid.Text = "";
                txtbox_Emailid.ForeColor = Color.Black;
            }


        }

        private void txtbox_Address_Enter(object sender, EventArgs e)
        {
            if (txtbox_Address.Text == "Input Permanent  Add")
            {
                txtbox_Address.Text = "";
                txtbox_Address.ForeColor = Color.Black;
            }
        }

        private void txtbox_mobile_Enter(object sender, EventArgs e)
        {
            if (txtbox_mobile.Text == "Enter mob no.")
            {
                txtbox_mobile.Text = "";
                txtbox_mobile.ForeColor = Color.Black;
            }
        }

        private void cmb_dept_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmb_dept.Text == "Select a Department")
            {
                cmb_dept.Text = "";
                cmb_dept.ForeColor = Color.Black;
            }
        }

        private void Date_Dateofjoining_Leave(object sender, EventArgs e)
        {
            DateTime from = Date_Dateofjoining.Value;
            DateTime to = DateTime.Now;
            TimeSpan tspan = to - from;
            double days = tspan.TotalDays;
            Exp = (days / 365);              //  to calculate experience in years. 
            Math.Round(Exp, 2);




        }

        private void cmbbox_desi_Enter(object sender, EventArgs e)
        {
            if (cmbbox_desi.Text == "Select a Designation")
            {
                cmbbox_desi.Text = "";
                cmbbox_desi.ForeColor = Color.Black;
            }
        }

        private void txtbox_mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String imageLocation = "";


            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| ALL Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();

                imgbox_image1.ImageLocation = imageLocation;
            }
        }

        private void txtbox_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;   //rejects the input.
                MessageBox.Show("only numeric values are allowed");
            }
            {
                if (txtbox_mobile.Text.Length > 10)
                {
                    e.Handled = true;
                    MessageBox.Show("Contact number could not exceeds 10 digits.");

                }
            }
          

        }

        private void txtbox_Empname_Leave(object sender, EventArgs e)
        {
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            OdbcDataReader dr;
            cmd.CommandText = "select * from Employee";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    count++;
                }
            }
            count++;
            Emp_id = "E" + count;
            txtbox_Empid.Text = Emp_id;
            count = 0;
            con.Close();
        }

        private void cmbbox_desi_Validating(object sender, CancelEventArgs e)
        {
            if (cmbbox_desi.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbbox_desi, "Choose a designation !! ");
            }
            else {
                errorProvider1.Clear();
            }
        }

        private void cmb_dept_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_dept.Text == "")
            {
                e.Cancel = true;
                errorProvider2.SetError(cmb_dept , "Choose a department !! ");
                
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void txtbox_Emailid_Leave(object sender, EventArgs e)
        { 
            string pattern = "@gmail.com";
               if (Regex.IsMatch(txtbox_Emailid.Text,pattern))
              {
                errorProvider3.Clear();
               }
            else {
               
                errorProvider3.SetError(this.txtbox_Emailid,"Please enter a valid email !!");
                return;
            }

        }
    }
}

