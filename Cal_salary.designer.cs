namespace Salary_Management
{
    partial class Cal_salary
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
            this.txtbox_Empid = new System.Windows.Forms.TextBox();
            this.txtbox_Basic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_HRA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_PF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_DA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_GrossSalary = new System.Windows.Forms.TextBox();
            this.txtbox_TotalSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbbox_month = new System.Windows.Forms.ComboBox();
            this.cmbbox_year = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 111);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Calculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp-id";
            // 
            // txtbox_Empid
            // 
            this.txtbox_Empid.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_Empid.Location = new System.Drawing.Point(218, 224);
            this.txtbox_Empid.Name = "txtbox_Empid";
            this.txtbox_Empid.Size = new System.Drawing.Size(260, 22);
            this.txtbox_Empid.TabIndex = 1;
            this.txtbox_Empid.TabStop = false;
            this.txtbox_Empid.Text = "Enter Employee Id";
            this.txtbox_Empid.Enter += new System.EventHandler(this.txtbox_Empid_Enter);
            // 
            // txtbox_Basic
            // 
            this.txtbox_Basic.Enabled = false;
            this.txtbox_Basic.Location = new System.Drawing.Point(218, 400);
            this.txtbox_Basic.Name = "txtbox_Basic";
            this.txtbox_Basic.Size = new System.Drawing.Size(260, 22);
            this.txtbox_Basic.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calculated Bs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Calculated HRA";
            // 
            // txtbox_HRA
            // 
            this.txtbox_HRA.Enabled = false;
            this.txtbox_HRA.Location = new System.Drawing.Point(218, 454);
            this.txtbox_HRA.Name = "txtbox_HRA";
            this.txtbox_HRA.Size = new System.Drawing.Size(260, 22);
            this.txtbox_HRA.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(559, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Calculated PF";
            // 
            // txtbox_PF
            // 
            this.txtbox_PF.Enabled = false;
            this.txtbox_PF.Location = new System.Drawing.Point(714, 226);
            this.txtbox_PF.Name = "txtbox_PF";
            this.txtbox_PF.Size = new System.Drawing.Size(264, 22);
            this.txtbox_PF.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Calculated DA";
            // 
            // txtbox_DA
            // 
            this.txtbox_DA.Enabled = false;
            this.txtbox_DA.Location = new System.Drawing.Point(714, 293);
            this.txtbox_DA.Name = "txtbox_DA";
            this.txtbox_DA.Size = new System.Drawing.Size(264, 22);
            this.txtbox_DA.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gross Salary";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.Green;
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.Black;
            this.btn_Calculate.Location = new System.Drawing.Point(345, 526);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(156, 43);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Red;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(563, 526);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(151, 43);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Salary";
            // 
            // txtbox_GrossSalary
            // 
            this.txtbox_GrossSalary.Enabled = false;
            this.txtbox_GrossSalary.Location = new System.Drawing.Point(714, 354);
            this.txtbox_GrossSalary.Name = "txtbox_GrossSalary";
            this.txtbox_GrossSalary.Size = new System.Drawing.Size(264, 22);
            this.txtbox_GrossSalary.TabIndex = 12;
            // 
            // txtbox_TotalSalary
            // 
            this.txtbox_TotalSalary.Enabled = false;
            this.txtbox_TotalSalary.Location = new System.Drawing.Point(714, 425);
            this.txtbox_TotalSalary.Name = "txtbox_TotalSalary";
            this.txtbox_TotalSalary.Size = new System.Drawing.Size(264, 22);
            this.txtbox_TotalSalary.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Year";
            // 
            // cmbbox_month
            // 
            this.cmbbox_month.ForeColor = System.Drawing.Color.Gray;
            this.cmbbox_month.FormattingEnabled = true;
            this.cmbbox_month.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cmbbox_month.Location = new System.Drawing.Point(218, 290);
            this.cmbbox_month.Name = "cmbbox_month";
            this.cmbbox_month.Size = new System.Drawing.Size(260, 24);
            this.cmbbox_month.TabIndex = 19;
            this.cmbbox_month.Text = "Choose  a  month";
            this.cmbbox_month.Enter += new System.EventHandler(this.cmbbox_month_Enter);
            // 
            // cmbbox_year
            // 
            this.cmbbox_year.ForeColor = System.Drawing.Color.Gray;
            this.cmbbox_year.FormattingEnabled = true;
            this.cmbbox_year.Location = new System.Drawing.Point(218, 341);
            this.cmbbox_year.Name = "cmbbox_year";
            this.cmbbox_year.Size = new System.Drawing.Size(260, 24);
            this.cmbbox_year.TabIndex = 20;
            this.cmbbox_year.Text = "Choose  a  year";
            this.cmbbox_year.Enter += new System.EventHandler(this.cmbbox_year_Enter);
            // 
            // Cal_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1010, 594);
            this.Controls.Add(this.cmbbox_year);
            this.Controls.Add(this.cmbbox_month);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_TotalSalary);
            this.Controls.Add(this.txtbox_GrossSalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbox_DA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_PF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_HRA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_Basic);
            this.Controls.Add(this.txtbox_Empid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Cal_salary";
            this.Text = "Employee Salary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_Empid;
        private System.Windows.Forms.TextBox txtbox_Basic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_HRA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_PF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_DA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_GrossSalary;
        private System.Windows.Forms.TextBox txtbox_TotalSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbbox_month;
        private System.Windows.Forms.ComboBox cmbbox_year;
    }
}

