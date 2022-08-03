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
    public class ReferenceManager:IReferenceService
    {
        IReferenceRepository _referenceRepository;

        public ReferenceManager(IReferenceRepository referenceRepository)
        {
            _referenceRepository = referenceRepository;
        }

        public Task<IResult> Add(Reference reference)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(Reference reference)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<Reference>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Reference>> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(Reference reference)
        {
            throw new NotImplementedException();
        }
    }
}
