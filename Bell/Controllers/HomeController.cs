using BellApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace BellApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Registration");
        }
   
        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Registered Employees";

            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    DateofBirth = row.DateofBirth,
                    EmailAddress = row.EmailAddress,
                    Address = row.Address,
                    PhoneNumber = row.PhoneNumber
                });
            }
            return View(employees);
        }
     
        public ActionResult Registration()
        {
            ViewBag.Message = "Employee Registration";

            return View();
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                int recordsCreated = CreateEmployee(
                    model.FirstName,
                    model.LastName,
                    model.DateofBirth,
                    model.EmailAddress,
                    model.Address,
                    model.PhoneNumber);
                return RedirectToAction("ViewEmployees");
            }

            return View();
        }
    }
}