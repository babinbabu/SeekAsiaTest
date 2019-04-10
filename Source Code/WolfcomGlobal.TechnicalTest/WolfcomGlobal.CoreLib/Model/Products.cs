using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfcomGlobal.CoreLib.Entity;

namespace WolfcomGlobal.CoreLib.Model
{
    public class Products
    {
        public long ProductCode { get; set; }
        public string ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public int Count { get; set; }

        public Products()
        {

        }

        public Products(ProductDetail entity, int count)
        {
            ProductCode = entity.ProductCode;
            ProductId = entity.ProductId;
            ProductPrice = entity.ProductPrice;
            Count = count;

        }

    }
}
