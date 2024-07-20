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
    public partial class Designation : Form
    {
        OdbcConnection con = new OdbcConnection("DSN=salary");
        public Designation()
        {
            InitializeComponent();
        }

        private void Designation_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            con.Open();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Designation values('"+txtbox_desiid.Text +"','"+txtbox_desiname.Text +"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Designation submitted sucessfully");
            con.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtbox_desiid.Text = "";
            txtbox_desiname.Text = "";
        }
    }
}
