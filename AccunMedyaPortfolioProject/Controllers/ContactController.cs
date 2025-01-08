using AccunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace AccunMedyaPortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        PortfolioDBEntities1 db = new PortfolioDBEntities1 ();
        public ActionResult Index()
        {
            var contactList = db.Contacts.ToList ();
            return View(contactList);
        }

        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            db.Contacts.Add (contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(int id)
        {
            var value = db.Contacts.Find (id);
            db.Contacts.Remove (value);
            db.SaveChanges();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var contact = db.Contacts.Find (id);
            return View(contact);
        }
        [HttpPost]
        public ActionResult UpdateContact(Contact contact)
        {
            var updatedContact = db.Contacts.Find (contact.Id);
            updatedContact.Mail = contact.Mail;
            updatedContact.Phone = contact.Phone;
            updatedContact.Adress = contact.Adress;

            db.SaveChanges ();
            return RedirectToAction("Index");
        }
    }
}