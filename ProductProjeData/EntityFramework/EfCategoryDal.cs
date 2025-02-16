using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductProjeData.Abstract;
using ProductProjeData.Repository;
using ProductProjeEntity.Concreat;

namespace ProductProjeData.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>, ICategoryDal
    {
    }
}
