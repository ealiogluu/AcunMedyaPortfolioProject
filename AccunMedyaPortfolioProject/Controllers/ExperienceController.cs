using AccunMedyaPortfolioProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
        {
            var list = db.Experiences.ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExperience(Experience experience)
        {
            db.Experiences.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            var experience = db.Experiences.Find(id);
            db.Experiences.Remove(experience);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = db.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateExperience(Experience experience)
        {
           var updatedExperience= db.Experiences.Find(experience.Id);
            updatedExperience.Title = experience.Title;
            updatedExperience.CompanyName = experience.CompanyName;
            updatedExperience.StartDate = experience.StartDate;
            updatedExperience.EndDate = experience.EndDate;
            updatedExperience.Description = experience.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}