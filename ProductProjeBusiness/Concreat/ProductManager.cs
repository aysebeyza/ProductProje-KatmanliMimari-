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
    internal class ProductManager : IProductService
    {
        IProductDal _productDal;
        public List<Product> List()
        {
           return _productDal.List();
        }

        public void ProductDelete(Product p)
        {
            _productDal.Delete(p);
        }

        public void ProductInsert(Product p)
        {
            _productDal.Insert(p);
        }

        public void ProductUpdate(Product p)
        {
            _productDal.Update(p);
        }
    }
}
