using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorPanelContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        // GET: AuthorPanelContent
        public ActionResult MyContent()
        {
            var contentValues = contentManager.GetListByAuthor();
            return View(contentValues);
        }
    }
}