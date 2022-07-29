using Business.Abstract;
using Data.Abstract;
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
    }
}
