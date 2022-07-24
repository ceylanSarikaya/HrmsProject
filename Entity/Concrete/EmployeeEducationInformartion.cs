using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class EmployeeEducationInformartion:IEntity
    {
        public int Id { get; set; }
        public string? EducationSatatus { get; set; }//eğitim durumu
        public string? University { get; set; }
        public string? Faculty { get; set; }
        public string? Episode { get; set; }//bölüm
        public City? City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
