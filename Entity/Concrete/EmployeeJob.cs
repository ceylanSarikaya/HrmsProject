
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class EmployeeJob:IEntity
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }//firma adı
        public string? Position { get; set; }//pozisyon
        public string? CompanySector { get; set; }//firma sektörü
        public string? WayOfWorking { get; set; }//çalışma şekli
        public City? City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
