namespace Employee_Details
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeNotextBox = new System.Windows.Forms.TextBox();
            this.basicSalarytextBox = new System.Windows.Forms.TextBox();
            this.allowancetextBox = new System.Windows.Forms.TextBox();
            this.employeeNametextBox = new System.Windows.Forms.TextBox();
            this.designationcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.netSalarytextBox = new System.Windows.Forms.TextBox();
            this.grossSalarytextBox = new System.Windows.Forms.TextBox();
            this.EPFtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.processbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Basic Salary";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Designation";
            // 
            // employeeNotextBox
            // 
            this.employeeNotextBox.Location = new System.Drawing.Point(159, 25);
            this.employeeNotextBox.Name = "employeeNotextBox";
            this.employeeNotextBox.Size = new System.Drawing.Size(159, 20);
            this.employeeNotextBox.TabIndex = 0;
            // 
            // basicSalarytextBox
            // 
            this.basicSalarytextBox.Location = new System.Drawing.Point(159, 107);
            this.basicSalarytextBox.Name = "basicSalarytextBox";
            this.basicSalarytextBox.Size = new System.Drawing.Size(123, 20);
            this.basicSalarytextBox.TabIndex = 2;
            this.basicSalarytextBox.TextChanged += new System.EventHandler(this.basicSalarytextBox_TextChanged);
            // 
            // allowancetextBox
            // 
            this.allowancetextBox.Location = new System.Drawing.Point(159, 141);
            this.allowancetextBox.Name = "allowancetextBox";
            this.allowancetextBox.Size = new System.Drawing.Size(123, 20);
            this.allowancetextBox.TabIndex = 8;
            this.allowancetextBox.TextChanged += new System.EventHandler(this.allowancetextBox_TextChanged);
            // 
            // employeeNametextBox
            // 
            this.employeeNametextBox.Location = new System.Drawing.Point(159, 66);
            this.employeeNametextBox.Name = "employeeNametextBox";
            this.employeeNametextBox.Size = new System.Drawing.Size(267, 20);
            this.employeeNametextBox.TabIndex = 1;
            // 
            // designationcomboBox
            // 
            this.designationcomboBox.FormattingEnabled = true;
            this.designationcomboBox.Items.AddRange(new object[] {
            "Manager",
            "Accountant",
            "Clerk"});
            this.designationcomboBox.Location = new System.Drawing.Point(159, 181);
            this.designationcomboBox.Name = "designationcomboBox";
            this.designationcomboBox.Size = new System.Drawing.Size(121, 21);
            this.designationcomboBox.TabIndex = 3;
            this.designationcomboBox.SelectedIndexChanged += new System.EventHandler(this.designationcomboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.netSalarytextBox);
            this.groupBox1.Controls.Add(this.grossSalarytextBox);
            this.groupBox1.Controls.Add(this.EPFtextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 142);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary Details";
            // 
            // netSalarytextBox
            // 
            this.netSalarytextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.netSalarytextBox.Location = new System.Drawing.Point(198, 95);
            this.netSalarytextBox.Name = "netSalarytextBox";
            this.netSalarytextBox.Size = new System.Drawing.Size(176, 13);
            this.netSalarytextBox.TabIndex = 5;
            // 
            // grossSalarytextBox
            // 
            this.grossSalarytextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grossSalarytextBox.Location = new System.Drawing.Point(198, 59);
            this.grossSalarytextBox.Name = "grossSalarytextBox";
            this.grossSalarytextBox.Size = new System.Drawing.Size(176, 13);
            this.grossSalarytextBox.TabIndex = 4;
            // 
            // EPFtextBox
            // 
            this.EPFtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EPFtextBox.Location = new System.Drawing.Point(198, 28);
            this.EPFtextBox.Name = "EPFtextBox";
            this.EPFtextBox.Size = new System.Drawing.Size(176, 13);
            this.EPFtextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Net Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gross Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "EPF (8% of Basic Salary)";
            // 
            // processbutton
            // 
            this.processbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processbutton.Location = new System.Drawing.Point(330, 415);
            this.processbutton.Name = "processbutton";
            this.processbutton.Size = new System.Drawing.Size(75, 23);
            this.processbutton.TabIndex = 4;
            this.processbutton.Text = "Process";
            this.processbutton.UseVisualStyleBackColor = true;
            this.processbutton.Click += new System.EventHandler(this.processbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(429, 415);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 5;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.processbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.designationcomboBox);
            this.Controls.Add(this.employeeNametextBox);
            this.Controls.Add(this.allowancetextBox);
            this.Controls.Add(this.basicSalarytextBox);
            this.Controls.Add(this.employeeNotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee Salary Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox employeeNotextBox;
        private System.Windows.Forms.TextBox basicSalarytextBox;
        private System.Windows.Forms.TextBox allowancetextBox;
        private System.Windows.Forms.TextBox employeeNametextBox;
        private System.Windows.Forms.ComboBox designationcomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox netSalarytextBox;
        private System.Windows.Forms.TextBox grossSalarytextBox;
        private System.Windows.Forms.TextBox EPFtextBox;
        private System.Windows.Forms.Button processbutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

