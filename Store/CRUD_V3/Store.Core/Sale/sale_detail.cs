using Store.Core.Inventories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Sale
{
    public class sale_detail
    {
        public int Id { get; set; }
        public int Id_sale { get; set; }

        public int Id_product { get; set; }

        public product product { get; set; }

        public sale sale { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        public decimal discount { get; set; }
    }
}
