using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //GenericRepository<Category> _genericRepository = new GenericRepository<Category>();

        //public List<Category> GetAll()
        //{
        //    return _genericRepository.List();
        //}

        //public void CategoryAdd(Category category)
        //{

        //    if (category.CategoryName == "" || category.CategoryName.Length <= 2 || category.CategoryName.Length >= 51 || category.CategoryDescription == "")
        //    {

        //    }
        //    else
        //    {
        //        _genericRepository.Insert(category);
        //    }
        //}

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
