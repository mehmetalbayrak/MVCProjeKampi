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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void AddContent(Content content)
        {
            _contentDal.Insert(content);
        }

        public void DeleteContent(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByTitle(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            return _contentDal.List();
        }

        public List<Content> GetListByAuthor(int id)
        {
            return _contentDal.List(x => x.AuthorId == id);
        }

        public List<Content> GetListById(int id)
        {
            return _contentDal.List(x => x.TitleId == id);
        }

        public void UpdateContent(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
