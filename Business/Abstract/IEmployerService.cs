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
    public interface IEmployerService
    {
        Task<IDataResult<List<Employer>>> GetAll();
        Task<IDataResult<Employer>> GetById();
        Task <IResult> Add(Employer employer);
        Task<IResult> Update(Employer employer);
        Task<IResult> DeleteById(Employer employer);
    }
}
