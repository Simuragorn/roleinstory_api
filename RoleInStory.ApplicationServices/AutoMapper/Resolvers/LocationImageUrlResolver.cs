using AutoMapper;
using Microsoft.Extensions.Configuration;
using RoleInStory.Application.Services.Locations.Dtos;
using RoleInStory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleInStory.Application.AutoMapper.Resolvers
{
    public class LocationImageUrlResolver : IValueResolver<Location, LocationDto, string>
    {
        private readonly IConfiguration _configuration;
        public LocationImageUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(Location source, LocationDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.ImageUrl))
            {
                //Condition
            }
            return null;
        }
    }
}
