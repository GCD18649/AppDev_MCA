using AppDev_MCA.Models;
using AppDev_MCA.ViewModel;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AppDev_MCA.Controllers
{
    public class TrainingStaffsController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        public TrainingStaffsController()
        {
            _context = new ApplicationDbContext();
            _userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(new ApplicationDbContext())
            );
        }
        // GET: TrainingStaffs
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageAccount()
        {
            return View();
        }
        public ActionResult ListCategory(string searchString)
        {
            var categories = _context.Categories.ToList();
            if (!searchString.IsNullOrWhiteSpace())
            {
                categories = _context.Categories
                .Where(c => c.Name.Contains(searchString))
                .ToList();
            }
            return View(categories);
        }
        public ActionResult DetailCategory(int id)
        {
            var categoryInDb = _context.Categories.SingleOrDefault(c => c.Id == id);

            return View(categoryInDb);
        }
        public ActionResult DeleteCategory(int id)
        {
            var categoryInDb = _context.Categories.SingleOrDefault(c => c.Id == id);
            _context.Categories.Remove(categoryInDb);
            _context.SaveChanges();
            return RedirectToAction("ListCategory");
        }

    }
}