using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorLoginManager : IAuthorLoginService
    {
        IAuthorDal _authorDal;

        public AuthorLoginManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public Author GetAuthor(string userName, string password)
        {
            return _authorDal.Get(x => x.AuthorEmail == userName && x.AuthorPassword == password);
        }
    }
}
