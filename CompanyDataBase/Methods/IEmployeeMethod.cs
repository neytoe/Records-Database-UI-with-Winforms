using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompanyDataBase
{
    public interface IEmployeeMethod
    {

        public void AddEmployee(string fname, string lname, string email, string phoneNum, DateTime date, decimal salary, string dept);

        public IEnumerable GetEmployee();

        public void UpdateEmployee(int id,string fname, string lname, string email, string phoneNum, DateTime date, decimal salary, string dept);

        public void DeleteEmployee(int empId);
    }
}
