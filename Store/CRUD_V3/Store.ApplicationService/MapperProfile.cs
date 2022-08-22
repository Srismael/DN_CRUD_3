using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {
            CreateMap<Core.User.user, Store.Dto.userDto>();
            //CreateMap<Core.Sale.sale, Store.Dto.saleDto>();
            //CreateMap<Core.Sale.sale_detail, Store.Dto.saleDetailDto>();
            //CreateMap<Core.Inventories.brand, Store.Dto.brandDto>();
            //CreateMap<Core.Inventories.category, Store.Dto.categoryDto>();
            //CreateMap<Core.Inventories.product, Store.Dto.productDto>();
        }
    }
}
