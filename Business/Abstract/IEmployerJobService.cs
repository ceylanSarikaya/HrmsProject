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
    public interface IEmployerJobService
    {
        Task<IDataResult<List <EmployeeJob>>> GetAll();
        Task<IDataResult <EmployeeJob>>GetById(int id);
        Task<IResult> Add(EmployeeJob employeejob);
        Task<IResult> Update(EmployeeJob employeejob);
        Task <IResult> Delete(EmployeeJob employeejob);
    }
}
