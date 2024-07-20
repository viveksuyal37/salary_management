namespace Salary_Management
{
    partial class Department
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Deptid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_DeptName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_DeptHead = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 138);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dept-id";
            // 
            // txtbox_Deptid
            // 
            this.txtbox_Deptid.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_Deptid.Location = new System.Drawing.Point(317, 225);
            this.txtbox_Deptid.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Deptid.Name = "txtbox_Deptid";
            this.txtbox_Deptid.Size = new System.Drawing.Size(297, 28);
            this.txtbox_Deptid.TabIndex = 1;
            this.txtbox_Deptid.Text = "Enter Dept_ID";
            this.txtbox_Deptid.Enter += new System.EventHandler(this.txtbox_Deptid_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dept-Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbox_DeptName
            // 
            this.txtbox_DeptName.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_DeptName.Location = new System.Drawing.Point(317, 316);
            this.txtbox_DeptName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_DeptName.Name = "txtbox_DeptName";
            this.txtbox_DeptName.Size = new System.Drawing.Size(297, 28);
            this.txtbox_DeptName.TabIndex = 2;
            this.txtbox_DeptName.Text = "Enter Dept_Name";
            this.txtbox_DeptName.Enter += new System.EventHandler(this.txtbox_DeptName_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dept-Head";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbox_DeptHead
            // 
            this.txtbox_DeptHead.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_DeptHead.Location = new System.Drawing.Point(317, 399);
            this.txtbox_DeptHead.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_DeptHead.Name = "txtbox_DeptHead";
            this.txtbox_DeptHead.Size = new System.Drawing.Size(297, 28);
            this.txtbox_DeptHead.TabIndex = 6;
            this.txtbox_DeptHead.Text = "Enter Head Of Department";
            this.txtbox_DeptHead.Enter += new System.EventHandler(this.txtbox_DeptHead_Enter);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Submit.Location = new System.Drawing.Point(286, 483);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(142, 51);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Red;
            this.btn_reset.Location = new System.Drawing.Point(501, 483);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(145, 51);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(891, 568);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtbox_DeptHead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_DeptName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_Deptid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Department";
            this.Text = "Add New Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_Deptid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_DeptName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_DeptHead;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_reset;
    }
}

