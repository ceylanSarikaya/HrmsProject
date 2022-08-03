using Business.Abstract;
using Business.Constants;
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

        public async Task<IResult> Add(City city)
        {
            await _cityRepository.AddAsync(city);
            return  new SuccessResult(Messages.MessageAdd);
            
        }

        public async Task<IResult> Delete(City city)
        {
            await _cityRepository.DeleteAsync(city);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<City>>> GetAll()
        {
           var result= await _cityRepository.GetAllAsync();
            return new SuccessDataResult<List<City>> (result.ToList(),Messages.MessageGetAll);
        }

        public async Task<IDataResult<City>> GetById(int id)
        {
            var result = await _cityRepository.GetAsync(c => c.Id == id);
            return new SuccessDataResult<City>(result);
        }

        public async Task<IResult> Update(City city)
        {
            await _cityRepository.UpdateAsync(city);
            return new SuccessResult();
        }
    }
}
