using AccunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
        {
            var aboutList = db.Abouts.ToList();
            return View(aboutList);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            db.Abouts.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = db.Abouts.Find(id);
            db.Abouts.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]

        public ActionResult UpdateAbout(int id)
        {
            var about = db.Abouts.Find(id);
            return View(about);
        }

        [HttpPost]

        public ActionResult UpdateAbout(About about)
        {
            var updatedAbout = db.Abouts.Find(about.Id);
            updatedAbout.Title = about.Title;
            updatedAbout.Description = about.Description;
            updatedAbout.CVLink = about.CVLink;
            updatedAbout.ImageUrl = about.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}