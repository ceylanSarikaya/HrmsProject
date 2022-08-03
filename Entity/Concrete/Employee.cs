
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int ContactId { get; set; }//iletişim bilgileri
        public int? ReferencesId { get; set; }
        public int EmployeeJobId { get; set; }//iletişim bilgileri
        public int? EmpoyeeEducationId { get; set; }//eğitim bilgisi
        public string? SummaryInformation { get; set; }//özet bilgi
        public string? HobbiesAndInterests { get; set; }//hobileri ve ilgi alanları
        [NotMapped]
        public City? City { get; set; }
        [NotMapped]
        public Contact? Contact { get; set; }
        [NotMapped]
        public List<Reference>? References { get; set; }
        [NotMapped]
        public List<EmployeeJob>? EmployeeJobs { get; set; }
        [NotMapped]
        public List<EmployeeEducation>? EmployeeEducation{ get; set; }


    }
}
