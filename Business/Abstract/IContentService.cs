using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContentService
    {
        List<Content> GetListBySearch(string search);
        List<Content> GetList();
        List<Content> GetListByAuthor(int id);
        List<Content> GetListById(int id);
        void AddContent(Content content);
        void DeleteContent(Content content);
        void UpdateContent(Content content);
        Content GetByTitle(int id);
    }
}
