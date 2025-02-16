using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductProjeEntity.Concreat;

namespace ProductProjeBusiness.Abstract
{
    internal interface IProductService
    {
        List<Product> List();
        void ProductInsert(Product entity);
        void ProductUpdate(Product entity);
        void ProductDelete(Product entity);
    }
}
