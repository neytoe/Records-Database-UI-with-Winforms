using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CompanyDataBase;

namespace CompanyUI
{
    public partial class DepartmentUI : UserControl 
    {
        
        public DepartmentUI()
        {
            InitializeComponent();
          
        }

        private void DepartmentUI_Load(object sender, EventArgs e)
        {
            this.DeptdataGridView.DataSource = Form1.DeptMethods.GetDepts();
            
        }

        private void CreateDeptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deptnameTextbox.Text != "")
                {
                   Form1.DeptMethods.AddDept(deptnameTextbox.Text);
                    MessageBox.Show($"Dept added succesfully");
                   
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Department Name can not be empty");
            }
            this.DeptdataGridView.DataSource = Form1.DeptMethods.GetDepts();
        }
    }
}
