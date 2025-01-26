
using AccunMedyaPortfolioProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class IntroductionController : Controller
    {
        // GET: Introduction
        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
        {
            var introductionList = db.Introductions.ToList();
            return View(introductionList);
        }

        [HttpGet]
        public ActionResult CreateIntroduction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateIntroduction(Introduction ıntroduction)
        {
            db.Introductions.Add(ıntroduction);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteIntroduction(int id)
        {
            var value = db.Introductions.Find(id);
            db.Introductions.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateIntroduction(int id)
        {
            var introduction = db.Introductions.Find(id);
            return View(introduction);
        }
        [HttpPost]
        public ActionResult UpdateIntroduction(Introduction introduction)
        {
            var updatedIntroduction= db.Introductions.Find(introduction.Id);
            updatedIntroduction.Title = introduction.Title;
            updatedIntroduction.Description = introduction.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}