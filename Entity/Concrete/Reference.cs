using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Reference:IEntity
    {
        public int Id { get; set; }
        public string? ReferenceName{ get; set; }
        public string? ReferenceSurname { get; set; }
        public string? CompanyName { get; set; }//çalıştığı firma adı
        public string? PositionInTheCompany { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
