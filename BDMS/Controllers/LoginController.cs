using BDMS.Data;
using BDMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BDMS.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult DonorLogin()
        {
            if (TempData.ContainsKey("Id"))
            {
                TempData.Remove("Id");
            }

            if (TempData.ContainsKey("Date"))
            {
                TempData.Remove("Date");
            }

            if (TempData.ContainsKey("CampId"))
            {
                TempData.Remove("CampId");
            }

            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DonorLogin(Donor obj)
        {
            var FromDb = _db.Donors.FromSql($"SELECT * FROM [BDMS].[dbo].[Donors] WHERE Email={obj.Email}").FirstOrDefault();

            if (FromDb == null)
            {
                ModelState.AddModelError("Email", "Wrong Email !!");
            }

            else if(FromDb.Password != obj.Password)
            {
                ModelState.AddModelError("Password", "Wrong Password !!");
            }

            else
            {
                return RedirectToAction("Index", "Donor", FromDb);
            }

            return View(obj);
        }

        // GET
        public IActionResult DonorRegister()
        {
            if (TempData.ContainsKey("Id"))
            {
                TempData.Remove("Id");
            }

            if (TempData.ContainsKey("Date"))
            {
                TempData.Remove("Date");
            }

            if (TempData.ContainsKey("CampId"))
            {
                TempData.Remove("CampId");
            }

            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DonorRegister(Donor obj)
        {
            var FromDb = _db.Donors.FromSql($"SELECT * FROM [BDMS].[dbo].[Donors] WHERE Email={obj.Email}");

            if (obj == null)
            {
                return NotFound();
            }
            if(FromDb.Count() >= 1)
            {
                ModelState.AddModelError("Email", "Email already Exists");
                return View(obj);
            }

            obj.Area = _db.Areas.Where(s => s.Name == obj.Area.Name && s.City == obj.Area.City && s.Province == obj.Area.Province).FirstOrDefault();

            if (obj.Area == null)
            {
                ModelState.AddModelError("Area.Name", "Wrong Area !!");
                return View(obj);
            }
            
            obj.AreaCode = obj.Area.Id;
            _db.Donors.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("DonorLogin");
           
        }
    }
}


