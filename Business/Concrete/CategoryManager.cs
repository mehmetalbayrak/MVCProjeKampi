using DataAccess.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> _genericRepository = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return _genericRepository.List();
        }

        public void CategoryAdd(Category category)
        {
            if (category.CategoryName=="" || category.CategoryName.Length <= 2 || category.CategoryName.Length >= 51 || category.CategoryDescription=="")
            {
                // hata mesajı
            }
            else
            {
                _genericRepository.Insert(category);
            }
        }
    }
}
