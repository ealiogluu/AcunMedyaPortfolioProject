using AccunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSiteHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialIntro()
        {
            var introduction = db.Introductions.FirstOrDefault();
            return PartialView(introduction);
        }

        public PartialViewResult PartialAbout()
        {
            var about = db.Abouts.FirstOrDefault();
            return PartialView(about);
        }

        public PartialViewResult PartialExperience()
        {
            var experience = db.Experiences.ToList();
            return PartialView(experience);
        }
        public PartialViewResult PartialEducation()
        {
            var education = db.Educations.ToList();
            return PartialView(education);
        }

        public PartialViewResult PartialProject()
        {
            var projects =db.Projects.ToList();
            return PartialView(projects);
        }
        public PartialViewResult PartialTestimonial()
        {
            var testimonials = db.Testimonials.ToList();
            return PartialView(testimonials);
        }

        public PartialViewResult PartialContact()
        {
            var contact = db.Contacts.ToList();
            return PartialView(contact);
        }
        public PartialViewResult PartialFooter()
        {
            var category = db.Categories.ToList();
            return PartialView(category);
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialExpertise()
        {
            var expertise = db.Expertises.ToList();
            return PartialView(expertise);
        }
        public PartialViewResult PartialSocialMedia()
        {
            var socialMedia = db.SocialMedias.ToList();
            return PartialView(socialMedia);
        }

    }
}