using EnterpriseWebApp.Models;
using EnterpriseWebApp.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseWebApp.Controllers
{
    public class AdminController : Controller
    {
        EnterpriseDB db = new EnterpriseDB();
        public ActionResult Index()
        {
            var query = db.Categories.ToList();
            return View(query);
        }
    }
}