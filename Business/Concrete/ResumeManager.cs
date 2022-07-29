using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ResumeManager:IResumeService
    {
        IResumeRepository _resumeRepository;

        public ResumeManager(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }
    }
}
