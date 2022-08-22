using Store.Core.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Sale
{
    public class sale
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Total { get; set; }

        public string status { get; set; }

        public user user { get; set; }
    }
}
