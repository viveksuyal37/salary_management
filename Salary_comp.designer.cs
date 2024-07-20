namespace Salary_Management
{
    partial class Salary_comp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_bs = new System.Windows.Forms.TextBox();
            this.txtbox_pf = new System.Windows.Forms.TextBox();
            this.txtbox_da = new System.Windows.Forms.TextBox();
            this.txtbox_hra = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_empid = new System.Windows.Forms.TextBox();
            this.txtbox_desi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1447, 124);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Component";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 556);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Basic Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(893, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "PF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(875, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "HRA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(892, 556);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "DA";
            // 
            // txtbox_bs
            // 
            this.txtbox_bs.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_bs.Location = new System.Drawing.Point(370, 553);
            this.txtbox_bs.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_bs.Name = "txtbox_bs";
            this.txtbox_bs.Size = new System.Drawing.Size(351, 34);
            this.txtbox_bs.TabIndex = 3;
            this.txtbox_bs.Text = "Enter  amount  in  rupees";
            this.txtbox_bs.Enter += new System.EventHandler(this.txtbox_bs_Enter);
            // 
            // txtbox_pf
            // 
            this.txtbox_pf.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_pf.Location = new System.Drawing.Point(1013, 275);
            this.txtbox_pf.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_pf.Name = "txtbox_pf";
            this.txtbox_pf.Size = new System.Drawing.Size(354, 34);
            this.txtbox_pf.TabIndex = 4;
            this.txtbox_pf.Text = "Enter  in  %";
            this.txtbox_pf.Enter += new System.EventHandler(this.txtbox_pf_Enter);
            // 
            // txtbox_da
            // 
            this.txtbox_da.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_da.Location = new System.Drawing.Point(1013, 556);
            this.txtbox_da.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_da.Name = "txtbox_da";
            this.txtbox_da.Size = new System.Drawing.Size(354, 34);
            this.txtbox_da.TabIndex = 6;
            this.txtbox_da.Text = "Enter  in  %";
            this.txtbox_da.Enter += new System.EventHandler(this.txtbox_da_Enter);
            // 
            // txtbox_hra
            // 
            this.txtbox_hra.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_hra.Location = new System.Drawing.Point(1013, 408);
            this.txtbox_hra.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_hra.Name = "txtbox_hra";
            this.txtbox_hra.Size = new System.Drawing.Size(354, 34);
            this.txtbox_hra.TabIndex = 5;
            this.txtbox_hra.Tag = "";
            this.txtbox_hra.Text = "Enter  in  %";
            this.txtbox_hra.Enter += new System.EventHandler(this.txtbox_hra_Enter);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_submit.Location = new System.Drawing.Point(459, 691);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(208, 56);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_reset.Location = new System.Drawing.Point(798, 691);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(5);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(213, 56);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Emp_id";
            // 
            // txtbox_empid
            // 
            this.txtbox_empid.Location = new System.Drawing.Point(370, 275);
            this.txtbox_empid.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_empid.Name = "txtbox_empid";
            this.txtbox_empid.Size = new System.Drawing.Size(351, 34);
            this.txtbox_empid.TabIndex = 1;
            this.txtbox_empid.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // txtbox_desi
            // 
            this.txtbox_desi.Location = new System.Drawing.Point(370, 406);
            this.txtbox_desi.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_desi.Name = "txtbox_desi";
            this.txtbox_desi.Size = new System.Drawing.Size(351, 34);
            this.txtbox_desi.TabIndex = 2;
            // 
            // Salary_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1448, 761);
            this.Controls.Add(this.txtbox_desi);
            this.Controls.Add(this.txtbox_empid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbox_hra);
            this.Controls.Add(this.txtbox_da);
            this.Controls.Add(this.txtbox_pf);
            this.Controls.Add(this.txtbox_bs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Salary_comp";
            this.Text = "Salary component";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_bs;
        private System.Windows.Forms.TextBox txtbox_pf;
        private System.Windows.Forms.TextBox txtbox_da;
        private System.Windows.Forms.TextBox txtbox_hra;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_empid;
        private System.Windows.Forms.TextBox txtbox_desi;
    }
}

