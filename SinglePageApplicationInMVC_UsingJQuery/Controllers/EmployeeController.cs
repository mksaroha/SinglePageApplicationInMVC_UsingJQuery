using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SinglePageApplicationInMVC_UsingJQuery.Models;
using System.Data.Entity;

namespace SinglePageApplicationInMVC_UsingJQuery.Controllers
{
    public class EmployeeController : Controller
    {
        AppContext _context = new AppContext(); 
        // GET: Employee
        public ActionResult Index()
        {            
            ViewBag.CountryList = _context.Countries.ToList();
            return View("Index");
            //I did this to remove "Confirm Form Submission" Message on page load every time
        }



        public JsonResult GetEmployees()
        {
            var employees = (from a in _context.Employees
                             join b in _context.Countries
                                on a.CountryId equals b.CountryId
                             select new { a.Id, a.FullName, a.Email, a.Password, a.Telephone, a.Address, a.Gender,a.IsActive, b.CountryId, b.CountryName }).ToList();
            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        //public JsonResult GetCountry()
        //{
        //    var country = _context.Countries.ToList();
        //    return Json(country, JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {            
            if(ModelState.IsValid)
            {
                if (employee.Id == 0)
                {
                    _context.Employees.Add(employee);
                }
                else
                {
                    _context.Entry(employee).State = EntityState.Modified;
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }           
            else
            {
                ViewBag.CountryList = _context.Countries.ToList();
                return View("Index");
            }             
        }

        public ActionResult Edit(int id)
        {
            var employee = (from a in _context.Employees
                            join b in _context.Countries
                               on a.CountryId equals b.CountryId
                            where a.Id == id
                            select new { a.FullName, a.Email, a.Password, a.Telephone, a.Address, a.Gender,a.IsActive, b.CountryId, b.CountryName }).ToList();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }


        public void Delete(int id)
        {
             var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
    }
}