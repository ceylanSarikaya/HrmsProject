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
    public class EmployeeJobManager:IEmployeeJobService
    {
        IEmployeeJobRepository _employeeJobRepository;

        public EmployeeJobManager(IEmployeeJobRepository employeeJobRepository)
        {
            _employeeJobRepository = employeeJobRepository;
        }

        public Task<IResult> Add(EmployerJob job)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(EmployerJob employerJob)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<EmployerJob>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<EmployerJob>> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(EmployerJob job)
        {
            throw new NotImplementedException();
        }
    }
}
