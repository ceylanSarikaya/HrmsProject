using Core.DataAccess.EntityFramework;
using Data.Abstract;
using Data.Concrete.DatabaseContext;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City,Context>,ICityRepository
    {
      
    }
}
