using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void AddCategory(Category category);
        Category GetById(int id);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
    }
}
