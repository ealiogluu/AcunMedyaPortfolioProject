using AccunMedyaPortfolioProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
        {
            var projects = db.Projects.Count();
            var experiences = db.Experiences.Count();
            var references = db.Testimonials.Count();

            ViewBag.Projects = projects;
            ViewBag.Experiences = experiences;
            ViewBag.References = references;

            return View();
        }
    }
}