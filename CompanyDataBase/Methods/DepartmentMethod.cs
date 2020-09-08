using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyDataBase
{
   public class DepartmentMethod:IDepartmentMethod
    {   
        public void AddDept(string deptname)
        {
            var dept = new Department { DepartmentName = deptname };
            using (var context = new ConnectContext())
            {
                context.Departments.Add(dept);
                context.SaveChanges();
            }
        }

        public void DeleteDept(int deptId)
        {
            var dept = new Department { DepartmentId = deptId};
            using (var context = new ConnectContext())
            {
                context.Departments.Remove(dept);
                context.SaveChanges();
            }
        }



        public List<Department> GetDepts()
        {   

           // List<Department> Depts = new List<Department>();
            using (var context = new ConnectContext())
            {

              return  context.Departments.ToList();
            }


        }

      
    }
}
