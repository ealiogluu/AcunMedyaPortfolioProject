using AccunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class ExpertiseController : Controller
    {
        // GET: Expertise
        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
        {
            var list = db.Expertises.ToList();
            return View(list);
        }
        [HttpGet]
        public ActionResult CreateExpertise()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExpertise(Expertise expertise)
        {
            db.Expertises.Add(expertise);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExpertise(int id)
        {
            var value = db.Expertises.Find(id);
            db.Expertises.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateExpertise(int id)
        {
            var expertise = db.Expertises.Find(id);
            return View(expertise);
        }
        [HttpPost]
        public ActionResult UpdateExpertise(Expertise expertise)
        {
            var updatedExpertise = db.Expertises.Find(expertise.Id);
            updatedExpertise.Title = expertise.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}