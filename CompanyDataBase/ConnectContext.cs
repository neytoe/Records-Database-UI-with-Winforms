using Microsoft.EntityFrameworkCore;
using Model;

namespace CompanyDataBase
{
    public class ConnectContext :DbContext
    {

        public  DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (LocalDB)\\MSSQLLocalDB; Database = CompanyDB; Trusted_Connection = True;"
                );

        }


    }
}
