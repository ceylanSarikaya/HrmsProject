using Business.Abstract;
using Core.Utilities.Results;
using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        //constructor = Data acsess katmanına bagımlılıgını gösteriyor
        ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public Task<IResult> Add(City city)
        {
            throw new NotImplementedException();
        }

        public Task Delete(City city)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<City>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}
