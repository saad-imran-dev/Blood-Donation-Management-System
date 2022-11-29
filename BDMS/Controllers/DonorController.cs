using BDMS.Data;
using BDMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BDMS.Controllers
{
    public class DonorController : Controller
    {
        public readonly ApplicationDbContext _db;

        public DonorController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index(Donor obj)
        {
            if(TempData.ContainsKey("Id"))
            {
                obj = _db.Donors.Where(s => s.Id == Convert.ToInt32(TempData["Id"])).FirstOrDefault(); ;
            }

            if (obj == null)
            {
                return NotFound();
            }

            obj.Area = _db.Areas.Where(s => obj.AreaCode == s.Id).FirstOrDefault();

            if (obj.Area == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // GET
        public IActionResult EditInfo(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var obj = _db.Donors.Find(Id);
            obj.Area = _db.Areas.Find(obj.AreaCode);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditInfo(Donor obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            obj.Area = _db.Areas.Where(s => s.Name == obj.Area.Name && s.City == obj.Area.City && s.Province == obj.Area.Province).FirstOrDefault();

            if (obj.Area == null)
            {
                ModelState.AddModelError("Area.Name", "Wrong Area !!");
                return View(obj);
            }

            obj.AreaCode = obj.Area.Id;
            _db.Donors.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", obj);
        }

        // GET
        public IActionResult DonateOrg()
        {
            TempData["Id"] = TempData["Id"];

            //IEnumerable<BloodCamp> camps = _db.BloodCamps.FromSql($"SELECT * FROM [BDMS].[dbo].[BloodCamps]");
            //var camps = _db.BloodCamps.FromSql($"SELECT * FROM [BDMS].[dbo].[BloodCamps] b JOIN [BDMS].[dbo].[Areas] a on b.AreaCode=a.Id JOIN [BDMS].[dbo].[Organizations] o on b.OrgCode=o.Id");
            var camps = _db.BloodCamps.Include(b => b.Area).Include(b => b.Organization);

            //foreach(BloodCamp c in camps)
            //{
            //    c.Area = _db.Areas.Find(c.AreaCode);
            //    c.Organization = _db.Organizations.Find(c.OrgCode);
            //}

            return View(camps);
        }

        // GET
        public IActionResult DonateSlot()
        {
            return View();
        }
    }
}
