using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseService
{
    public class Product
    {
        public long ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal MSRP { get; set; }

        public decimal SellingPrice { get; set; }
    }
}
