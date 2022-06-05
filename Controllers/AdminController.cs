using System.Linq;
using System.Web.Mvc;
using EnterpriseWebApp.Models.Context;

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