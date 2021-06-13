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
    public class TrainersController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        public TrainersController()
        {
            _context = new ApplicationDbContext();
            _userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(new ApplicationDbContext())
            );
        }
        // GET: Trainers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewProfile()
        {
            var CurrentTrainerId = User.Identity.GetUserId();
            var TrainerInDb = _context.TrainerUsers.SingleOrDefault(t => t.Id == CurrentTrainerId);
            return View(TrainerInDb);
        }
    }
}