using EnterpriseWebApp.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseWebApp.Controllers
{
    public class IdentityController : Controller
    {
        EnterpriseDB db = new EnterpriseDB();

        // GET: Identity
        public ActionResult Index()
        {
            return View(db.Identities.ToList());
        }

        // GET: Identity/Edit/5
        public ActionResult Edit(int id)
        {
            var identity = db.Identities.Where(x => x.IdentityId ==
            id).SingleOrDefault();

            return View(identity);
        }

        // POST: Identity/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IdentityController model, HttpPostedFileBase LogoURL)
        {
            try
            {
                //db.Identities.Add(IdentityController()
                //{

                //});
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
