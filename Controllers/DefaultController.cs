using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class DefaultController : Controller
    {
        TitleManager titleManager = new TitleManager(new EfTitleDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());
        // GET: Default
        public PartialViewResult Index(int id = 0)
        {
            var contentValues = contentManager.GetListById(id);
            return PartialView(contentValues);
        }
        public ActionResult Titles()
        {
            var titleValues = titleManager.GetList();
            return View(titleValues);
        }
    }
}