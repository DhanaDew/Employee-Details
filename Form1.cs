using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void designationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (designationcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a designation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                designationcomboBox.Focus();
                return;
            }

            string selectDegnation = designationcomboBox.SelectedItem.ToString();
        }

        private void basicSalarytextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void allowancetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void processbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeNotextBox.Text)|| string.IsNullOrWhiteSpace(employeeNametextBox.Text))
            {
                MessageBox.Show("Please enter Values!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(basicSalarytextBox.Text, out decimal basicSalary))
            {
                MessageBox.Show("Please enter a valid value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                basicSalarytextBox.Focus();
                basicSalarytextBox.SelectAll();
                return;
            }
            decimal allowancePercentage = 0;

            if (basicSalary >= 35000 && basicSalary <= 70000)
            {
                allowancePercentage = 0.15m;
            }
            else if (basicSalary > 70000 && basicSalary <= 150000)
            {
                allowancePercentage = 0.20m;
            }
            else if (basicSalary > 150000 && basicSalary <= 300000)
            {
                allowancePercentage = 0.25m;
            }
            else
            {
                MessageBox.Show("Salary is out of the valid range.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal allowanceAmount = basicSalary * allowancePercentage;
            decimal epf = basicSalary * 0.08m;
            decimal grossSalary = basicSalary + allowanceAmount;
            decimal netSalary = grossSalary - epf;

            allowancetextBox.Text = allowanceAmount.ToString();
            EPFtextBox.Text= epf.ToString();    
            grossSalarytextBox.Text = grossSalary.ToString();
            netSalarytextBox.Text = netSalary.ToString();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            employeeNotextBox.Clear();
            employeeNametextBox.Clear();
            basicSalarytextBox.Clear();
            allowancetextBox.Clear();
            EPFtextBox.Clear();
            grossSalarytextBox.Clear();
            netSalarytextBox.Clear();

            designationcomboBox.Text = string.Empty;

            employeeNotextBox.Focus();
        }
    }
}
