using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager contentManager = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllContent(string search)
        {
            var values = contentManager.GetListBySearch(search);
            return View(values);
        }
        public ActionResult ContentByTitle(int id)
        {
            var contentValues = contentManager.GetListById(id);
            return View(contentValues);
        }
    }
}