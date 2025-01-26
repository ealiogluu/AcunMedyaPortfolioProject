using AccunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
        {
            var list = db.SocialMedias.ToList();
            return View(list);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            db.SocialMedias.Add(socialMedia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var socialMedia = db.SocialMedias.Find(id);
            db.SocialMedias.Remove(socialMedia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var socialMedia = db.SocialMedias.Find(id);
            return View(socialMedia);
           
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var updatedSocialMedia = db.SocialMedias.Find(socialMedia.Id);
            updatedSocialMedia.Platform = socialMedia.Platform;
            updatedSocialMedia.PlatformLink = socialMedia.PlatformLink;
            updatedSocialMedia.ImageUrl = socialMedia.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}