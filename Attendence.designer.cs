namespace Salary_Management
{
    partial class Attendence
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
            this.txtbox_empid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbox_month = new System.Windows.Forms.ComboBox();
            this.cmbbox_year = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbbox_noofdays = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 112);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendence";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp-id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbox_empid
            // 
            this.txtbox_empid.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_empid.Location = new System.Drawing.Point(296, 191);
            this.txtbox_empid.Name = "txtbox_empid";
            this.txtbox_empid.Size = new System.Drawing.Size(290, 22);
            this.txtbox_empid.TabIndex = 1;
            this.txtbox_empid.Text = "Enter  Employee  Id";
            this.txtbox_empid.TextChanged += new System.EventHandler(this.txtbox_empid_TextChanged);
            this.txtbox_empid.Enter += new System.EventHandler(this.txtbox_empid_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Month";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Year";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.cmbbox_month.Location = new System.Drawing.Point(296, 278);
            this.cmbbox_month.Name = "cmbbox_month";
            this.cmbbox_month.Size = new System.Drawing.Size(288, 24);
            this.cmbbox_month.TabIndex = 3;
            this.cmbbox_month.Text = "Enter  a  month";
            this.cmbbox_month.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbbox_month.Enter += new System.EventHandler(this.cmbbox_month_Enter);
            // 
            // cmbbox_year
            // 
            this.cmbbox_year.ForeColor = System.Drawing.Color.Gray;
            this.cmbbox_year.FormattingEnabled = true;
            this.cmbbox_year.Location = new System.Drawing.Point(298, 362);
            this.cmbbox_year.Name = "cmbbox_year";
            this.cmbbox_year.Size = new System.Drawing.Size(288, 24);
            this.cmbbox_year.TabIndex = 4;
            this.cmbbox_year.Text = "Enter  a  year";
            this.cmbbox_year.Enter += new System.EventHandler(this.cmbbox_year_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "No-of-days";
            // 
            // cmbbox_noofdays
            // 
            this.cmbbox_noofdays.ForeColor = System.Drawing.Color.Gray;
            this.cmbbox_noofdays.FormattingEnabled = true;
            this.cmbbox_noofdays.Location = new System.Drawing.Point(298, 455);
            this.cmbbox_noofdays.Name = "cmbbox_noofdays";
            this.cmbbox_noofdays.Size = new System.Drawing.Size(286, 24);
            this.cmbbox_noofdays.TabIndex = 5;
            this.cmbbox_noofdays.Text = "Enter  total days emp worked in a month";
            this.cmbbox_noofdays.Enter += new System.EventHandler(this.cmbbox_noofdays_Enter);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Green;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(266, 529);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(136, 43);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Red;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(470, 529);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(151, 43);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 584);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cmbbox_noofdays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbbox_year);
            this.Controls.Add(this.cmbbox_month);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_empid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Attendence";
            this.Text = "V";
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
        private System.Windows.Forms.TextBox txtbox_empid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbox_month;
        private System.Windows.Forms.ComboBox cmbbox_year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbox_noofdays;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Clear;
    }
}

