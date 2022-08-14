using Store.Core.Sale;
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

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }


        public string Password { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Status { get; set; }


        public List<sale>  sales { get; set; }

        public user()
        {
            sales = new List<sale>();
        }

    }
}
