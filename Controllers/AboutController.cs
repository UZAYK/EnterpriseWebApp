using System.Linq;
using System.Web.Mvc;

using EnterpriseWebApp.Models.Model;
using EnterpriseWebApp.Models.Context;

namespace EnterpriseWebApp.Controllers
{
    public class AboutController : Controller
    {
        EnterpriseDB db = new EnterpriseDB();

        public ActionResult Index()
        {
            var about = db.AboutUs.ToList();
            return View(about);
        }

        public ActionResult Edit(int id)
        {
            var about = db.AboutUs.Where(x => x.AboutUsId == id).FirstOrDefault();
            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(AboutUs model, int id)
        {
            if (ModelState.IsValid)
            {
                var about = db.AboutUs.Where(x => x.AboutUsId == id).SingleOrDefault();
                about.Description = model.Description;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
