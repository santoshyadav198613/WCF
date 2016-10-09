using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseService
{
    public class Cart
    {
        public long CartId { get; set; }
        public List<Product> Products { get; set; }

    }
}
