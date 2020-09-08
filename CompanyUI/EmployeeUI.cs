using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Model;

namespace CompanyUI
{
    public partial class EmployeeUI : UserControl
    {
        public EmployeeUI()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            var combolist = Form1.DeptMethods.GetDepts();
            EmployeedataGridView1.DataSource = Form1.EmpMethods.GetEmployee();

            foreach (var combo in combolist)
            {
                DeptcomboBox.Items.Add(combo.DepartmentName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CreateEmployeeBtn(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.EmpMethods.AddEmployee(
                firstnametbox.Text,
                lastNameTbox.Text,
                emailTbox.Text,
                phonenumTbox.Text,
                DeptdateTimePicker.Value,
                Convert.ToDecimal(salaryTbox.Text),
                DeptcomboBox.Text
                );

            EmployeedataGridView1.DataSource = Form1.EmpMethods.GetEmployee();

            firstnametbox.Clear();
            lastNameTbox.Clear();
            emailTbox.Clear();
            phonenumTbox.Clear();
            salaryTbox.Clear();
        }
    }
}
