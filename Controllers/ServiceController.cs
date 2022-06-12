using EnterpriseWebApp.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseWebApp.Controllers
{
    public class ServiceController : Controller
    {
        private EnterpriseDB db = new EnterpriseDB();

        // GET: Service
        public ActionResult Index()
        {
            return View(db.Services.ToList());
        }
        
        public ActionResult Create()
        {
            return View();
        }
    }
}