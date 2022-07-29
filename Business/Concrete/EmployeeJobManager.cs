using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeJobManager:IEmployeeJobService
    {
        IEmployeeJobRepository _employeeJobRepository;

        public EmployeeJobManager(IEmployeeJobRepository employeeJobRepository)
        {
            _employeeJobRepository = employeeJobRepository;
        }
    }
}
