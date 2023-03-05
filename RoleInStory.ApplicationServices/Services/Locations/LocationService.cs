using AutoMapper;
using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoleInStory.Application.Services.Locations.Dtos;
using RoleInStory.Business.Services.BaseService;
using RoleInStory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleInStory.Application.Services.Locations
{
    public class LocationService : GeneralService<Location, LocationDto>, ILocationService
    {
        public LocationService(RoleInStoryContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
