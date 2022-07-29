using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class EmployerJob:IEntity
    {
        //iş
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? WayOfWorking { get; set; }//çalışma şekli
        public string? Experience { get; set; }//tecrübe
        public string? Department { get; set; }//departman
        public string? Explanation { get; set; }//açıklama
        public string? ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
