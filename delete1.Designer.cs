namespace Salary_Management
{
    partial class Delete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Desig = new System.Windows.Forms.RadioButton();
            this.rdo_Employee = new System.Windows.Forms.RadioButton();
            this.rdo_department = new System.Windows.Forms.RadioButton();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deleting Window";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Desig);
            this.groupBox1.Controls.Add(this.rdo_Employee);
            this.groupBox1.Controls.Add(this.rdo_department);
            this.groupBox1.Location = new System.Drawing.Point(0, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose from following to delete :-";
            // 
            // rdo_Desig
            // 
            this.rdo_Desig.AutoSize = true;
            this.rdo_Desig.Location = new System.Drawing.Point(208, 52);
            this.rdo_Desig.Name = "rdo_Desig";
            this.rdo_Desig.Size = new System.Drawing.Size(104, 21);
            this.rdo_Desig.TabIndex = 8;
            this.rdo_Desig.TabStop = true;
            this.rdo_Desig.Text = "Designation";
            this.rdo_Desig.UseVisualStyleBackColor = true;
            this.rdo_Desig.CheckedChanged += new System.EventHandler(this.rdo_Desig_CheckedChanged);
            // 
            // rdo_Employee
            // 
            this.rdo_Employee.AutoSize = true;
            this.rdo_Employee.Location = new System.Drawing.Point(42, 52);
            this.rdo_Employee.Name = "rdo_Employee";
            this.rdo_Employee.Size = new System.Drawing.Size(91, 21);
            this.rdo_Employee.TabIndex = 7;
            this.rdo_Employee.TabStop = true;
            this.rdo_Employee.Text = "Employee";
            this.rdo_Employee.UseVisualStyleBackColor = true;
            this.rdo_Employee.CheckedChanged += new System.EventHandler(this.rdo_Employee_CheckedChanged);
            // 
            // rdo_department
            // 
            this.rdo_department.AutoSize = true;
            this.rdo_department.Location = new System.Drawing.Point(367, 52);
            this.rdo_department.Name = "rdo_department";
            this.rdo_department.Size = new System.Drawing.Size(103, 21);
            this.rdo_department.TabIndex = 9;
            this.rdo_department.TabStop = true;
            this.rdo_department.Text = "Department";
            this.rdo_department.UseVisualStyleBackColor = true;
            this.rdo_department.CheckedChanged += new System.EventHandler(this.rdo_department_CheckedChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(443, 220);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 40);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(208, 229);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(198, 24);
            this.cmb1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Employee_id";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Desig;
        private System.Windows.Forms.RadioButton rdo_Employee;
        private System.Windows.Forms.RadioButton rdo_department;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label2;
    }
}