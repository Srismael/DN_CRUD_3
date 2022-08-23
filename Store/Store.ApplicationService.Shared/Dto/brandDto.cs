using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dto
{
    public class brandDto
    {
        
        public string Name { get; set; }
        public string Description { get; set; }

        public List<productDto> poductsDto { get; set; }

        public brandDto()
        {
            poductsDto = new List<productDto>();


        }
    }
}
