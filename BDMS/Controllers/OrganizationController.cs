using BDMS.Data;
using BDMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BDMS.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrganizationController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(Organization obj)
        {
            var orgfromdb = _db.Organizations.Where(s => s.Name == obj.Name).Include(b => b.Employees).FirstOrDefault();
            return View(orgfromdb);
        }
        //GET
        public IActionResult Login()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Organization obj)
        {
            var orgfromdb = _db.Organizations.Where(s => s.Name == obj.Name).FirstOrDefault();
            if (obj != null)
            {

                //obj.Employees.Add(_db.Employees.Where(s => s.OrgCode == obj.Id).FirstOrDefault());
                //orgfromdb.Employees = _db.Employees.Where(s => s.OrgCode == orgfromdb.Id);
                //foreach(var obj11 in orgemp)
                //{
                //    orgfromdb.Employees.Add(obj11);
                //}
                //obj.Employees.Add(orgemp);
                return RedirectToAction("Index", orgfromdb);
            }
            else if (orgfromdb == null)
            {
                ModelState.AddModelError("Name", "The Name is wrong");
            }
            else if (orgfromdb.Password != obj.Password)
            {
                ModelState.AddModelError("Password", "The Password is wrong");
            }

            return RedirectToAction("Login");
            //return View(obj);
        }

        //GET
        public IActionResult Organizationregister()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Organizationregister(Organization obj)
        {
            var orgfromdb = _db.Organizations.Where(s => s.Name == obj.Name);
            if (orgfromdb == null) { return NotFound(); }
            if (orgfromdb.Count() > 0)
            {
                ModelState.AddModelError("Name", "Name already exist");
                return RedirectToAction("Organizationregister");
            }
            _db.Organizations.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Login");
        }
    }
}
