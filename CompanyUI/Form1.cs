﻿using CompanyDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyUI
{
    public partial class Form1 : Form
    {
        ConnectContext Connect;
        public static IEmployeeMethod EmpMethods { get; set; }
        public static IDepartmentMethod DeptMethods { get; set; }
        public Form1(ConnectContext connect, IDepartmentMethod deptMethods, IEmployeeMethod empMethods)
        {
            InitializeComponent();
            Connect = connect;
            EmpMethods = empMethods;
            DeptMethods = deptMethods;

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeeui1.Hide();
            queriesui1.Hide();
            departmentui1.Hide();
        }

        private void NavigateEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeeui1.Show();
            employeeui1.BringToFront();
            queriesui1.Hide();
            departmentui1.Hide();
        }

        private void NavigateDeptPage_Click(object sender, EventArgs e)
        {
            employeeui1.Hide();
            queriesui1.Hide();
            departmentui1.Show();
            departmentui1.BringToFront();

        }

        private void NavigateQueriesBtn_Click(object sender, EventArgs e)
        {
            employeeui1.Hide();
            departmentui1.Hide();
            queriesui1.Show();
            departmentui1.BringToFront();

        }

        private void NavigateHomeBtn_Click(object sender, EventArgs e)
        {
            employeeui1.Hide();
            queriesui1.Hide();
            departmentui1.Hide();
        }

        private void departmentui1_Load(object sender, EventArgs e)
        {

        }
    }
}
