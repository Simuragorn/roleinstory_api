using AutoMapper;
using RoleInStory.Application.AutoMapper.Resolvers;
using RoleInStory.Application.Services.Locations.Dtos;
using RoleInStory.Business.Dtos;
using RoleInStory.Core.Entities;
using RoleInStory.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleInStory.Application.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Location, LocationDto>()
                //.ForMember(d => d.ImageUrl, o => o.MapFrom<LocationImageUrlResolver>())
                .ReverseMap();

            CreateMap<AppUser, UserDto>().ReverseMap();
        }
    }
}
