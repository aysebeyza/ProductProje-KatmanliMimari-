using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductProjeEntity.Concreat;

namespace ProductProjeBusiness.Abstract
{
    internal interface IOrderService
    {
        List<Order> List();
        Order GetbyId(int id);
        void OrderInsert(Order entity);
        void OrderUpdate(Order entity);
        void OrderDelete(Order entity);
    }
}
