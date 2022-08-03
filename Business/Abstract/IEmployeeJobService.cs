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
    public interface IEmployeeJobService
    {
        Task<IDataResult <List<EmployerJob>>>GetAll();
        Task<IDataResult <EmployerJob>> GetById(int Id);
        Task <IResult> Add(EmployerJob job);
        Task<IResult> Update(EmployerJob job);
        Task <IResult> Delete(EmployerJob employerJob);

    }
}
