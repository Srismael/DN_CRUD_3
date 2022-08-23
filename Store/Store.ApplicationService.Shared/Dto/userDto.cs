using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dto
{
    public class userDto
    {
        public int Id { get; set; }


        [StringLength(20)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; } 
        [Required]
        public string Email { get; set; }



        /*public List<sale> sales { get; set; }

        public user()
        {
            sales = new List<sale>();
        }*/
    }
}
