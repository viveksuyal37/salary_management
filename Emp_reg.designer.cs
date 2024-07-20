namespace Salary_Management
{
    partial class Emp_reg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_reg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_Empname = new System.Windows.Forms.TextBox();
            this.txtbox_Empid = new System.Windows.Forms.TextBox();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.txtbox_mobile = new System.Windows.Forms.TextBox();
            this.txtbox_Emailid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Date_Dateofjoining = new System.Windows.Forms.DateTimePicker();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_dept = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbbox_desi = new System.Windows.Forms.ComboBox();
            this.imgbox_image1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Emp-name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Emp-id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(661, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(646, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email-id";
            // 
            // txtbox_Empname
            // 
            this.txtbox_Empname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Empname.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_Empname.Location = new System.Drawing.Point(200, 203);
            this.txtbox_Empname.Multiline = true;
            this.txtbox_Empname.Name = "txtbox_Empname";
            this.txtbox_Empname.Size = new System.Drawing.Size(324, 39);
            this.txtbox_Empname.TabIndex = 0;
            this.txtbox_Empname.Text = "Enter Employee Name";
            this.txtbox_Empname.Enter += new System.EventHandler(this.txtbox_Empname_Enter);
            this.txtbox_Empname.Leave += new System.EventHandler(this.txtbox_Empname_Leave);
            // 
            // txtbox_Empid
            // 
            this.txtbox_Empid.Enabled = false;
            this.txtbox_Empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Empid.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_Empid.Location = new System.Drawing.Point(200, 304);
            this.txtbox_Empid.Multiline = true;
            this.txtbox_Empid.Name = "txtbox_Empid";
            this.txtbox_Empid.Size = new System.Drawing.Size(324, 35);
            this.txtbox_Empid.TabIndex = 1;
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Address.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_Address.Location = new System.Drawing.Point(200, 571);
            this.txtbox_Address.Multiline = true;
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(324, 97);
            this.txtbox_Address.TabIndex = 5;
            this.txtbox_Address.Text = "Input Permanent  Add";
            this.txtbox_Address.Enter += new System.EventHandler(this.txtbox_Address_Enter);
            // 
            // txtbox_mobile
            // 
            this.txtbox_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_mobile.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_mobile.Location = new System.Drawing.Point(809, 198);
            this.txtbox_mobile.Multiline = true;
            this.txtbox_mobile.Name = "txtbox_mobile";
            this.txtbox_mobile.Size = new System.Drawing.Size(332, 41);
            this.txtbox_mobile.TabIndex = 6;
            this.txtbox_mobile.Text = "Enter mob no.";
            this.txtbox_mobile.TextChanged += new System.EventHandler(this.txtbox_mobile_TextChanged);
            this.txtbox_mobile.Enter += new System.EventHandler(this.txtbox_mobile_Enter);
            this.txtbox_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_mobile_KeyPress);
            // 
            // txtbox_Emailid
            // 
            this.txtbox_Emailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Emailid.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_Emailid.Location = new System.Drawing.Point(809, 315);
            this.txtbox_Emailid.Multiline = true;
            this.txtbox_Emailid.Name = "txtbox_Emailid";
            this.txtbox_Emailid.Size = new System.Drawing.Size(332, 33);
            this.txtbox_Emailid.TabIndex = 7;
            this.txtbox_Emailid.Text = "Example@gmail.com";
            this.txtbox_Emailid.Enter += new System.EventHandler(this.txtbox_Emailid_Enter);
            this.txtbox_Emailid.Leave += new System.EventHandler(this.txtbox_Emailid_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(588, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date of joining";
            // 
            // Date_Dateofjoining
            // 
            this.Date_Dateofjoining.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Dateofjoining.Location = new System.Drawing.Point(809, 543);
            this.Date_Dateofjoining.Name = "Date_Dateofjoining";
            this.Date_Dateofjoining.Size = new System.Drawing.Size(332, 34);
            this.Date_Dateofjoining.TabIndex = 9;
            this.Date_Dateofjoining.ValueChanged += new System.EventHandler(this.Date_Dateofjoining_ValueChanged);
            this.Date_Dateofjoining.Leave += new System.EventHandler(this.Date_Dateofjoining_Leave);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(422, 705);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(175, 54);
            this.btn_Register.TabIndex = 10;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(711, 705);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(186, 54);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Reset";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1547, 126);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(517, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(451, 49);
            this.label8.TabIndex = 0;
            this.label8.Text = "Employee Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(64, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 27;
            this.label9.Text = "Gender";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(217, 485);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 33);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "M\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(363, 485);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 33);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "F\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(617, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Department";
            // 
            // cmb_dept
            // 
            this.cmb_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dept.ForeColor = System.Drawing.Color.Gray;
            this.cmb_dept.FormattingEnabled = true;
            this.cmb_dept.Location = new System.Drawing.Point(809, 424);
            this.cmb_dept.Name = "cmb_dept";
            this.cmb_dept.Size = new System.Drawing.Size(332, 37);
            this.cmb_dept.TabIndex = 8;
            this.cmb_dept.Text = "Select a Department";
            this.cmb_dept.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_dept_MouseClick);
            this.cmb_dept.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_dept_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "Designation";
            // 
            // cmbbox_desi
            // 
            this.cmbbox_desi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_desi.ForeColor = System.Drawing.Color.Gray;
            this.cmbbox_desi.FormattingEnabled = true;
            this.cmbbox_desi.Location = new System.Drawing.Point(200, 401);
            this.cmbbox_desi.Name = "cmbbox_desi";
            this.cmbbox_desi.Size = new System.Drawing.Size(324, 37);
            this.cmbbox_desi.TabIndex = 2;
            this.cmbbox_desi.Text = "Select a Designation";
            this.cmbbox_desi.Enter += new System.EventHandler(this.cmbbox_desi_Enter);
            this.cmbbox_desi.Validating += new System.ComponentModel.CancelEventHandler(this.cmbbox_desi_Validating);
            // 
            // imgbox_image1
            // 
            this.imgbox_image1.BackColor = System.Drawing.Color.White;
            this.imgbox_image1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgbox_image1.ErrorImage")));
            this.imgbox_image1.Location = new System.Drawing.Point(1228, 178);
            this.imgbox_image1.Name = "imgbox_image1";
            this.imgbox_image1.Size = new System.Drawing.Size(262, 275);
            this.imgbox_image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbox_image1.TabIndex = 33;
            this.imgbox_image1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1258, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 51);
            this.button1.TabIndex = 34;
            this.button1.Text = "Upload img";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Emp_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1546, 801);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgbox_image1);
            this.Controls.Add(this.cmbbox_desi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_dept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.Date_Dateofjoining);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_Emailid);
            this.Controls.Add(this.txtbox_mobile);
            this.Controls.Add(this.txtbox_Address);
            this.Controls.Add(this.txtbox_Empid);
            this.Controls.Add(this.txtbox_Empname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Emp_reg";
            this.Text = "Add new Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_Empname;
        private System.Windows.Forms.TextBox txtbox_Empid;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.TextBox txtbox_mobile;
        private System.Windows.Forms.TextBox txtbox_Emailid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date_Dateofjoining;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_dept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbbox_desi;
        private System.Windows.Forms.PictureBox imgbox_image1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

