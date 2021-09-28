using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorController : Controller
    {
        AuthorManager authorManager = new AuthorManager(new EfAuthorDal());
        AuthorValidator validationRules = new AuthorValidator();
        // GET: Author
        public ActionResult Index()
        {
            var authorValues = authorManager.GetList();
            return View(authorValues);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author author)
        {
            ValidationResult validationResult = validationRules.Validate(author);
            if (validationResult.IsValid)
            {
                authorManager.AddAuthor(author);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditAuthor(int id)
        {
            var authorValue = authorManager.GetById(id);
            return View(authorValue);
        }
        [HttpPost]
        public ActionResult EditAuthor(Author author)
        {
            ValidationResult validationResult = validationRules.Validate(author);
            if (validationResult.IsValid)
            {
                authorManager.UpdateAuthor(author);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}