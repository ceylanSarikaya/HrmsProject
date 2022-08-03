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
    public class EmployerManager:IEmployerService
    {
        IEmployerRepository _employerRepository;

        public EmployerManager(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public Task<IResult> Add(Employer employer)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteById(Employer employer)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<Employer>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Employer>> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(Employer employer)
        {
            throw new NotImplementedException();
        }
    }
}
