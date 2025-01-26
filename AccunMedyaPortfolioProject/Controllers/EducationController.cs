using AccunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
        {
            var educationList = db.Educations.ToList();
            return View(educationList);
        }
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEducation(Education education)
        {
            db.Educations.Add(education);
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = db.Educations.Find(id);
            db.Educations.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var education = db.Educations.Find(id);
            return View(education);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Education education)
        {
            var updatedaEducation = db.Educations.Find(education.Id);
            updatedaEducation.Title = education.Title;
            updatedaEducation.InstutionName = education.InstutionName;
            updatedaEducation.StartDate = education.StartDate;
            updatedaEducation.EndDate = education.EndDate;
            updatedaEducation.Description = education.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}