using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.DatabaseContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-G3TH1EU;Integrated Security=True;");
        }
        public DbSet<City>Cities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<EmployeeJob> EmployeeJobs { get; set; }
        public DbSet<Employer> Employers { get; set; }  
        public DbSet<EmployerJob> EmployerJobs { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Reference> References { get; set; }
  

    }
}
