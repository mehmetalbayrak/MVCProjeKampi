using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITitleService
    {
        List<Title> GetList();
        void AddTitle(Title title);
        void DeleteTitle(Title title);
        void UpdateTitle(Title title);
        Title GetById(int id);
    }
}
