namespace Salary_Management
{
    partial class Search
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
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_Employee = new System.Windows.Forms.RadioButton();
            this.rdo_attendence = new System.Windows.Forms.RadioButton();
            this.rdo_department = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.rdo_component = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(213, 334);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(132, 47);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 341);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 110);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Searching Window";
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
            // rdo_attendence
            // 
            this.rdo_attendence.AutoSize = true;
            this.rdo_attendence.Location = new System.Drawing.Point(246, 52);
            this.rdo_attendence.Name = "rdo_attendence";
            this.rdo_attendence.Size = new System.Drawing.Size(101, 21);
            this.rdo_attendence.TabIndex = 8;
            this.rdo_attendence.TabStop = true;
            this.rdo_attendence.Text = "Attendence";
            this.rdo_attendence.UseVisualStyleBackColor = true;
            this.rdo_attendence.CheckedChanged += new System.EventHandler(this.rdo_attendence_CheckedChanged);
            // 
            // rdo_department
            // 
            this.rdo_department.AutoSize = true;
            this.rdo_department.Location = new System.Drawing.Point(466, 52);
            this.rdo_department.Name = "rdo_department";
            this.rdo_department.Size = new System.Drawing.Size(103, 21);
            this.rdo_department.TabIndex = 9;
            this.rdo_department.TabStop = true;
            this.rdo_department.Text = "Department";
            this.rdo_department.UseVisualStyleBackColor = true;
            this.rdo_department.CheckedChanged += new System.EventHandler(this.rdo_department_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_component);
            this.groupBox1.Controls.Add(this.rdo_attendence);
            this.groupBox1.Controls.Add(this.rdo_Employee);
            this.groupBox1.Controls.Add(this.rdo_department);
            this.groupBox1.Location = new System.Drawing.Point(-2, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1234, 135);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose from following to search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee_id";
            // 
            // cmb_1
            // 
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Location = new System.Drawing.Point(213, 276);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(183, 24);
            this.cmb_1.TabIndex = 12;
            // 
            // rdo_component
            // 
            this.rdo_component.AutoSize = true;
            this.rdo_component.Location = new System.Drawing.Point(681, 52);
            this.rdo_component.Name = "rdo_component";
            this.rdo_component.Size = new System.Drawing.Size(143, 21);
            this.rdo_component.TabIndex = 10;
            this.rdo_component.TabStop = true;
            this.rdo_component.Text = "Salary component";
            this.rdo_component.UseVisualStyleBackColor = true;
            this.rdo_component.CheckedChanged += new System.EventHandler(this.rdo_component_CheckedChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.cmb_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdo_Employee;
        private System.Windows.Forms.RadioButton rdo_attendence;
        private System.Windows.Forms.RadioButton rdo_department;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_1;
        private System.Windows.Forms.RadioButton rdo_component;
    }
}

