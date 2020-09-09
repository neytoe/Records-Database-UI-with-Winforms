using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CompanyDataBase;
using Microsoft.EntityFrameworkCore;

namespace Model
{
   public class EmployeeMethods: IEmployeeMethod
    {
        //create an instance of the ConnectContext class
        ConnectContext context = new ConnectContext();
        public void AddEmployee(string fname, string lname,string email, string phoneNum,DateTime date, decimal salary,string dept)
        {
            var person = new Employee {
                FirstName = fname,
                LastName = lname,
                Email = email,
                PhoneNumber = phoneNum,
                Salary = salary,
                HireDate=date
            };

            var d = context.Departments.Where(x => x.DepartmentName == dept).FirstOrDefault();
            person.Department = d;

            context.Employees.Add(person);
            context.SaveChanges();
        }

        public IEnumerable GetEmployee()
        {
            return context.Employees.Include(s => s.Department).Select(e => new { e.EmployeeId, e.FirstName, e.LastName, e.Email, e.PhoneNumber, e.HireDate, e.Salary, e.Department.DepartmentId, e.Department.DepartmentName }).ToList();
        }

        public void UpdateEmployee(int empid)
        {

        }

        public void DeleteEmployee(int empid)
        {
            var emp = context.Employees.Find(empid);

            if (emp != null)
            {
                context.Employees.Remove(emp);

                context.SaveChanges();
            }
        }

        public void UpdateEmployee(int id,string fname, string lname, string email, string phoneNum, DateTime date, decimal salary, string dept)
        {
            var person = new Employee
            {   
                EmployeeId=id,
                FirstName = fname,
                LastName = lname,
                Email = email,
                PhoneNumber = phoneNum,
                Salary = salary,
                HireDate = date
            };

            var d = context.Departments.Where(x => x.DepartmentName == dept).FirstOrDefault();
            person.Department = d;

            context.Employees.Update(person);
            context.SaveChanges();
        }
    }
}
