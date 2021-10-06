using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
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
        Context context = new Context();
        // GET: AuthorPanelContent
        public ActionResult MyContent(string session)
        {   
            session = (string)Session["AuthorEmail"];
            var authorInfo = context.Authors.Where(x => x.AuthorEmail == session).Select(y => y.AuthorId).FirstOrDefault();
            var contentValues = contentManager.GetListByAuthor(authorInfo);
            return View(contentValues);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.value = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content content)
        {
            string mail = (string)Session["AuthorEmail"];
            var authorIdInfo = context.Authors.Where(x => x.AuthorEmail == mail).Select(y => y.AuthorId).FirstOrDefault();
            content.AuthorId = authorIdInfo;
            content.ContentStatus = true;
            content.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            contentManager.AddContent(content);
            return RedirectToAction("MyContent");
        }
        public ActionResult ToDoList()
        {
            return View();
        }
    }
}