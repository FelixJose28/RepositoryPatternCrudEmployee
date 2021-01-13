using Microsoft.AspNetCore.Mvc;
using RepositoryPatternCrudEmployee.Models;
using RepositoryPatternCrudEmployee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternCrudEmployee.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _employeeRepository.GetAllEmployeeR());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.AddR(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _employeeRepository.GetEmployeeR(id);
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeRepository.DeleteR(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var employee = _employeeRepository.GetEmployeeR(id);
            return View(employee);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = _employeeRepository.GetEmployeeR(id);
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.UpdateR(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
            
        }
    }
}
