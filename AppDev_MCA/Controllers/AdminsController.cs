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

        // GET: Admins
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListTrainingStaff()
        {
            return View();
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