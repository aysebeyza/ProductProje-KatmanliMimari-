using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjeEntity.Concreat
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; } // her ürünün bir siparişi olabilir
        public virtual Category Category { get; set; } // her ürünün bir kategorisi olabilir

    }
}
