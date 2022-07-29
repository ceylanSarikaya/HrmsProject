using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Resume:IEntity
    {
        //özgeçmiş belgesi
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? FilePath { get; set; }
    }
}
