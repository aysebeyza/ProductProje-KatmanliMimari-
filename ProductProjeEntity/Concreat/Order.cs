using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjeEntity.Concreat
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
       public ICollection<Product> Products { get; set; } 
        // Bir siparişin (Order), birden fazla ürünü (Product) olabilir.


    }
}
