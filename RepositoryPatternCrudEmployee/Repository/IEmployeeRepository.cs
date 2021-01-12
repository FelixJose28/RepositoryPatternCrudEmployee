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

        void AddR(Employee employee);
        void UpdateR(Employee employee);
        void DeleteR(int id);

    }
}
