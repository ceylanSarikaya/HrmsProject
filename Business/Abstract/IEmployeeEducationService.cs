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
    public interface IEmployeeEducationService
    {
        Task<IDataResult<List<EmployeeEducation>>>GetAll();
        Task<IDataResult<EmployeeEducation>> GetById(int id);
        Task< IResult> Add(EmployeeEducation entity);
        Task< IResult> Update(EmployeeEducation entity);
        Task <IResult> Delete(EmployeeEducation employeeEducation);
    }
}
