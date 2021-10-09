using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var values = adminManager.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin admin)
        {
            adminManager.AddAdmin(admin);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var adminValue = adminManager.GetById(id);
            return View(adminValue);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(Admin admin)
        {
            adminManager.UpdateAdmin(admin);
            return RedirectToAction("Index");
        }
    }
}