using BDMS.Data;
using BDMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BDMS.Controllers
{
    public class EmpController : Controller
    {

        public readonly ApplicationDbContext _db;

        public EmpController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(Employee obj)
        {
            int id;

            if (!TempData.ContainsKey("successEmp"))
            {
                return RedirectToAction("EmpLogin", "Login");
            }

            if(obj.Id != 0)
            {
                TempData["Id"] = obj.Id;
                id = obj.Id;
            }

            else if (TempData.ContainsKey("Id"))
            {
                id = Convert.ToInt32(TempData["Id"]);
            }

            else
            {
                return NotFound();
            }

            var Slots = _db.Slots.Where(x => x.DonorId == id && x.Date.Date == DateTime.Now.Date).Include(d=> d.Donor);
            

            return View(Slots);
        }

        public IActionResult Logout()
        {
            if (TempData.ContainsKey("Id"))
            {
                TempData.Remove("Id");
            }

            if (TempData.ContainsKey("successEmp"))
            {
                TempData.Remove("successEmp");
            }

            return RedirectToAction("EmpLogin", "Login");
        }
    }
}
