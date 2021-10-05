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
    public class TitleManager : ITitleService
    {
        ITitleDal _titleDal;

        public TitleManager(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }

        public void AddTitle(Title title)
        {
            _titleDal.Insert(title);
        }

        public void DeleteTitle(Title title)
        {
            _titleDal.Update(title);
        }

        public Title GetById(int id)
        {
            return _titleDal.Get(x => x.TitleId == id);
        }

        public List<Title> GetList()
        {
            return _titleDal.List();
        }

        public List<Title> GetListByAuthor()
        {
            return _titleDal.List(x => x.AuthorId == 2);
        }

        public void UpdateTitle(Title title)
        {
            _titleDal.Update(title);
        }
    }
}
