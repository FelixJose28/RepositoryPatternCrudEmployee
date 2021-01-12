using RepositoryPatternCrudEmployee.Data;
using RepositoryPatternCrudEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternCrudEmployee.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Employee AddR(Employee employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee DeleteR(int id)
        {
            Employee employee = _context.Employee.FirstOrDefault(m => m.Id == id);
            if(employee != null)
            {
                _context.Employee.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
            
        }

        public IEnumerable<Employee> GetAllEmployeeR()
        {
            return _context.Employee.ToList();
        }

        public Employee GetEmployeeR(int id)
        {
            Employee employee = _context.Employee.FirstOrDefault(m => m.Id == id);
            return employee;
        }

        public Employee UpdateR(Employee employee)
        {
            _context.Employee.Update(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}
