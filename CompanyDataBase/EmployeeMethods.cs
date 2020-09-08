using System;
using System.Collections.Generic;
using System.Text;
using CompanyDataBase;

namespace Model
{
   public class EmployeeMethods
    {
        public void AddEmployee()
        {
            using(var context = new ConnectContext())
            {
                var person = new Employee();
                
                context.Add(person);
            }
        }

    }
}
