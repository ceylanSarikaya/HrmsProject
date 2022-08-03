using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReferenceService
    {
        Task<IDataResult<List<Reference>>> GetAll();
        Task<IDataResult<Reference>> GetById();
        Task<IResult> Add(Reference reference);     
        Task<IResult> Update(Reference reference);
        Task<IResult> Delete(Reference reference);

    }
}
