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
    public class EmployeEducationManager:IEmployeeEducationService
    {
        IEmployeeEducationRepository _employeeEducationRepository;

        public EmployeEducationManager(IEmployeeEducationRepository employeeEducationRepository)
        {
            _employeeEducationRepository = employeeEducationRepository;
        }

        public Task<IResult> Add(EmployeeEducation entity)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(EmployeeEducation employeeEducation)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<EmployeeEducation>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<EmployeeEducation>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(EmployeeEducation entity)
        {
            throw new NotImplementedException();
        }
    }
}
