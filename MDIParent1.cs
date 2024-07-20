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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

      

        private void employeeRegistrationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Emp_reg a = new Emp_reg();
            a.MdiParent = this;
            a.Show();

        }

        private void salaryComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_comp a = new Salary_comp();
            a.MdiParent = this;
            a.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department a = new Department();
            a.MdiParent = this;
            a.Show();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Designation a = new Designation();
            a.MdiParent = this;
            a.Show();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendence a = new Attendence();
            a.MdiParent = this;
            a.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal_salary a = new Cal_salary();
            a.MdiParent = this;
            a.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            if (Emp_login.var1 == "Normal")
            {
                addNewToolStripMenuItem.Enabled = false;
                attendenceToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }

           
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_info a = new login_info();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart c = new Chart();
            c.MdiParent = this;
            c.Show();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search a = new Search();
            a.MdiParent = this;
            a.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete a = new Delete();
            a.MdiParent = this;
            a.Show();
        }


        
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Myaccount a = new Myaccount();
            a.MdiParent = this;
            
            a.Show();
        }


       
    }
}
      