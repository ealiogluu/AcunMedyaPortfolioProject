﻿using AccunMedyaPortfolioProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        PortfolioDBEntities1 db = new PortfolioDBEntities1();
        public ActionResult Index()
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
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var updatedCategory = db.Categories.Find(category.Id);
            updatedCategory.Name = category.Name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}