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
    internal class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public Order GetbyId(int id)
        {
          return _orderDal.Get(x => x.OrderID == id);
        }

        public List<Order> List()
        {
             return _orderDal.List();
        }

        public void OrderDelete(Order o)
        {
            _orderDal.Delete(o);

        }

        public void OrderInsert(Order o)
        {
            _orderDal.Insert(o);
        }

        public void OrderUpdate(Order o)
        {
            _orderDal.Update(o);
        }
    }
}
