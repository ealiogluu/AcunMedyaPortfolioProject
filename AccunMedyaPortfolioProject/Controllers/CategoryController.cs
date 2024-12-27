using AccunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult CategoryList()
        {
            var categoryList = db.Categories.ToList();
            return View(categoryList);
        }

        [HttpGet] //sayfayı göstermek için
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost] //butona bastığımızda ne olacağı
        public ActionResult CreateCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            var category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = db.Categories.Find(id);
            return View(category);
        }
    }
}