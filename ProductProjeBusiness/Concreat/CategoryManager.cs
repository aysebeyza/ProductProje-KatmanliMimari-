using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductProjeBusiness.Abstract;
using ProductProjeData.Abstract;
using ProductProjeEntity.Concreat;


namespace ProductProjeBusiness.Concreat
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public void CategoryDelete(Category c)
        {
           _categoryDal.Delete(c);
        }

        public void CategoryInsert(Category c)
        {
            _categoryDal.Insert(c);
        }

        public List<Category> List()
        {
            return _categoryDal.List();
        }

        public void CategoryUpdate(Category c)
        {
          _categoryDal.Update(c);
        }
    }
}
