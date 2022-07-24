using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int ContactId { get; set; }//iş bilgileri
        public int? ReferencesId { get; set; }
        public int EmployeeJobId { get; set; }//iletişim bilgileri
        public int? EmpoyeeEducationInformartionId { get; set; }//eğitim bilgisi
        public string? SummaryInformation { get; set; }//özet bilgi
        public string? HobbiesAndInterests { get; set; }//hobileri ve ilgi alanları
        public City? City { get; set; }
        public Contact Contact { get; set; }
        public List<Reference> References { get; set; }
        public List<EmployeeJob> EmployeeJobs { get; set; }
        public List<EmployeeEducationInformartion> EmployeeEducationInformartions { get; set; }


    }
}
