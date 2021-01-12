using RepositoryPatternCrudEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternCrudEmployee.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployeeR();
        Employee GetEmployeeR (int id);

        Employee AddR(Employee employee);
        Employee UpdateR(Employee employee);
        Employee DeleteR(int id);

    }
}
