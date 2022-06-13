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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create(Service model, HttpPostedFileBase PictureURL)
        {
            if (ModelState.IsValid)
            {
                if (PictureURL != null)
                {
                    //file is valid?
                    if (System.IO.File.Exists(Server.MapPath(model.PictureURL)))
                    {
                        System.IO.File.Delete(Server.MapPath(model.PictureURL));
                    }
                    WebImage img = new WebImage(PictureURL.InputStream);
                    FileInfo fileInfo = new FileInfo(PictureURL.FileName);

                    string logoName = Guid.NewGuid().ToString() + fileInfo.Extension;
                    img.Resize(300, 200);
                    img.Save("~/Uploads/Service/" + logoName);

                    model.PictureURL = "/Uploads/Service/" + logoName;
                }
                db.Services.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}