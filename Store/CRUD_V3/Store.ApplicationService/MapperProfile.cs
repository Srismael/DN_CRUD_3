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
        }
    }
}
