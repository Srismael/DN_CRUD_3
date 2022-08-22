using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dto
{
    public class saleDto
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Total { get; set; }

        public string status { get; set; }

        public userDto user { get; set; }
    }
}
