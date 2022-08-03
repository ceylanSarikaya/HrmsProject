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
    public class EmployerJobManager:IEmployerJobService
    {
        IEmployerJobRepository _employerJobRepository;

        public Task<IResult> Add(EmployeeJob employeejob)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(EmployeeJob employeejob)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<EmployeeJob>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<EmployeeJob>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(EmployeeJob employeejob)
        {
            throw new NotImplementedException();
        }
    }
}
