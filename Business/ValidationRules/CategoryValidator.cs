using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori ismi boş olamaz.");
            RuleFor(x=>x.CategoryDescription).NotEmpty().WithMessage("Açıklama boş olamaz.");
            RuleFor(x=>x.CategoryName).MinimumLength(3).WithMessage("Kategori ismi 3 karakterden az olamaz.");
            RuleFor(x=>x.CategoryName).MaximumLength(20).WithMessage("Kategori ismi 20 karakterden fazla olamaz.");
        }
    }
}
