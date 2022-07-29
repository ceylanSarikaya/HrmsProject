using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeEducationManager:IEmployeeEducationService
    {
        IEmployeeEducationRepository _employeeEducationRepository;

        public EmployeEducationManager(IEmployeeEducationRepository employeeEducationRepository)
        {
            _employeeEducationRepository = employeeEducationRepository;
        }
    }
}
