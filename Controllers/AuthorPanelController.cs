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
    public class AuthorPanelController : Controller
    {
        TitleManager titleManager = new TitleManager(new EfTitleDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        Context context = new Context();
        // GET: AuthorPanel
        public ActionResult AuthorProfile()
        {
            return View();
        }
        public ActionResult MyTitle(string session)
        {
            session = (string)Session["AuthorEmail"];
            var authorIdInfo = context.Authors.Where(x => x.AuthorEmail == session).Select(y => y.AuthorId).FirstOrDefault();
            var values = titleManager.GetListByAuthor(authorIdInfo);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewTitle()
        {
            List<SelectListItem> categoryValues = (from x in categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.vlc = categoryValues;
            return View();
        }
        [HttpPost]
        public ActionResult NewTitle(Title title)
        {
            string authorMailInfo = (string)Session["AuthorEmail"];
            var authorIdInfo = context.Authors.Where(x => x.AuthorEmail == authorMailInfo).Select(y => y.AuthorId).FirstOrDefault();
            title.TitleDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            title.AuthorId = authorIdInfo;
            title.TitleStatus = true;
            titleManager.AddTitle(title);
            return RedirectToAction("MyTitle");
        }
        [HttpGet]
        public ActionResult UpdateTitle(int id)
        {
            List<SelectListItem> categoryValues = (from x in categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            var titleValue = titleManager.GetById(id);
            ViewBag.vlc = categoryValues;
            return View(titleValue);
        }
        [HttpPost]
        public ActionResult UpdateTitle(Title title)
        {
            titleManager.UpdateTitle(title);
            return RedirectToAction("MyTitle");
        }
        public ActionResult DeleteTitle(int id)
        {
            var titleValue = titleManager.GetById(id);
            titleValue.TitleStatus = false;
            titleManager.DeleteTitle(titleValue);
            return RedirectToAction("MyTitle");
        }
        public ActionResult AllTitle()
        {
            var titleValues = titleManager.GetList();
            return View(titleValues);
        }
    }
}