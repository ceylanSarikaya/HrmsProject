using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Employer:IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int ContactId { get; set; }
        public int EmployerJobId { get; set; }
        public string? CompanyName { get; set; }//firma adı
        public City? City { get; set; }
        public List<EmployerJob>? EmployerJobs { get; set; }
        public Contact? Contact { get; set; }
    }
}
