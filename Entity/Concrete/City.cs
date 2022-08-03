using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    /// <summary>
    /// Erzurum
    /// </summary>
    public class City:IEntity
    {
        public int Id { get; set; }
        public string? CityName { get; set; }
        public string? NumberPlate { get; set; }
        [NotMapped]
        public List<Employee>Employees { get; set; }
        [NotMapped]
        public List<Employer> Employers { get; set; }
    }
}
