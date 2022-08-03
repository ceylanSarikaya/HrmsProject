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
    public interface IEmployeeService
    {
        Task<IDataResult <List<Employee>>> GetAll();
        Task<IDataResult <Employee>> GetById(int id);
        Task<IResult> Add(Employee employee);
        Task<IResult> Update(Employee employee);
        Task<IResult> Delete(Employee employee);
    }
}
