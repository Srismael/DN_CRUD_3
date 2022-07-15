using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.User
{
    public class user
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime birthday { get; set; }

        public string phone { get; set; }

        public string email { get; set; }
    }
}
