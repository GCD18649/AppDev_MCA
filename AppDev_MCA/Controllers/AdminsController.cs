using AppDev_MCA.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppDev_MCA.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class AdminsController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        public AdminsController()
        {
            _context = new ApplicationDbContext();
            _userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(new ApplicationDbContext())
            );
        }
        // GET: Admins
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListTrainingStaff()
        {
            var roleid = _context.Roles.Where(x => x.Name.Equals("STAFF")).FirstOrDefault().Id;
            var staffInDb = _context.Users.Where(s => s.Roles.Any(r => r.RoleId == roleid));
            return View(staffInDb);
        }
        public ActionResult RemoveTrainingStaffAccount()
        {
            return View();
        }
        public ActionResult CreateTrainingStaff()
        {
            return View();
        }
    }
}