using EnterpriseWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseWebApp.Controllers
{
    public class AdminController : Controller
    {
        EnterpriseDBEntities db = new EnterpriseDBEntities();
        // GET: Admin
        public ActionResult Index()
        {
            var query = db.Categories.ToList();
            return View(query);
        }
    }
}