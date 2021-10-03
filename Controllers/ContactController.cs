using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator contactValidator = new ContactValidator();
        // GET: Contact
        public ActionResult Index()
        {
            var contactValues = contactManager.GetList();
            return View(contactValues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactValue = contactManager.GetById(id);
            return View(contactValue);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}