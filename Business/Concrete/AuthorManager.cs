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
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void AddAuthor(Author author)
        {
            _authorDal.Insert(author);        
        }

        public void DeleteAuthor(Author author)
        {
            _authorDal.Delete(author);
        }

        public Author GetById(int id)
        {
           return _authorDal.Get(x=>x.AuthorId==id);
        }

        public List<Author> GetList()
        {
            return _authorDal.List();
        }

        public void UpdateAuthor(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
