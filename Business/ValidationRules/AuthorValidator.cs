using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.AuthorSurname).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçemezsiniz.");
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Ünvan kısmını boş geçemezsiniz.");
            RuleFor(x => x.AuthorSurname).MinimumLength(2).WithMessage("Yazar ismi 2 karakterden az olamaz.");
            RuleFor(x => x.AuthorSurname).MaximumLength(20).WithMessage("Lütfen en fazla 50 karakter girişi yapın.");
            RuleFor(x => x.AuthorAbout).Must(IsContainA).WithMessage("Hakkında kısmında en az bir defa a harfi kullanılmalıdır.");
        }
        private bool IsContainA(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[a,A])");
                return regex.IsMatch(arg);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
