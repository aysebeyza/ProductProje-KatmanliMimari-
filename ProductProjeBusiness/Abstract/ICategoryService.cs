using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProductProjeEntity.Concreat;

namespace ProductProjeBusiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> List(); 
        void CategoryInsert(Category entity);
        void CategoryUpdate(Category entity);
        void CategoryDelete(Category entity);
      
    }
}
