using Core.DataAccess;
using Core.Utilities.Results;
using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityService
    {
       //Task< List<City>> GetAll();
       // Task<City>  GetById(int id);
        Task<IResult> Add(City city);
        Task<IResult> Update(City city);
        Task Delete(City city);
        Task<IDataResult<List<City>>> GetAll();

    }
}
