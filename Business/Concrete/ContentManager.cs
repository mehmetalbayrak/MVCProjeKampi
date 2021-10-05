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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Content> GetListByAuthor()
        {
            return _contentDal.List(x => x.AuthorId == 2);
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
