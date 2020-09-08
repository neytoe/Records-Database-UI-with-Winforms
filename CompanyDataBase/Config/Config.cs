using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyDataBase.Config
{
   public class Config
    {
        public static ConnectContext MyConnect = new ConnectContext();
        public static IDepartmentMethod MyDeptMethods = new DepartmentMethod();
        public static IEmployeeMethod MyEmployeeMethods = new EmployeeMethods();
    }
}
