﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dto
{
    public class categoryDto
    {
        
        public string Name { get; set; }
        public string Description { get; set; }

        public List<productDto> ProductsDto { get; set; }

        public categoryDto()
        {
            ProductsDto = new List<productDto>();
        }
    }
}
