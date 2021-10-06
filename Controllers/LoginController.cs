using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Context context = new Context();
            var adminUserInfo = context.Admins.FirstOrDefault(x => x.AdminUserName == admin.AdminUserName && x.AdminPassword == admin.AdminPassword);
            if (adminUserInfo !=null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.AdminUserName,false);
                Session["AdminUserName"] = adminUserInfo.AdminUserName;
                return RedirectToAction("Index","AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthorLogin(Author author)
        {
            Context context = new Context();
            var authorUserInfo = context.Authors.FirstOrDefault(x => x.AuthorEmail == author.AuthorEmail && x.AuthorPassword == author.AuthorPassword);
            if (authorUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(authorUserInfo.AuthorEmail, false);
                Session["AuthorEmail"] = authorUserInfo.AuthorEmail;
                return RedirectToAction("MyContent", "AuthorPanelContent");
            }
            else
            {
                return RedirectToAction("AuthorLogin");
            }
        }
        public ActionResult LogOut() 
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Titles","Default");
        }
    }
}