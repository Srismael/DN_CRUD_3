using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dto
{
    public class saleDetailDto
    {
        [Key]
        public int Id { get; set; }
        public int Id_sale { get; set; }

        public int Id_product { get; set; }

        public productDto product { get; set; }

        public saleDto sale { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        public decimal discount { get; set; }
    }
}
