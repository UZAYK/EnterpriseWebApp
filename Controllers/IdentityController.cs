using EnterpriseWebApp.Models.Context;
using EnterpriseWebApp.Models.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
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
            var identity = db.Identities.Where(x => x.IdentityId == id).SingleOrDefault();
            return View(identity);
        }

        // POST: Identity/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Identity model, HttpPostedFileBase LogoURL)
        {
            if (ModelState.IsValid)
            {
                var identity = db.Identities.Where(x => x.IdentityId == id).SingleOrDefault();
                if (LogoURL != null)
                {
                    //file is valid?
                    if (System.IO.File.Exists(Server.MapPath(identity.LogoURL)))
                    {
                        System.IO.File.Delete(Server.MapPath(identity.LogoURL));
                    }
                    WebImage img = new WebImage(LogoURL.InputStream);
                    FileInfo fileInfo = new FileInfo(LogoURL.FileName);

                    string logoName = Guid.NewGuid().ToString() + fileInfo.Extension;
                    img.Resize(300, 200);
                    img.Save("~/Uploads/Identity/" + logoName);

                    identity.LogoURL = "/Uploads/Identity/" + logoName;
                }
                identity.Title = model.Title;
                identity.Description = model.Description;
                identity.Unvan = model.Unvan;
                identity.Keywords = model.Keywords;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
